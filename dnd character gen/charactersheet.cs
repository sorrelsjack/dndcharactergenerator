using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using dnd_character_gen.Dictionaries;
using dnd_character_gen.Forms;

namespace dnd_character_gen
{
    public partial class CharacterSheet : Form
    {
        private Character currentCharacter = new Character();
        public ConsoleLog log = new ConsoleLog();

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void CharacterSheet_LocationChanged(object sender, EventArgs e) 
        {
            log.Location = new System.Drawing.Point(Width + Location.X, Height / 3 + Location.Y);
            log.Show();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            log.StartPosition = FormStartPosition.Manual;

            equipmentListView.View = View.List;
            equipmentListView.GridLines = true;

            xpTextBox.Text = currentCharacter.xp.ToString();
            proficiencyTextBox.Text = currentCharacter.proficiencyBonus.ToString();
        }

        private void CharacterSheet_Shown(object sender, EventArgs e) 
        {
            log.Location = new System.Drawing.Point(Width + Location.X, Height / 3 + Location.Y);
            log.Show();
        }

        private void PopulateStatBoxes() //todo: make prettier
        {
            currentCharacter.generateStatArray();
            //TODO: Tooltip over every stat to show where it's coming from (e.g. Dex mod: Base roll, race, etc..)

            strengthValueTextBox.Text = currentCharacter.strength.ToString();
            dexterityValueTextBox.Text = currentCharacter.dexterity.ToString();
            constitutionValueTextBox.Text = currentCharacter.constitution.ToString();
            intelligenceValueTextBox.Text = currentCharacter.intelligence.ToString();
            wisdomValueTextBox.Text = currentCharacter.wisdom.ToString();
            charismaValueTextBox.Text = currentCharacter.charisma.ToString();

            strengthModifierTextBox.Text = currentCharacter.strengthModifier.ToString();
            dexterityModifierTextBox.Text = currentCharacter.dexterityModifier.ToString();
            constitutionModifierTextBox.Text = currentCharacter.constitutionModifier.ToString();
            intelligenceModifierTextBox.Text = currentCharacter.intelligenceModifier.ToString();
            wisdomModifierTextBox.Text = currentCharacter.wisdomModifier.ToString();
            charismaModifierTextBox.Text = currentCharacter.charismaModifier.ToString();

            passivePerceptionTextBox.Text = (10 + currentCharacter.wisdomModifier).ToString();
        }

        private void PopulateSavingThrows() //todo: make prettier
        {
            strengthSavingThrowCheckBox.Checked = currentCharacter.savingThrowProficiencies.Contains("Strength") ? true : false;
            strengthSavingThrowTextBox.Text = (currentCharacter.proficiencyBonus + currentCharacter.strengthModifier).ToString();

            dexteritySavingThrowCheckBox.Checked = currentCharacter.savingThrowProficiencies.Contains("Dexterity") ? true : false;
            dexteritySavingThrowTextBox.Text = (currentCharacter.proficiencyBonus + currentCharacter.dexterityModifier).ToString();

            constitutionSavingThrowCheckBox.Checked = currentCharacter.savingThrowProficiencies.Contains("Constitution") ? true : false;
            constitutionSavingThrowTextBox.Text = (currentCharacter.proficiencyBonus + currentCharacter.constitutionModifier).ToString();

            intelligenceSavingThrowCheckBox.Checked = currentCharacter.savingThrowProficiencies.Contains("Intelligence") ? true : false;
            intelligenceSavingThrowTextBox.Text = (currentCharacter.proficiencyBonus + currentCharacter.intelligenceModifier).ToString();

            wisdomSavingThrowCheckBox.Checked = currentCharacter.savingThrowProficiencies.Contains("Wisdom") ? true : false;
            wisdomSavingThrowTextBox.Text = (currentCharacter.proficiencyBonus + currentCharacter.wisdomModifier).ToString();

            charismaSavingThrowCheckBox.Checked = currentCharacter.savingThrowProficiencies.Contains("Charisma") ? true : false;
            charismaSavingThrowTextBox.Text = (currentCharacter.proficiencyBonus + currentCharacter.charismaModifier).ToString();

            hitPointMaximumTextBox.Text = currentCharacter.hitPoints.ToString();
            currentHitPointsTextBox.Text = currentCharacter.hitPoints.ToString();
        }

