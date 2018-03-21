using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProiectCV2.ViewModels;

namespace ProiectCV2.Repository
{
    public class EduRepo:BaseRepo
    {
        public List<EduViewModel> GetCVInfo()
        {
            var entryPoint = (from ed in _dbContext.Education
                              join deg in _dbContext.Degree on ed.Degree_ID equals deg.ID_Degree
                              join ins in _dbContext.Institution on ed.Institution_ID equals ins.ID_Institution
                              orderby ed.StartDate descending
                              select new EduViewModel
                              {
                                  Institution = ins.Name,
                                  Degree = deg.Type,
                                  StartDateTime=ed.StartDate,
                                  EndDateTime = ed.EndDate
                              }).ToList();
            foreach(var item in entryPoint)
            {
                item.Startdate = item.StartDateTime.ToString("yyyy-MM-dd");
                item.EndDate = item.EndDateTime.ToString("yyyy-MM-dd");
            }
            return entryPoint;
        }
    }
}