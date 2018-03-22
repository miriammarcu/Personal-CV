using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProiectCV2.ViewModels
{
    public class InfoViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string ProfilPhotoSrc { get; set; }
        public string AdressPhotoSrc { get; set; }
        public DateTime Dob { get; set; }
    }
}