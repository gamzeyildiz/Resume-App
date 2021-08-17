using ResumeApp.Business.Abstract;
using ResumeApp.Entities;
using ResumeApp.DataAccess.Abstact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Concrete
{
    public class ResumeManager : IResumeService
    {
        private IResumeRepository _resumeRepository;

        public ResumeManager(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }
        public Resume CreateResume(Resume resume)
        {
            return _resumeRepository.CreateResume(resume);
        }

        public void DeleteResume(int id)
        {
            _resumeRepository.DeleteResume(id);
        }

        public List<Resume> GetAllResumes()
        {
            return _resumeRepository.GetAllResumes();
        }

        public Resume GetResumeById(int id)
        {
            if (id > 0)
            {
                return _resumeRepository.GetResumeById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public Resume UpdateResume(Resume resume)
        {
            return _resumeRepository.UpdateResume(resume);
        }
    }
}