        private void PopulateSkillProficiencies()
        {
            string camelCaseSkill = "";
            Dictionary<string, int> skillModifiers = new Dictionary<string, int> //TODO: are all the skills being checked off
            {
                { "Strength", currentCharacter.strengthModifier },
                { "Dexterity", currentCharacter.dexterityModifier },
                { "Constitution", currentCharacter.constitutionModifier },
                { "Intelligence", currentCharacter.intelligenceModifier },
                { "Wisdom", currentCharacter.wisdomModifier },
                { "Charisma", currentCharacter.charismaModifier }
            };

            foreach (var skill in Skills.Instance.skills)
            {
                camelCaseSkill = Regex.Replace(Char.ToLowerInvariant(skill.Key[0]) + skill.Key.Substring(1), " ", "");

                CheckBox checkBox = skillsPanel.Controls.Find(
                    $"{camelCaseSkill}CheckBox", true).FirstOrDefault() as CheckBox;
                checkBox.Checked = currentCharacter.skillProficiencies.Contains(skill.Key) ? true : false;

                TextBox textBox = skillsPanel.Controls.Find(
                    $"{camelCaseSkill}TextBox", true).FirstOrDefault() as TextBox;
                textBox.Text = (currentCharacter.skillProficiencies.Contains(skill.Key)
                    ? skillModifiers.FirstOrDefault(x => x.Key == skill.Value).Value + currentCharacter.proficiencyBonus
                    : skillModifiers.FirstOrDefault(x => x.Key == skill.Value).Value).ToString();
            }
        }

        private void PopulateBackstory()
        { //TODO: Bold headers
            backstoryTextBox.Text =
                $"•Age: {currentCharacter.characterBackstory.age}" +
                $"\n•Birthplace: {currentCharacter.characterBackstory.birthplace}" +
                $"{(!string.IsNullOrWhiteSpace(currentCharacter.characterBackstory.strangeBirthEvent) ? "\n•When you were born, " : "")}{currentCharacter.characterBackstory.strangeBirthEvent}" +
                $"\n•Family: {currentCharacter.characterBackstory.family}" + //TODO: describe that family member
                $"\n\n•Parents: {(currentCharacter.characterBackstory.parents.All(x => x == null) ? "You don't know who your parents are or were." : $"{string.Join("\n", currentCharacter.characterBackstory.parents.Select(p => p.getString()))}")}" +
                $"\n\n•Siblings: {(currentCharacter.characterBackstory.siblings.Any() ? $"{string.Join("\n", currentCharacter.characterBackstory.siblings.Select(p => p.getString()))}" : "You have no siblings.")}" +
                $"\n\n•Family Lifestyle: {currentCharacter.characterBackstory.familyLifestyle}" +
                $"\n•Childhood Home: {currentCharacter.characterBackstory.childhoodHome}" +
                $"\n•Childhood Memories: {currentCharacter.characterBackstory.childhoodMemory}" +
                $"\n•I became a(n) {currentCharacter.characterBackground.GetType().Name} because {currentCharacter.characterBackstory.backgroundReason}" +
                $"\n•I became a(n) {currentCharacter.characterClass.GetType().Name} because {currentCharacter.characterBackstory.classReason}" +
                $"\n\n•Life Events: \n{string.Join("\n\n", currentCharacter.characterBackstory.lifeEvents)}";
            //family members who raised you
        }

        private void PopulateOtherProficiencies()
        {
            proficienciesLanguagesTextBox.Text =
                $"•Languages:\n{string.Join("\n", currentCharacter.languageProficiencies.Select(x => x))}" +
                $"\n\n•Tools:\n{string.Join("\n", currentCharacter.toolProficiencies.Select(x => x))}";
        }

