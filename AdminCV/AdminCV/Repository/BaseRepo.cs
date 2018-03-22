using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminCV.Data;
using System.Data.Entity;
namespace AdminCV.Repository
{
    public class BaseRepo
    {
        protected ProiectCVEntities _dbContext;
        public BaseRepo()
        {
            _dbContext = new ProiectCVEntities();
        }
       
    }
}