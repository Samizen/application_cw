using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Visitor
    {
        private string ticketID { get; set; }
        private string ticketName { get; set; }
        private string noOfPeople { get; set; }
        private Boolean isGroup { get; set; }
        private DateTime entryTime { get; set; }
        private DateTime exitTime { get; set; }
        private int under12 { get; set; }
        private int above12 { get; set; }
    }
}