        private void PopulateEquipment()
        {
            foreach (var item in currentCharacter.equipment)
            {
                equipmentListView.Items.Add(new ListViewItem(new[] { item }));
            }
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            if (currentCharacter.characterClass == null)
                rollMainInfo();

            PopulateStatBoxes();
            PopulateSkillProficiencies();
            PopulateDefensive();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            SoundPlayer diceSound = new SoundPlayer(Properties.Resources.MANYDICE);
            diceSound.Play();

            if (currentCharacter.characterClass == null)
                rollMainInfo();

            PopulatePersonality();

            PopulateStatBoxes();
            PopulateSkillProficiencies();
            PopulateDefensive();
            PopulateSavingThrows();
        }

        private void characterNameTextBox_TextChanged(object sender, EventArgs e)
        {
            currentCharacter.name = characterNameTextBox.Text;
            HideCaret(characterNameTextBox.Handle);
        }

        private void rollMainInfoButton_Click(object sender, EventArgs e)
        {
            rollMainInfo();
            PopulatePersonality();
        }

        private void rollMainInfo()
        {
            ClearLists();

            currentCharacter = new Character();
            currentCharacter.generateBasicInfo();

            characterNameTextBox.Text = currentCharacter.name;
            classLevelTextBox.Text = $"{currentCharacter.characterClassSubtype}{(currentCharacter.characterClassSubtype != null ? " " : "")}{currentCharacter.characterClass.GetType().Name} {currentCharacter.level.ToString()}";
            alignmentTextBox.Text = currentCharacter.alignment;
            backgroundTextBox.Text = currentCharacter.background;
            raceTextBox.Text = currentCharacter.race;

            PopulateStatBoxes();
            PopulateSkillProficiencies();
            PopulateDefensive();
            PopulateSavingThrows();
            PopulateBackstory();
            PopulateFeatures();
            PopulateOtherProficiencies();
            PopulateEquipment();
        }

        private void PopulatePersonality()
        {
            personalityTraitsTextBox.Text = currentCharacter.personalityTrait;
            idealsTextBox.Text = currentCharacter.ideal;
            bondsTextBox.Text = currentCharacter.bond;
            flawsTextBox.Text = currentCharacter.flaw;
        }

        private void PopulateDefensive()
        {
            initiativeTextBox.Text = currentCharacter.dexterityModifier.ToString();
            speedTextBox.Text = currentCharacter.movementSpeed.ToString();
            currentHitPointsTextBox.Text = currentCharacter.hitPoints.ToString();
            hitPointMaximumTextBox.Text = currentCharacter.hitPoints.ToString();
            totalHitDiceTextBox.Text = 1.ToString();
            hitDiceTextBox.Text = currentCharacter.hitDie.ToString();
        }

        private void PopulateFeatures()
        {
            currentCharacter.classFeatures.ToList().ForEach(x => currentCharacter.features.Add(x.Key, x.Value));
            currentCharacter.raceFeatures.ToList().ForEach(x => currentCharacter.features.Add(x.Key, x.Value));
            currentCharacter.specialFeatures.ToList().ForEach(x => currentCharacter.features.Add(x.Key, x.Value));
            currentCharacter.backgroundFeatures.ToList().ForEach(x => currentCharacter.features.Add(x.Key, x.Value));

            foreach (var item in currentCharacter.features)
            {
                featuresTraitsTextBox.Text += string.Join(Environment.NewLine, $"{item.Key}\n{ item.Value }\n\n");
            }
        }

        private void ClearLists()
        {
            equipmentListView.Clear();
            equipmentListView.Items.Clear();

            featuresTraitsTextBox.Text = "";
        }

        private void skillsLabel_Click(object sender, EventArgs e)
        {
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            OptionsForm options = new OptionsForm();
            options.Show();
        }
    }
}