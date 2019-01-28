namespace meetingSchedular
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
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.NotificationBox = new System.Windows.Forms.GroupBox();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.UserStory3 = new System.Windows.Forms.Button();
            this.UserStory2 = new System.Windows.Forms.Button();
            this.UserStory1 = new System.Windows.Forms.Button();
            this.DateChosen = new System.Windows.Forms.GroupBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StrtTimeDrp = new System.Windows.Forms.ComboBox();
            this.EndTimeDrp = new System.Windows.Forms.ComboBox();
            this.RoomDrp = new System.Windows.Forms.ComboBox();
            this.StrtTmeLbl = new System.Windows.Forms.Label();
            this.EndTmeLbl = new System.Windows.Forms.Label();
            this.RoomLbl = new System.Windows.Forms.Label();
            this.EditPrefBtn = new System.Windows.Forms.Button();
            this.EditExcBtn = new System.Windows.Forms.Button();
            this.NtfyAccpt = new System.Windows.Forms.Button();
            this.NtfyDcln = new System.Windows.Forms.Button();
            this.NotificationBox.SuspendLayout();
            this.AdminBox.SuspendLayout();
            this.DateChosen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(12, 43);
            this.Calendar1.MaxSelectionCount = 1;
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 0;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateChanged);
            // 
            // NotificationBox
            // 
            this.NotificationBox.Controls.Add(this.NtfyDcln);
            this.NotificationBox.Controls.Add(this.NtfyAccpt);
            this.NotificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationBox.Location = new System.Drawing.Point(672, 24);
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.Size = new System.Drawing.Size(575, 433);
            this.NotificationBox.TabIndex = 2;
            this.NotificationBox.TabStop = false;
            this.NotificationBox.Text = "Notifications";
            // 
            // AdminBox
            // 
            this.AdminBox.Controls.Add(this.UserStory3);
            this.AdminBox.Controls.Add(this.UserStory2);
            this.AdminBox.Controls.Add(this.UserStory1);
            this.AdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBox.Location = new System.Drawing.Point(874, 476);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(373, 359);
            this.AdminBox.TabIndex = 3;
            this.AdminBox.TabStop = false;
            this.AdminBox.Text = "AdminBox";
            // 
            // UserStory3
            // 
            this.UserStory3.Location = new System.Drawing.Point(6, 176);
            this.UserStory3.Name = "UserStory3";
            this.UserStory3.Size = new System.Drawing.Size(361, 53);
            this.UserStory3.TabIndex = 2;
            this.UserStory3.Text = "User Story 3";
            this.UserStory3.UseVisualStyleBackColor = true;
            // 
            // UserStory2
            // 
            this.UserStory2.Location = new System.Drawing.Point(6, 117);
            this.UserStory2.Name = "UserStory2";
            this.UserStory2.Size = new System.Drawing.Size(360, 53);
            this.UserStory2.TabIndex = 1;
            this.UserStory2.Text = "User Story 2";
            this.UserStory2.UseVisualStyleBackColor = true;
            // 
            // UserStory1
            // 
            this.UserStory1.Location = new System.Drawing.Point(6, 63);
            this.UserStory1.Name = "UserStory1";
            this.UserStory1.Size = new System.Drawing.Size(361, 48);
            this.UserStory1.TabIndex = 0;
            this.UserStory1.Text = "User Story 1";
            this.UserStory1.UseVisualStyleBackColor = true;
            // 
            // DateChosen
            // 
            this.DateChosen.Controls.Add(this.EditExcBtn);
            this.DateChosen.Controls.Add(this.EditPrefBtn);
            this.DateChosen.Controls.Add(this.RoomLbl);
            this.DateChosen.Controls.Add(this.EndTmeLbl);
            this.DateChosen.Controls.Add(this.Calendar1);
            this.DateChosen.Controls.Add(this.StrtTmeLbl);
            this.DateChosen.Controls.Add(this.RoomDrp);
            this.DateChosen.Controls.Add(this.EndTimeDrp);
            this.DateChosen.Controls.Add(this.StrtTimeDrp);
            this.DateChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateChosen.Location = new System.Drawing.Point(12, 52);
            this.DateChosen.Name = "DateChosen";
            this.DateChosen.Size = new System.Drawing.Size(575, 783);
            this.DateChosen.TabIndex = 3;
            this.DateChosen.TabStop = false;
            this.DateChosen.Text = "DateChosen";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(70, 25);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "label1";
            // 
            // StrtTimeDrp
            // 
            this.StrtTimeDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StrtTimeDrp.FormattingEnabled = true;
            this.StrtTimeDrp.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.StrtTimeDrp.Location = new System.Drawing.Point(29, 424);
            this.StrtTimeDrp.Name = "StrtTimeDrp";
            this.StrtTimeDrp.Size = new System.Drawing.Size(212, 39);
            this.StrtTimeDrp.TabIndex = 0;
            this.StrtTimeDrp.SelectedIndexChanged += new System.EventHandler(this.StrtTimeDrp_SelectedIndexChanged);
            // 
            // EndTimeDrp
            // 
            this.EndTimeDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndTimeDrp.FormattingEnabled = true;
            this.EndTimeDrp.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.EndTimeDrp.Location = new System.Drawing.Point(291, 424);
            this.EndTimeDrp.Name = "EndTimeDrp";
            this.EndTimeDrp.Size = new System.Drawing.Size(212, 39);
            this.EndTimeDrp.TabIndex = 1;
            // 
            // RoomDrp
            // 
            this.RoomDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomDrp.FormattingEnabled = true;
            this.RoomDrp.Items.AddRange(new object[] {
            "Cantor",
            "Stoddart",
            "Owen",
            "Howard"});
            this.RoomDrp.Location = new System.Drawing.Point(29, 544);
            this.RoomDrp.Name = "RoomDrp";
            this.RoomDrp.Size = new System.Drawing.Size(212, 39);
            this.RoomDrp.TabIndex = 2;
            // 
            // StrtTmeLbl
            // 
            this.StrtTmeLbl.AutoSize = true;
            this.StrtTmeLbl.Location = new System.Drawing.Point(23, 390);
            this.StrtTmeLbl.Name = "StrtTmeLbl";
            this.StrtTmeLbl.Size = new System.Drawing.Size(139, 31);
            this.StrtTmeLbl.TabIndex = 3;
            this.StrtTmeLbl.Text = "Start Time";
            // 
            // EndTmeLbl
            // 
            this.EndTmeLbl.AutoSize = true;
            this.EndTmeLbl.Location = new System.Drawing.Point(285, 390);
            this.EndTmeLbl.Name = "EndTmeLbl";
            this.EndTmeLbl.Size = new System.Drawing.Size(129, 31);
            this.EndTmeLbl.TabIndex = 4;
            this.EndTmeLbl.Text = "End Time";
            // 
            // RoomLbl
            // 
            this.RoomLbl.AutoSize = true;
            this.RoomLbl.Location = new System.Drawing.Point(23, 510);
            this.RoomLbl.Name = "RoomLbl";
            this.RoomLbl.Size = new System.Drawing.Size(86, 31);
            this.RoomLbl.TabIndex = 5;
            this.RoomLbl.Text = "Room";
            // 
            // EditPrefBtn
            // 
            this.EditPrefBtn.Location = new System.Drawing.Point(16, 702);
            this.EditPrefBtn.Name = "EditPrefBtn";
            this.EditPrefBtn.Size = new System.Drawing.Size(239, 52);
            this.EditPrefBtn.TabIndex = 6;
            this.EditPrefBtn.Text = "Edit Preferences";
            this.EditPrefBtn.UseVisualStyleBackColor = true;
            // 
            // EditExcBtn
            // 
            this.EditExcBtn.Location = new System.Drawing.Point(324, 705);
            this.EditExcBtn.Name = "EditExcBtn";
            this.EditExcBtn.Size = new System.Drawing.Size(228, 47);
            this.EditExcBtn.TabIndex = 7;
            this.EditExcBtn.Text = "Edit Exclusions";
            this.EditExcBtn.UseVisualStyleBackColor = true;
            // 
            // NtfyAccpt
            // 
            this.NtfyAccpt.Location = new System.Drawing.Point(118, 339);
            this.NtfyAccpt.Name = "NtfyAccpt";
            this.NtfyAccpt.Size = new System.Drawing.Size(127, 59);
            this.NtfyAccpt.TabIndex = 0;
            this.NtfyAccpt.Text = "Accept";
            this.NtfyAccpt.UseVisualStyleBackColor = true;
            // 
            // NtfyDcln
            // 
            this.NtfyDcln.Location = new System.Drawing.Point(332, 339);
            this.NtfyDcln.Name = "NtfyDcln";
            this.NtfyDcln.Size = new System.Drawing.Size(126, 59);
            this.NtfyDcln.TabIndex = 1;
            this.NtfyDcln.Text = "Decline";
            this.NtfyDcln.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1276, 848);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.DateChosen);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.NotificationBox);
            this.Name = "Form1";
            this.Text = "Meeting Scheduler";
            this.NotificationBox.ResumeLayout(false);
            this.AdminBox.ResumeLayout(false);
            this.DateChosen.ResumeLayout(false);
            this.DateChosen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.GroupBox NotificationBox;
        private System.Windows.Forms.GroupBox AdminBox;
        private System.Windows.Forms.Button UserStory3;
        private System.Windows.Forms.Button UserStory2;
        private System.Windows.Forms.Button UserStory1;
        private System.Windows.Forms.GroupBox DateChosen;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button NtfyDcln;
        private System.Windows.Forms.Button NtfyAccpt;
        private System.Windows.Forms.Button EditExcBtn;
        private System.Windows.Forms.Button EditPrefBtn;
        private System.Windows.Forms.Label RoomLbl;
        private System.Windows.Forms.Label EndTmeLbl;
        private System.Windows.Forms.Label StrtTmeLbl;
        private System.Windows.Forms.ComboBox RoomDrp;
        private System.Windows.Forms.ComboBox EndTimeDrp;
        private System.Windows.Forms.ComboBox StrtTimeDrp;
    }
}

