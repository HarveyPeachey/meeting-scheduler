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
            this.TimesAvailable = new System.Windows.Forms.ListBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.AdminBox.SuspendLayout();
            this.DateChosen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(18, 46);
            this.Calendar1.MaxSelectionCount = 1;
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 0;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateChanged);
            // 
            // NotificationBox
            // 
            this.NotificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationBox.Location = new System.Drawing.Point(490, 12);
            this.NotificationBox.Name = "NotificationBox";
            this.NotificationBox.Size = new System.Drawing.Size(373, 315);
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
            this.AdminBox.Location = new System.Drawing.Point(490, 373);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(373, 373);
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
            this.AdminBox.ResumeLayout(false);
            this.DateChosen.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox TimesAvailable;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

