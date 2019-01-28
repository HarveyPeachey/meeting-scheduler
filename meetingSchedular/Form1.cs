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
        public Form1()
        {
            InitializeComponent();
            this.Calendar1.MinDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            this.DateSelector.Text = this.Calendar1.SelectionRange.Start.ToShortDateString();
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
