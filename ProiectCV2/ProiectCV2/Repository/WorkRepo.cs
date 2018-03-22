using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProiectCV2.ViewModels;
namespace ProiectCV2.Repository
{
    public class WorkRepo:BaseRepo
    {
        public List<WorkViewModel> GetCVInfo()
        {
            var entryPoint = (from we in _dbContext.WorkExperience
                              join co in _dbContext.Company on we.ID_Company equals co.ID_Company
                              join pos in _dbContext.Position on we.ID_Position equals pos.ID_Position
                              orderby we.StartDate descending
                              select new WorkViewModel
                              {
                                  Company = co.Name,
                                  Position = pos.Name,
                                  StartDateTime = we.StartDate,
                                  EndDateTime = we.EndDate,
                                  Info=co.Info
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