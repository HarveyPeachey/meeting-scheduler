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
            this.DateSelector = new System.Windows.Forms.GroupBox();
            this.CreateDateRange = new System.Windows.Forms.Button();
            this.NotificationBox = new System.Windows.Forms.GroupBox();
            this.AdminBox = new System.Windows.Forms.GroupBox();
            this.UserStory3 = new System.Windows.Forms.Button();
            this.UserStory2 = new System.Windows.Forms.Button();
            this.UserStory1 = new System.Windows.Forms.Button();
            this.TestOutput = new System.Windows.Forms.TextBox();
            this.DateSelector.SuspendLayout();
            this.AdminBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(18, 12);
            this.Calendar1.MaxSelectionCount = 1;
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 0;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar1_DateChanged);
            // 
            // DateSelector
            // 
            this.DateSelector.Controls.Add(this.CreateDateRange);
            this.DateSelector.Location = new System.Drawing.Point(18, 397);
            this.DateSelector.Name = "DateSelector";
            this.DateSelector.Size = new System.Drawing.Size(402, 315);
            this.DateSelector.TabIndex = 1;
            this.DateSelector.TabStop = false;
            this.DateSelector.Text = "Date Selected";
            // 
            // CreateDateRange
            // 
            this.CreateDateRange.Location = new System.Drawing.Point(177, 264);
            this.CreateDateRange.Name = "CreateDateRange";
            this.CreateDateRange.Size = new System.Drawing.Size(219, 45);
            this.CreateDateRange.TabIndex = 0;
            this.CreateDateRange.Text = "Create Date Range";
            this.CreateDateRange.UseVisualStyleBackColor = true;
            // 
            // NotificationBox
            // 
            this.NotificationBox.Location = new System.Drawing.Point(432, 12);
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
            this.AdminBox.Location = new System.Drawing.Point(432, 339);
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
            // TestOutput
            // 
            this.TestOutput.Location = new System.Drawing.Point(18, 339);
            this.TestOutput.Name = "TestOutput";
            this.TestOutput.Size = new System.Drawing.Size(402, 26);
            this.TestOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(823, 724);
            this.Controls.Add(this.TestOutput);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.NotificationBox);
            this.Controls.Add(this.DateSelector);
            this.Controls.Add(this.Calendar1);
            this.Name = "Form1";
            this.DateSelector.ResumeLayout(false);
            this.AdminBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.GroupBox DateSelector;
        private System.Windows.Forms.Button CreateDateRange;
        private System.Windows.Forms.GroupBox NotificationBox;
        private System.Windows.Forms.GroupBox AdminBox;
        private System.Windows.Forms.Button UserStory3;
        private System.Windows.Forms.Button UserStory2;
        private System.Windows.Forms.Button UserStory1;
        private System.Windows.Forms.TextBox TestOutput;
    }
}

