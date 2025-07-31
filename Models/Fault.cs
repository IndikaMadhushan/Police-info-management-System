using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class Fault
    {
        public string Description { get; set; }
        public string FaultType { get; set; }
        public decimal FineAmount { get; set; }
        public DateTime DateRecorded { get; set; }
        public string Status { get; set; }
    }
}

