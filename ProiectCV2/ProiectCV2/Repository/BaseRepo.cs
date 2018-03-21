using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProiectCV2.Data;
using System.Data.Entity;

namespace ProiectCV2.Repository
{
    public class BaseRepo
    {
        protected ProiectCVEntities1 _dbContext;

        public BaseRepo()
        {
            _dbContext = new ProiectCVEntities1();
        }
    }
}