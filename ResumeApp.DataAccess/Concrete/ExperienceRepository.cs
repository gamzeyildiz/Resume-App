using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeApp.DataAccess.Concrete
{
    public class ExperienceRepository : IExperienceRepository
    {
        public Experience CreateExperience(Experience experience)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Experiences.Add(experience);
                resumeDbContext.SaveChanges();
                return experience;
            }
        }

        public void DeleteExperience(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                var deletedExperience = GetExperienceById(id);
                resumeDbContext.Experiences.Remove(deletedExperience);
                resumeDbContext.SaveChanges();
            }
        }

        public List<Experience> GetAllExperiences()
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Experiences.ToList();
            }
        }

        public Experience GetExperienceById(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Experiences.Find(id);
            }
        }

        public Experience UpdateExperience(Experience experience)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Experiences.Update(experience);
                return experience;
            }
        }
    }
}
