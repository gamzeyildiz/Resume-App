using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Abstract
{
    public interface IExperienceService
    {
        List<Experience> GetAllExperiences();
        Experience GetExperienceById(int id);
        Experience CreateExperience(Experience experience);
        Experience UpdateExperience(Experience experience);
        void DeleteExperience(int id);
    }
}
