using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meetingSchedular
{
    public partial class Form1 : Form
    {
        public Account[] accounts = new Account[10];
        public Meeting[] meetings = new Meeting[10];
        List<CheckBox> checkBoxesList = new List<CheckBox>(45);
        int[,] checkedList = new int[4, 45];
        DateTime[] weekDates = new DateTime[4];
        Account thisAcc;

        public Form1()
        {
            InitializeComponent();
            this.Calendar1.MinDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.DateChosen.Text = this.Calendar1.SelectionRange.Start.ToShortDateString();
        }

        public void PassValue(Account[] accounts, int index, Meeting[] meetings)
        {
            this.accounts = accounts;
            this.meetings = meetings;
            WelcomeLabel.Text = "Welcome " + (accounts[index].GetUsername());
            accounts[index].SetPrefferedDates(checkedList);
            thisAcc = accounts[index];
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
            this.DateSelector.Text = this.Calendar1.SelectionRange.Start.ToShortDateString();
=======

>>>>>>> eb2d859f2eb4160c6dcd77c91a1521d922af11fa
        }


        private void DateSelector_Enter(object sender, EventArgs e)
        {

        }

        private void strtTimeDrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var originalTasks = new List<string>
            {
                "9:00","10:00","12:00","13:00","14:00","15:00","16:00"
            };
            int selectedIndex = strtTimeDrp.SelectedIndex;
            strtTimeDrp.DataSource = originalTasks.Where(item => item != "Awake").ToList();
            MessageBox.Show(selectedIndex.ToString());*/
        }
    }
}
