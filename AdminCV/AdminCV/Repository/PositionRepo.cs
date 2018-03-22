using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminCV.ViewModels;

namespace AdminCV.Repository
{
    public class PositionRepo:BaseRepo
    {
       public List<PositionViewModel> GetPosition()
        {
            var positionsList = (from pos in _dbContext.Position
                                 orderby pos.Name
                                 select new PositionViewModel
                                 {
                                     ID_Position = pos.ID_Position,
                                     Name = pos.Name
                                 }).ToList();
            return positionsList;
        }
    }
}