namespace dnd_character_gen.Forms {
    partial class OptionsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.optionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // optionsCheckedListBox
            // 
            this.optionsCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.optionsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsCheckedListBox.FormattingEnabled = true;
            this.optionsCheckedListBox.Items.AddRange(new object[] {
            "Optimize Selections"});
            this.optionsCheckedListBox.Location = new System.Drawing.Point(80, 61);
            this.optionsCheckedListBox.Name = "optionsCheckedListBox";
            this.optionsCheckedListBox.Size = new System.Drawing.Size(154, 85);
            this.optionsCheckedListBox.TabIndex = 0;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 310);
            this.Controls.Add(this.optionsCheckedListBox);
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "OptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox optionsCheckedListBox;
    }
}