using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminCV.ViewModels
{
    public class WorkGetViewModel
    {
        public int ID_WorkExperience { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartDateFormat { get; set; }
        public string EndDateFormat { get; set; }
    }
}