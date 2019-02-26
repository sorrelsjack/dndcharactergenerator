﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace dnd_character_gen
{
    public partial class CharacterSheet : Form
    {
        private Character currentCharacter = new Character();

        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            equipmentListView.View = View.List;
            equipmentListView.GridLines = true;

            xpTextBox.Text = currentCharacter.xp.ToString();
            proficiencyTextBox.Text = currentCharacter.proficiencyBonus.ToString();
        }

        private void PopulateStatBoxes()
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

        private void PopulateSavingThrows()
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
        }

        private void PopulateOtherProficiencies()
        {
            List<string> proficienciesLanguagesList = new List<string>();
            proficienciesLanguagesList.AddRange(currentCharacter.toolProficiencies);
            proficienciesLanguagesList.AddRange(currentCharacter.languageProficiencies);

            proficienciesLanguagesTextBox.Text = String.Join(Environment.NewLine, proficienciesLanguagesList);
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
            PopulateDefensive();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //SoundPlayer diceSound = new SoundPlayer(@"C:\Users\sorre\source\repos\dnd character gen\dnd character gen\Assets\MANYDICE.WAV");
            //diceSound.Play();

            if (currentCharacter.characterClass == null)
                rollMainInfo();

            PopulatePersonality();

            PopulateStatBoxes();
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
            equipmentListView.Clear();
            equipmentListView.Items.Clear();

            currentCharacter = new Character();

            currentCharacter.generateBasicInfo();

            characterNameTextBox.Text = currentCharacter.name;
            classLevelTextBox.Text = $"{currentCharacter.characterClassSubtype}{(currentCharacter.characterClassSubtype != null ? " " : "")}{currentCharacter.characterClass.GetType().Name} {currentCharacter.level.ToString()}";
            alignmentTextBox.Text = currentCharacter.alignment;
            backgroundTextBox.Text = currentCharacter.background;
            raceTextBox.Text = currentCharacter.race;

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
            //TODO: Possibly AC, but that requires A LOT of effort
            initiativeTextBox.Text = currentCharacter.dexterityModifier.ToString();
            speedTextBox.Text = currentCharacter.movementSpeed.ToString();
            currentHitPointsTextBox.Text = currentCharacter.hitPoints.ToString();
            hitPointMaximumTextBox.Text = currentCharacter.hitPoints.ToString();
            totalHitDiceTextBox.Text = 1.ToString();
            hitDiceTextBox.Text = currentCharacter.hitDie.ToString();
        }
    }
}