using ResumeApp.Business.Abstract;
using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Concrete
{
    class ExperienceManager : IExperienceService
    {
        private IExperienceRepository _experienceRepository;

        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public Experience CreateExperience(Experience experience)
        {
            return _experienceRepository.CreateExperience(experience);
        }

        public void DeleteExperience(int id)
        {
            _experienceRepository.DeleteExperience(id);
        }

        public List<Experience> GetAllExperiences()
        {
            return _experienceRepository.GetAllExperiences();
        }

        public Experience GetExperienceById(int id)
        {
            if (id > 0)
            {
                return _experienceRepository.GetExperienceById(id);
            }
            throw new Exception("id can not be less than 1");
        }     

        public Experience UpdateExperience(Experience experience)
        {
            return _experienceRepository.UpdateExperience(experience);
        }
    }
}
