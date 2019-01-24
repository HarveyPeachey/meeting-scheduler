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
            this.MeetingScheduler = new System.Windows.Forms.Button();
            this.UpdateMeeting = new System.Windows.Forms.Button();
            this.CancelMeeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeetingScheduler
            // 
            this.MeetingScheduler.Location = new System.Drawing.Point(12, 12);
            this.MeetingScheduler.Name = "MeetingScheduler";
            this.MeetingScheduler.Size = new System.Drawing.Size(236, 85);
            this.MeetingScheduler.TabIndex = 0;
            this.MeetingScheduler.Text = "Book Meeting";
            this.MeetingScheduler.UseVisualStyleBackColor = true;
            this.MeetingScheduler.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateMeeting
            // 
            this.UpdateMeeting.Location = new System.Drawing.Point(12, 103);
            this.UpdateMeeting.Name = "UpdateMeeting";
            this.UpdateMeeting.Size = new System.Drawing.Size(236, 90);
            this.UpdateMeeting.TabIndex = 1;
            this.UpdateMeeting.Text = "Re-Plan Meeting";
            this.UpdateMeeting.UseVisualStyleBackColor = true;
            // 
            // CancelMeeting
            // 
            this.CancelMeeting.Location = new System.Drawing.Point(12, 199);
            this.CancelMeeting.Name = "CancelMeeting";
            this.CancelMeeting.Size = new System.Drawing.Size(236, 90);
            this.CancelMeeting.TabIndex = 2;
            this.CancelMeeting.Text = "Cancel Meeting";
            this.CancelMeeting.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 792);
            this.Controls.Add(this.CancelMeeting);
            this.Controls.Add(this.UpdateMeeting);
            this.Controls.Add(this.MeetingScheduler);
            this.Name = "Form1";
            this.Text = "Meeting Scheduler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MeetingScheduler;
        private System.Windows.Forms.Button UpdateMeeting;
        private System.Windows.Forms.Button CancelMeeting;

    }
}

