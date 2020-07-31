namespace Opdracht6LettertypeChaos
{
    partial class Form1
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
            this.RichTextBoxToShuffle = new System.Windows.Forms.RichTextBox();
            this.ButtonShuffleFont = new System.Windows.Forms.Button();
            this.RichTextBoxShuffleResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RichTextBoxToShuffle
            // 
            this.RichTextBoxToShuffle.Location = new System.Drawing.Point(12, 12);
            this.RichTextBoxToShuffle.Name = "RichTextBoxToShuffle";
            this.RichTextBoxToShuffle.Size = new System.Drawing.Size(334, 426);
            this.RichTextBoxToShuffle.TabIndex = 0;
            this.RichTextBoxToShuffle.Text = "";
            // 
            // ButtonShuffleFont
            // 
            this.ButtonShuffleFont.Location = new System.Drawing.Point(352, 12);
            this.ButtonShuffleFont.Name = "ButtonShuffleFont";
            this.ButtonShuffleFont.Size = new System.Drawing.Size(96, 23);
            this.ButtonShuffleFont.TabIndex = 1;
            this.ButtonShuffleFont.Text = "Shuffle Font";
            this.ButtonShuffleFont.UseVisualStyleBackColor = true;
            this.ButtonShuffleFont.Click += new System.EventHandler(this.ButtonShuffleFont_Click);
            // 
            // RichTextBoxShuffleResult
            // 
            this.RichTextBoxShuffleResult.Location = new System.Drawing.Point(454, 12);
            this.RichTextBoxShuffleResult.Name = "RichTextBoxShuffleResult";
            this.RichTextBoxShuffleResult.Size = new System.Drawing.Size(334, 426);
            this.RichTextBoxShuffleResult.TabIndex = 2;
            this.RichTextBoxShuffleResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBoxShuffleResult);
            this.Controls.Add(this.ButtonShuffleFont);
            this.Controls.Add(this.RichTextBoxToShuffle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBoxToShuffle;
        private System.Windows.Forms.Button ButtonShuffleFont;
        private System.Windows.Forms.RichTextBox RichTextBoxShuffleResult;
    }
}

