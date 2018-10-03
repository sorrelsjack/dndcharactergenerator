using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd_character_gen {
    public partial class charactersheet : Form {
        character currentCharacter = new character();
        public charactersheet() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void characterNameLabel_Click(object sender, EventArgs e) {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void charactersheet_Load(object sender, EventArgs e) {
            xpTextBox.Text = currentCharacter.xp.ToString();
            proficiencyTextBox.Text = currentCharacter.proficiencyBonus.ToString();
            playerNameTextBox.Text = currentCharacter.playerName.ToString();
        }

        private void statsButton_Click(object sender, EventArgs e) {
            currentCharacter.generateStatArray();
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
        }

        private void wisdomSavingThrowLabel_Click(object sender, EventArgs e) {

        }

        private void rollButton_Click(object sender, EventArgs e) {
            SoundPlayer diceSound = new SoundPlayer(@"C:\Users\sorre\source\repos\dnd character gen\dnd character gen\MANYDICE.WAV");
            diceSound.Play();

            currentCharacter.generateStatArray();

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
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void characterNameTextBox_TextChanged(object sender, EventArgs e) {
            currentCharacter.name = characterNameTextBox.Text;
            HideCaret(characterNameTextBox.Handle);
        }

        private void rollMainInfoButton_Click(object sender, EventArgs e) {
            currentCharacter.generateBasicInfo();
            classLevelTextBox.Text = currentCharacter.adventureClass + " " + currentCharacter.level.ToString();
            alignmentTextBox.Text = currentCharacter.alignment;
            //TODO randomize all these things
        }
    }
}
