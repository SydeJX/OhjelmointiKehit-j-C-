using System.Drawing;
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
            this.components = new System.ComponentModel.Container();
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
            this.ButtonChange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CorrectPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AlphaText = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.LabelLastname.ForeColor = System.Drawing.Color.Black;
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
            this.InsertButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DataGirdView
            // 
            this.DataGirdView.BackgroundColor = System.Drawing.Color.Black;
            this.DataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DataGirdView, "DataGirdView");
            this.DataGirdView.Name = "DataGirdView";
            this.DataGirdView.RowTemplate.Height = 24;
            this.DataGirdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGirdView_CellContentClick);
            // 
            // ButtonChange
            // 
            resources.ApplyResources(this.ButtonChange, "ButtonChange");
            this.ButtonChange.BackColor = System.Drawing.Color.Black;
            this.ButtonChange.CausesValidation = false;
            this.ButtonChange.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonChange.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonChange.ForeColor = System.Drawing.Color.SpringGreen;
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.UseVisualStyleBackColor = false;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CorrectPicture);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CorrectPicture
            // 
            this.CorrectPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.CorrectPicture, "CorrectPicture");
            this.CorrectPicture.Name = "CorrectPicture";
            this.CorrectPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MinimizeButton
            // 
            resources.ApplyResources(this.MinimizeButton, "MinimizeButton");
            this.MinimizeButton.BackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AlphaText
            // 
            resources.ApplyResources(this.AlphaText, "AlphaText");
            this.AlphaText.BackColor = System.Drawing.Color.Transparent;
            this.AlphaText.Name = "AlphaText";
            // 
            // CurrentLabel
            // 
            resources.ApplyResources(this.CurrentLabel, "CurrentLabel");
            this.CurrentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentLabel.Name = "CurrentLabel";
            // 
            // EditButton
            // 
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.BackColor = System.Drawing.Color.Black;
            this.EditButton.CausesValidation = false;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EditButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.EditButton.Name = "EditButton";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.BackColor = System.Drawing.Color.Black;
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DeleteButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.AlphaText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonChange);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CorrectPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AlphaText;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.PictureBox CorrectPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

