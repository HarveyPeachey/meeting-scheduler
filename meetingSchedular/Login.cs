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
    public partial class Login : Form
    {
        public Account User1, User2;
        public Account[] accounts = new Account[10];
        public Meeting[] meetings = new Meeting[10];
        
        public Login()
        {
            InitializeComponent();
            User1 = new Account();
            User1.SetUsername("Harvey");
            User1.SetPassword("1234");
            User2 = new Account();
            User2.SetUsername("Ben");
            User2.SetPassword("4321");
            accounts[0] = User1;
            accounts[1] = User2;
        }

        private int getNoOfAccs()
        {
            int count = 0;
            for(int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    count += 1;
                }
                else
                {
                    i = accounts.Length;
                }
            }
            return count;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            for (int i = 0; i < getNoOfAccs(); i++)
            {
                if (usernameTxt.Text == accounts[i].GetUsername() && passwordTxt.Text == accounts[i].GetPassword())
                {
                    SignInLbl.Text = "Successful Login";
                    form1.PassValue(accounts, i, meetings);
                    i = getNoOfAccs();
                    form1.Show();
                }
                else if (i == (getNoOfAccs() - 1))
                    SignInLbl.Text = "Unsuccessful Login";
            }
        }
    }
}
