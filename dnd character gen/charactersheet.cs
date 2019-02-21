﻿using System;
using System.Windows.Forms;

namespace dnd_character_gen
{
    public partial class CharacterSheet : Form
    {
        private Character currentCharacter = new Character();

        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            /*xpTextBox.Text = currentCharacter.xp.ToString();
            proficiencyTextBox.Text = currentCharacter.proficiencyBonus.ToString();*/
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PopulateStatBoxes()
        {
            /*currentCharacter.generateStatArray();
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
            charismaModifierTextBox.Text = currentCharacter.charismaModifier.ToString();*/
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            PopulateStatBoxes();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //SoundPlayer diceSound = new SoundPlayer(@"C:\Users\sorre\source\repos\dnd character gen\dnd character gen\Assets\MANYDICE.WAV");
            //diceSound.Play();

            PopulateStatBoxes();
        }

        /*[DllImport("user32.dll")]
        private static bool HideCaret(IntPtr hWnd);*/

        private void characterNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //currentCharacter.name = characterNameTextBox.Text;
            //HideCaret(characterNameTextBox.Handle);
        }

        private void rollMainInfoButton_Click(object sender, EventArgs e)
        {
            currentCharacter.generateBasicInfo();
            classLevelTextBox.Text = currentCharacter.characterClass.GetType().Name + " " + currentCharacter.level.ToString();
            alignmentTextBox.Text = currentCharacter.alignment;
            backgroundTextBox.Text = currentCharacter.background;
            raceTextBox.Text = currentCharacter.race;
            //TODO randomize all these things
        }
    }
}