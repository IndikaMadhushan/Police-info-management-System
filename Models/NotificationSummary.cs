using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class NotificationSummary
    {
        public int RequestID { get; set; }
        public string NotificationType { get; set; }
        public string UserName { get; set; }
        public string NIC { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
    }

}
