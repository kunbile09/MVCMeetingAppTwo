using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeetingApp.DAL;

namespace MeetingApp.Models
{
    public class EmployeeMeetings
    {
        public int EmployeeId { get; set; }
        public List<Meeting> Meetings { get; set; }
    }
}