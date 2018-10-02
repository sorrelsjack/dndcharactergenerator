using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
    }
}
