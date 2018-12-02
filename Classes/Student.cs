using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2018
{
    public class Student
    {
        public string matNo { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string group { get; set; }
        public string city { get; set; }
        public string plzcode { get; set; }
        public DateTime birthdate { get; set; }
        public string gender { get; set; }
        public string languages { get; set; }
        public string hobies { get; set; }
        public string eMail { get; set; }
        public string taskACS { get; internal set; }
    }
}
