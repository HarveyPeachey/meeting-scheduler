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
<<<<<<< HEAD
            this.DateSelector = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.EndTimeDrp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.strtTimeDrp = new System.Windows.Forms.ComboBox();
            this.editPrefBtn = new System.Windows.Forms.Button();
            this.EditExcBtn = new System.Windows.Forms.Button();
=======
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
            this.NotificationBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.UserStory3 = new System.Windows.Forms.Button();
            this.UserStory2 = new System.Windows.Forms.Button();
            this.UserStory1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.DateSelector.SuspendLayout();
            this.NotificationBox.SuspendLayout();
=======
            this.DateChosen = new System.Windows.Forms.GroupBox();
            this.TimesAvailable = new System.Windows.Forms.ListBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
            this.AdminBox.SuspendLayout();
            this.DateChosen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar1
            // 
<<<<<<< HEAD
            this.Calendar1.Location = new System.Drawing.Point(18, 57);
=======
            this.Calendar1.Location = new System.Drawing.Point(18, 46);
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
            this.Calendar1.MaxSelectionCount = 1;
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 0;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateChanged);
            // 
<<<<<<< HEAD
            // DateSelector
            // 
            this.DateSelector.Controls.Add(this.label3);
            this.DateSelector.Controls.Add(this.comboBox3);
            this.DateSelector.Controls.Add(this.Calendar1);
            this.DateSelector.Controls.Add(this.EndTimeDrp);
            this.DateSelector.Controls.Add(this.label2);
            this.DateSelector.Controls.Add(this.label1);
            this.DateSelector.Controls.Add(this.strtTimeDrp);
            this.DateSelector.Controls.Add(this.editPrefBtn);
            this.DateSelector.Controls.Add(this.EditExcBtn);
            this.DateSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSelector.Location = new System.Drawing.Point(12, 29);
            this.DateSelector.Name = "DateSelector";
            this.DateSelector.Size = new System.Drawing.Size(356, 683);
            this.DateSelector.TabIndex = 1;
            this.DateSelector.TabStop = false;
            this.DateSelector.Text = "Date Selected";
            this.DateSelector.Enter += new System.EventHandler(this.DateSelector_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Cantor",
            "Owen",
            "Howard"});
            this.comboBox3.Location = new System.Drawing.Point(15, 565);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(139, 37);
            this.comboBox3.TabIndex = 6;
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
            this.EndTimeDrp.Location = new System.Drawing.Point(198, 492);
            this.EndTimeDrp.Name = "EndTimeDrp";
            this.EndTimeDrp.Size = new System.Drawing.Size(140, 37);
            this.EndTimeDrp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Time";
            // 
            // strtTimeDrp
            // 
            this.strtTimeDrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.strtTimeDrp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strtTimeDrp.FormattingEnabled = true;
            this.strtTimeDrp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.strtTimeDrp.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00"});
            this.strtTimeDrp.Location = new System.Drawing.Point(15, 491);
            this.strtTimeDrp.Name = "strtTimeDrp";
            this.strtTimeDrp.Size = new System.Drawing.Size(139, 38);
            this.strtTimeDrp.TabIndex = 2;
            this.strtTimeDrp.SelectedIndexChanged += new System.EventHandler(this.strtTimeDrp_SelectedIndexChanged);
            // 
            // editPrefBtn
            // 
            this.editPrefBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPrefBtn.Location = new System.Drawing.Point(15, 631);
            this.editPrefBtn.Name = "editPrefBtn";
            this.editPrefBtn.Size = new System.Drawing.Size(139, 45);
            this.editPrefBtn.TabIndex = 1;
            this.editPrefBtn.Text = "Edit Preferences";
            this.editPrefBtn.UseVisualStyleBackColor = true;
            // 
            // EditExcBtn
            // 
            this.EditExcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditExcBtn.Location = new System.Drawing.Point(198, 631);
            this.EditExcBtn.Name = "EditExcBtn";
            this.EditExcBtn.Size = new System.Drawing.Size(140, 45);
            this.EditExcBtn.TabIndex = 0;
            this.EditExcBtn.Text = "Edit Exclusions";
            this.EditExcBtn.UseVisualStyleBackColor = true;
            // 
            // NotificationBox
            // 
            this.NotificationBox.Controls.Add(this.button2);
            this.NotificationBox.Controls.Add(this.button1);
            this.NotificationBox.Location = new System.Drawing.Point(438, 12);
