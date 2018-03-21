using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProiectCV2.ViewModels;

namespace ProiectCV2.Repository
{
    public class InfoRepo:BaseRepo
    {
        public InfoViewModel GetCVInfo()
        {

            return _dbContext.UserInfo.Select(x => new InfoViewModel()
            {
                Name = x.Name,
                Email=x.Email,
                Adress = x.Adress,
                Phone = x.Phone,
                Dob = x.DateOfBirth,
                ProfilPhotoSrc=x.Image,
                AdressPhotoSrc=x.AdressImage
                
            }).FirstOrDefault();
        }
    }
}