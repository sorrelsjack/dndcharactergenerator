namespace dnd_character_gen
{
    partial class ConsoleLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleLogTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // consoleLogTextBox
            // 
            this.consoleLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleLogTextBox.Location = new System.Drawing.Point(-2, 0);
            this.consoleLogTextBox.Name = "consoleLogTextBox";
            this.consoleLogTextBox.Size = new System.Drawing.Size(415, 387);
            this.consoleLogTextBox.TabIndex = 0;
            this.consoleLogTextBox.Text = "";
            // 
            // ConsoleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 387);
            this.Controls.Add(this.consoleLogTextBox);
            this.Name = "ConsoleLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsoleLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleLogTextBox;
    }
}