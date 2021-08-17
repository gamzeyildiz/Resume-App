using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Abstract
{
    public interface IResumeService
    {
        List<Resume> GetAllResumes();
        Resume GetResumeById(int id);
        Resume CreateResume(Resume Resume);
        Resume UpdateResume(Resume Resume);
        void DeleteResume(int id);
    }
}
