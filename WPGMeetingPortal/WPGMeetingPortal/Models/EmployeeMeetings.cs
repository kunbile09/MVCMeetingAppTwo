using System.Collections.Generic;
using WPGMeetingPortal.DAL;

namespace WPGMeetingPortal.Models
{
    public class EmployeeMeetings
    {
        public int EmployeeId { get; set; }
        public List<Meeting> Meetings { get; set; }
    }
}