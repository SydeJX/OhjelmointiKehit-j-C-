namespace Random_tehtävä_form
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
            this.LukuText = new System.Windows.Forms.TextBox();
            this.AnnaLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LukuText
            // 
            this.LukuText.Location = new System.Drawing.Point(175, 12);
            this.LukuText.Name = "LukuText";
            this.LukuText.Size = new System.Drawing.Size(145, 20);
            this.LukuText.TabIndex = 0;
            this.LukuText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LukuText_TextChanged);
            // 
            // AnnaLabel
            // 
            this.AnnaLabel.AutoSize = true;
            this.AnnaLabel.Location = new System.Drawing.Point(24, 15);
            this.AnnaLabel.Name = "AnnaLabel";
            this.AnnaLabel.Size = new System.Drawing.Size(125, 13);
            this.AnnaLabel.TabIndex = 1;
            this.AnnaLabel.Text = "Anna luku (-999 lopetus):";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(43, 56);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.AnswerLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 78);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.AnnaLabel);
            this.Controls.Add(this.LukuText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LukuText;
        private System.Windows.Forms.Label AnnaLabel;
        private System.Windows.Forms.Label AnswerLabel;
    }
}

