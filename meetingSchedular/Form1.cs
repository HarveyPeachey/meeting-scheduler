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
    }
}
