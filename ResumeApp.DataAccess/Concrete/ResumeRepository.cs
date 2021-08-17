using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeApp.DataAccess.Concrete
{
    public class ResumeRepository : IResumeRepository
    {
        public Resume CreateResume(Resume resume)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Resume.Add(resume);
                resumeDbContext.SaveChanges();
                return resume;
            }
        }

        public void DeleteResume(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                var deletedResume = GetResumeById(id);
                resumeDbContext.Resume.Remove(deletedResume);
                resumeDbContext.SaveChanges();
            }
        }

        public List<Resume> GetAllResumes()
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Resume.ToList();
            }
        }

        public Resume GetResumeById(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Resume.Find(id);
            }
        }

        public Resume UpdateResume(Resume resume)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Resume.Update(resume);
                return resume;
            }
        }
    }
}