=======
            // NotificationBox
            // 
            this.NotificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationBox.Location = new System.Drawing.Point(490, 12);
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.Size = new System.Drawing.Size(373, 315);
            this.NotificationBox.TabIndex = 2;
            this.NotificationBox.TabStop = false;
            this.NotificationBox.Text = "Notifications";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Decline";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminBox
            // 
            this.AdminBox.Controls.Add(this.UserStory3);
            this.AdminBox.Controls.Add(this.UserStory2);
            this.AdminBox.Controls.Add(this.UserStory1);
<<<<<<< HEAD
            this.AdminBox.Location = new System.Drawing.Point(438, 507);
=======
            this.AdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBox.Location = new System.Drawing.Point(490, 373);
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(373, 205);
            this.AdminBox.TabIndex = 3;
            this.AdminBox.TabStop = false;
            this.AdminBox.Text = "AdminBox";
            // 
            // UserStory3
            // 
            this.UserStory3.Location = new System.Drawing.Point(7, 147);
            this.UserStory3.Name = "UserStory3";
            this.UserStory3.Size = new System.Drawing.Size(361, 53);
            this.UserStory3.TabIndex = 2;
            this.UserStory3.Text = "User Story 3";
            this.UserStory3.UseVisualStyleBackColor = true;
            // 
            // UserStory2
            // 
            this.UserStory2.Location = new System.Drawing.Point(7, 88);
            this.UserStory2.Name = "UserStory2";
            this.UserStory2.Size = new System.Drawing.Size(360, 53);
            this.UserStory2.TabIndex = 1;
            this.UserStory2.Text = "User Story 2";
            this.UserStory2.UseVisualStyleBackColor = true;
            // 
            // UserStory1
            // 
            this.UserStory1.Location = new System.Drawing.Point(7, 34);
            this.UserStory1.Name = "UserStory1";
            this.UserStory1.Size = new System.Drawing.Size(361, 48);
            this.UserStory1.TabIndex = 0;
            this.UserStory1.Text = "User Story 1";
            this.UserStory1.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(821, 731);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.NotificationBox);
            this.Controls.Add(this.DateSelector);
            this.Name = "Form1";
            this.DateSelector.ResumeLayout(false);
            this.DateSelector.PerformLayout();
            this.NotificationBox.ResumeLayout(false);
=======
            // DateChosen
            // 
            this.DateChosen.Controls.Add(this.TimesAvailable);
            this.DateChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateChosen.Location = new System.Drawing.Point(12, 373);
            this.DateChosen.Name = "DateChosen";
            this.DateChosen.Size = new System.Drawing.Size(402, 373);
            this.DateChosen.TabIndex = 3;
            this.DateChosen.TabStop = false;
            this.DateChosen.Text = "DateChosen";
            // 
            // TimesAvailable
            // 
            this.TimesAvailable.FormattingEnabled = true;
            this.TimesAvailable.ItemHeight = 31;
            this.TimesAvailable.Location = new System.Drawing.Point(3, 34);
            this.TimesAvailable.Name = "TimesAvailable";
            this.TimesAvailable.Size = new System.Drawing.Size(393, 314);
            this.TimesAvailable.TabIndex = 0;
            this.TimesAvailable.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(875, 758);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.DateChosen);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.NotificationBox);
            this.Controls.Add(this.Calendar1);
            this.Name = "Form1";
            this.Text = "Meeting Scheduler";
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
            this.AdminBox.ResumeLayout(false);
            this.DateChosen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.MonthCalendar Calendar1;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox DateSelector;
        private System.Windows.Forms.Button EditExcBtn;
=======
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
        private System.Windows.Forms.GroupBox NotificationBox;
        private System.Windows.Forms.GroupBox AdminBox;
        private System.Windows.Forms.Button UserStory3;
        private System.Windows.Forms.Button UserStory2;
        private System.Windows.Forms.Button UserStory1;
<<<<<<< HEAD
        private System.Windows.Forms.Button editPrefBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox strtTimeDrp;
        private System.Windows.Forms.ComboBox EndTimeDrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
=======
        private System.Windows.Forms.GroupBox DateChosen;
        private System.Windows.Forms.ListBox TimesAvailable;
        private System.Windows.Forms.Label WelcomeLabel;
>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
    }
}

