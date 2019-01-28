using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetingSchedular
{
    public class Account
    {
        protected string username;
        protected string password;
        protected int[,] prefferedDates = new int[4, 45];
        protected DateTime[] weekDates = new DateTime[4];
        protected List<string> messageList = new List<string>(10);
        string[,] timesOccurrences = new string[45, 2];

        public Account()
        {
            for (int i = 0; i < 10; i++)
                messageList.Add("<empty>");
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetUsername(string user)
        {
            this.username = user;
        }

        public void SetPassword(string pass)
        {
            this.password = pass;
        }

        public void SetPrefferedDates(int[,] dates)
        {
            prefferedDates = dates;
        }
        
        public int[,] GetPrefferedDates()
        {
            return prefferedDates;
        }

        public void SetWeekDates(DateTime[] dates)
        {
            weekDates = dates;
        }

        public void SetWeek(DateTime date, int index)
        {
            weekDates[index] = date;
        }

        public DateTime[] GetWeekDates()
        {
            return weekDates;
        }

        public void SetTimes(string[,] times)
        {
            timesOccurrences = times;
        }

        public string[,] GetTimes()
        {
            return timesOccurrences;
        }
    }
}