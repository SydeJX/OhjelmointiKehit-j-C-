﻿
namespace Forum_Mysql
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelID = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.FirstNText = new System.Windows.Forms.TextBox();
            this.LabelLastname = new System.Windows.Forms.Label();
            this.LastnameText = new System.Windows.Forms.TextBox();
            this.OldYText = new System.Windows.Forms.TextBox();
            this.Labelyearold = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.StudentText = new System.Windows.Forms.TextBox();
            this.labelStudent = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DataGirdView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(89, 151);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(40, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // TextID
            // 
            this.TextID.BackColor = System.Drawing.Color.Black;
            this.TextID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextID.ForeColor = System.Drawing.Color.Transparent;
            this.TextID.Location = new System.Drawing.Point(135, 151);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(193, 22);
            this.TextID.TabIndex = 1;
            this.TextID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(15, 103);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(114, 25);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Firstname:";
            // 
            // FirstNText
            // 
            this.FirstNText.BackColor = System.Drawing.Color.Black;
            this.FirstNText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNText.ForeColor = System.Drawing.Color.Transparent;
            this.FirstNText.Location = new System.Drawing.Point(135, 107);
            this.FirstNText.Name = "FirstNText";
            this.FirstNText.Size = new System.Drawing.Size(193, 22);
            this.FirstNText.TabIndex = 3;
            this.FirstNText.TextChanged += new System.EventHandler(this.FirstNText_TextChanged);
            // 
            // LabelLastname
            // 
            this.LabelLastname.AutoSize = true;
            this.LabelLastname.BackColor = System.Drawing.Color.Transparent;
            this.LabelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastname.Location = new System.Drawing.Point(476, 103);
            this.LabelLastname.Name = "LabelLastname";
            this.LabelLastname.Size = new System.Drawing.Size(113, 25);
            this.LabelLastname.TabIndex = 4;
            this.LabelLastname.Text = "Lastname:";
            // 
            // LastnameText
            // 
            this.LastnameText.BackColor = System.Drawing.Color.Black;
            this.LastnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastnameText.ForeColor = System.Drawing.Color.Transparent;
            this.LastnameText.Location = new System.Drawing.Point(595, 107);
            this.LastnameText.Name = "LastnameText";
            this.LastnameText.Size = new System.Drawing.Size(201, 22);
            this.LastnameText.TabIndex = 5;
            this.LastnameText.TextChanged += new System.EventHandler(this.LastnameText_TextChanged);
            // 
            // OldYText
            // 
            this.OldYText.BackColor = System.Drawing.Color.Black;
            this.OldYText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldYText.ForeColor = System.Drawing.Color.Transparent;
            this.OldYText.Location = new System.Drawing.Point(595, 155);
            this.OldYText.Name = "OldYText";
            this.OldYText.Size = new System.Drawing.Size(201, 22);
            this.OldYText.TabIndex = 7;
            this.OldYText.TextChanged += new System.EventHandler(this.OldYText_TextChanged);
            // 
            // Labelyearold
            // 
            this.Labelyearold.AutoSize = true;
            this.Labelyearold.BackColor = System.Drawing.Color.Transparent;
            this.Labelyearold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelyearold.Location = new System.Drawing.Point(474, 151);
            this.Labelyearold.Name = "Labelyearold";
            this.Labelyearold.Size = new System.Drawing.Size(115, 25);
            this.Labelyearold.TabIndex = 6;
            this.Labelyearold.Text = "Years Old:";
            // 
            // EmailText
            // 
            this.EmailText.AcceptsReturn = true;
            this.EmailText.BackColor = System.Drawing.Color.Black;
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailText.ForeColor = System.Drawing.Color.Transparent;
            this.EmailText.Location = new System.Drawing.Point(135, 199);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(193, 22);
            this.EmailText.TabIndex = 9;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(57, 195);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 25);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // PhoneText
            // 
            this.PhoneText.AcceptsReturn = true;
            this.PhoneText.BackColor = System.Drawing.Color.Black;
            this.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneText.ForeColor = System.Drawing.Color.Transparent;
            this.PhoneText.Location = new System.Drawing.Point(595, 203);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(201, 22);
            this.PhoneText.TabIndex = 11;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(434, 200);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(162, 25);
            this.labelPhone.TabIndex = 10;
            this.labelPhone.Text = "Phone Number:";
            // 
            // StudentText
            // 
            this.StudentText.BackColor = System.Drawing.Color.Black;
            this.StudentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentText.ForeColor = System.Drawing.Color.Transparent;
            this.StudentText.Location = new System.Drawing.Point(346, 48);
            this.StudentText.Name = "StudentText";
            this.StudentText.Size = new System.Drawing.Size(193, 22);
            this.StudentText.TabIndex = 13;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudent.Location = new System.Drawing.Point(361, 20);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(168, 25);
            this.labelStudent.TabIndex = 12;
            this.labelStudent.Text = "Student Number";
            // 
            // InsertButton
            // 
            this.InsertButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertButton.BackColor = System.Drawing.Color.Black;
            this.InsertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InsertButton.BackgroundImage")));
            this.InsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InsertButton.CausesValidation = false;
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InsertButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.Color.Teal;
            this.InsertButton.Location = new System.Drawing.Point(244, 253);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(134, 38);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            // 
            // DataGirdView
            // 
            this.DataGirdView.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGirdView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGirdView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGirdView.Location = new System.Drawing.Point(12, 321);
            this.DataGirdView.Name = "DataGirdView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGirdView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGirdView.RowHeadersWidth = 51;
            this.DataGirdView.RowTemplate.Height = 24;
            this.DataGirdView.Size = new System.Drawing.Size(850, 258);
            this.DataGirdView.TabIndex = 15;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 591);
            this.Controls.Add(this.DataGirdView);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.StudentText);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.OldYText);
            this.Controls.Add(this.Labelyearold);
            this.Controls.Add(this.LastnameText);
            this.Controls.Add(this.LabelLastname);
            this.Controls.Add(this.FirstNText);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.labelID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "MySql Form";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox FirstNText;
        private System.Windows.Forms.Label LabelLastname;
        private System.Windows.Forms.TextBox LastnameText;
        private System.Windows.Forms.TextBox OldYText;
        private System.Windows.Forms.Label Labelyearold;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox StudentText;
        public System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.DataGridView DataGirdView;
    }
}

