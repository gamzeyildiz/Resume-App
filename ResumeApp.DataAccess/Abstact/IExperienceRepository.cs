using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeApp.DataAccess.Abstact
{
    public interface IExperienceRepository
    {
        List<Experience> GetAllExperiences();
        Experience GetExperienceById(int id);
        Experience CreateExperience(Experience experience);
        Experience UpdateExperience(Experience experience);
        void DeleteExperience(int id);
    }
}
