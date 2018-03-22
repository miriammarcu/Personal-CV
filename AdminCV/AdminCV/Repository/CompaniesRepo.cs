using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminCV.ViewModels;


namespace AdminCV.Repository
{
    public class CompaniesRepo:BaseRepo
    {
        public List<CompanyViewModel> GetCompanies()
        {
            var compList = (from comp in _dbContext.Company
                            orderby comp.Name
                            select new CompanyViewModel
                            {
                                ID_Company = comp.ID_Company,
                                Name=comp.Name

                            }).ToList();
            return compList;
        }
    }
}