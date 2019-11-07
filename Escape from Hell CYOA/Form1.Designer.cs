namespace Escape_from_Hell_CYOA
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Label();
            this.rightButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputLabel.Location = new System.Drawing.Point(12, 233);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(776, 166);
            this.outputLabel.TabIndex = 0;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(30, 410);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(100, 40);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "LEFT ";
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(503, 410);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(100, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "RIGHT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label leftButton;
        private System.Windows.Forms.Label rightButton;
    }
}

