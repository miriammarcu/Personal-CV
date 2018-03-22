using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProiectCV2.ViewModels;

namespace ProiectCV2.Repository
{
    public class SkillsRepo:BaseRepo
    {
        public SkillsViewModel GetCVInfo()
        {
            return _dbContext.PersonalSkills.Select(x => new SkillsViewModel()
            {
                CommunicationSkills = x.Communication_skills,
                ManagerialSkills = x.Managerial_skills,
                DigitalCompetences = x.Digital_competences,
                JobRelatedSkills = x.Job_related_skills
            }).FirstOrDefault();
        }
    }
}