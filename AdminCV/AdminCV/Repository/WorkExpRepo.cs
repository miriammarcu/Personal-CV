using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using AdminCV.ViewModels;
using System.Net.Http;

namespace AdminCV.Repository
{
    public class WorkExpRepo : BaseRepo
    {
        public void SaveWork(WorkViewModel wrk)
        {
            _dbContext.WorkExperience.Add(new Data.WorkExperience
            {
                Company_ID = wrk.ID_Company,
                Position_ID = wrk.ID_Position,
                StartDate = wrk.StartDate,
                EndDate = wrk.EndDate
            });
            _dbContext.SaveChanges();
      

        }   
        public void DeleteWork(int ID)
        {
            _dbContext.WorkExperience.Remove(_dbContext.WorkExperience.FirstOrDefault(e => e.ID_WorkExperience == ID));
            _dbContext.SaveChanges();
            
            
        }
        public List<WorkGetViewModel> GetCVInfo()
        {
            var entryPoint = (from we in _dbContext.WorkExperience
                              join co in _dbContext.Company on we.Company_ID equals co.ID_Company
                              join pos in _dbContext.Position on we.Position_ID equals pos.ID_Position
                              orderby we.StartDate descending
                              select new WorkGetViewModel
                              {
                                  ID_WorkExperience=we.ID_WorkExperience,
                                  Company = co.Name,
                                  Position = pos.Name,
                                  StartDate = we.StartDate,
                                  EndDate = we.EndDate,
                                 
                              }).ToList();
            foreach (var item in entryPoint)
            {
                item.StartDateFormat = item.StartDate.ToString("yyyy-MM-dd");
                if (item.EndDate != null)
                { item.EndDateFormat = item.EndDate.Value.ToString("yyyy-MM-dd"); }
                else
                { item.EndDateFormat = "Ongoing"; }
            }
            return entryPoint;
        }
    }
}