using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeApp.DataAccess.Abstact
{
    public interface IResumeRepository
    {
        List<Resume> GetAllResumes();
        Resume GetResumeById(int id);
        Resume CreateResume(Resume Resume);
        Resume UpdateResume(Resume Resume);
        void DeleteResume(int id);
    }
}
