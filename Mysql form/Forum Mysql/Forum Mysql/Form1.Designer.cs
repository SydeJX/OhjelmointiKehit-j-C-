﻿using System.Drawing;
using System.Windows;
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
            this.ButtonShut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            resources.ApplyResources(this.labelID, "labelID");
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Name = "labelID";
            // 
            // TextID
            // 
            this.TextID.BackColor = System.Drawing.Color.Black;
            this.TextID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextID.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.TextID, "TextID");
            this.TextID.Name = "TextID";
            // 
            // LabelName
            // 
            resources.ApplyResources(this.LabelName, "LabelName");
            this.LabelName.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Name = "LabelName";
            // 
            // FirstNText
            // 
            this.FirstNText.BackColor = System.Drawing.Color.Black;
            this.FirstNText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstNText.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.FirstNText, "FirstNText");
            this.FirstNText.Name = "FirstNText";
            // 
            // LabelLastname
            // 
            resources.ApplyResources(this.LabelLastname, "LabelLastname");
            this.LabelLastname.BackColor = System.Drawing.Color.Transparent;
            this.LabelLastname.Name = "LabelLastname";
            // 
            // LastnameText
            // 
            this.LastnameText.BackColor = System.Drawing.Color.Black;
            this.LastnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastnameText.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LastnameText, "LastnameText");
            this.LastnameText.Name = "LastnameText";
            // 
            // OldYText
            // 
            this.OldYText.BackColor = System.Drawing.Color.Black;
            this.OldYText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OldYText.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.OldYText, "OldYText");
            this.OldYText.Name = "OldYText";
            // 
            // Labelyearold
            // 
            resources.ApplyResources(this.Labelyearold, "Labelyearold");
            this.Labelyearold.BackColor = System.Drawing.Color.Transparent;
            this.Labelyearold.Name = "Labelyearold";
            // 
            // EmailText
            // 
            this.EmailText.AcceptsReturn = true;
            this.EmailText.BackColor = System.Drawing.Color.Black;
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailText.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.EmailText, "EmailText");
            this.EmailText.Name = "EmailText";
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Name = "labelEmail";
            // 
            // PhoneText
            // 
            this.PhoneText.AcceptsReturn = true;
            this.PhoneText.BackColor = System.Drawing.Color.Black;
            this.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneText.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PhoneText, "PhoneText");
            this.PhoneText.Name = "PhoneText";
            // 
            // labelPhone
            // 
            resources.ApplyResources(this.labelPhone, "labelPhone");
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Name = "labelPhone";
            // 
            // StudentText
            // 
            this.StudentText.BackColor = System.Drawing.Color.Black;
            this.StudentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentText.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.StudentText, "StudentText");
            this.StudentText.Name = "StudentText";
            // 
            // labelStudent
            // 
            resources.ApplyResources(this.labelStudent, "labelStudent");
            this.labelStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelStudent.Name = "labelStudent";
            // 
            // InsertButton
            // 
            resources.ApplyResources(this.InsertButton, "InsertButton");
            this.InsertButton.BackColor = System.Drawing.Color.Black;
            this.InsertButton.CausesValidation = false;
            this.InsertButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InsertButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InsertButton.ForeColor = System.Drawing.Color.Teal;
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.UseVisualStyleBackColor = false;
            // 
            // DataGirdView
            // 
            this.DataGirdView.BackgroundColor = System.Drawing.Color.Black;
            this.DataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DataGirdView, "DataGirdView");
            this.DataGirdView.Name = "DataGirdView";
            this.DataGirdView.RowTemplate.Height = 24;
            // 
            // ButtonShut
            // 
            resources.ApplyResources(this.ButtonShut, "ButtonShut");
            this.ButtonShut.BackColor = System.Drawing.Color.Black;
            this.ButtonShut.CausesValidation = false;
            this.ButtonShut.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonShut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonShut.ForeColor = System.Drawing.Color.Teal;
            this.ButtonShut.Name = "ButtonShut";
            this.ButtonShut.UseVisualStyleBackColor = false;
            this.ButtonShut.Click += new System.EventHandler(this.ButtonShut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonShut);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button ButtonShut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

