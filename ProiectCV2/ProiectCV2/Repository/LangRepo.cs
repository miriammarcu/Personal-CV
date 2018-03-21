using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProiectCV2.ViewModels;
namespace ProiectCV2.Repository
{
    public class LangRepo:BaseRepo
    {
        public List<LangViewModel> GetCVInfo()
        {
            var entryPoint = (from ll in _dbContext.Language_level
                              join lv in _dbContext.Level on ll.Level_ID equals lv.ID_Level
                              join lg in _dbContext.Language on ll.Language_ID equals lg.ID_Language
                              select new LangViewModel
                              {
                                  Language = lg.Language1,
                                  Level = lv.Level1
                              }).ToList();
            return entryPoint;
        }
    }
}