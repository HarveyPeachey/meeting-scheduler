using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetingSchedular
{
    public class Meeting
    {
        protected int meetingNo;
        protected bool meetingPrivacy;
        protected string meetingOwner;
        protected string location;
        List<string> participants = new List<string>(0);
        protected string date;
        List<string> specialRequests = new List<string>(0);

        public Meeting(int meetingNo)
        {
            this.meetingNo = meetingNo;
        }

        public void SetMeetingNo(int no)
        {
            meetingNo = no;
        }

        public int GetMeetingNo()
        {
            return meetingNo;
        }

        public void AddParticipant(string participant)
        {
            participants.Add(participant);
        }

        public string GetParticipant(int index)
        {
            return participants[index];
        }

        public int GetNoOfParticipants()
        {
            return participants.Count;
        }

        public void SetDate(string date)
        {
            this.date = date;
        }

        public string GetDate()
        {
            return date;
        }

        public string GetLocation()
        {
            return location;
        }

        public void SetLocation(string location)
        {
            this.location = location;
        }
    }
}
