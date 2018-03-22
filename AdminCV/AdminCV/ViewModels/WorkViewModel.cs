using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminCV.ViewModels
{
    public class WorkViewModel
    {
        public int ID_WorkExperience { get; set; }
        public int ID_Company { get; set; }
        public int ID_Position { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    }
}