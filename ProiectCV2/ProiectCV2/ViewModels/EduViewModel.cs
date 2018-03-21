using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProiectCV2.ViewModels
{
    public class EduViewModel
    {
        public int ID_Education { get; set; }
        public string Degree{ get; set; }
        public string Institution { get; set; }
        public string Startdate { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string EndDate { get; set; }

    }
}