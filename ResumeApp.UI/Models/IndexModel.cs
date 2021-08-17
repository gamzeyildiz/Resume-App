using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeApp.DataAccess;
using ResumeApp.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.UI.Models
{
    public class IndexModel : PageModel
    {
        private readonly ResumeDbContext _db;

        public IndexModel(ResumeDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Bio> getBios { get; set; }
        public IEnumerable<Certificate> getCertificates { get; set; }
        public IEnumerable<Experience> getExperiences { get; set; }
        public IEnumerable<Project> getProjects { get; set; }
        public IEnumerable<Resume> getResumes { get; set; }

        public void onGet()
        {
            getBios = _db.Bios.ToList();
            getCertificates = _db.Certificates.ToList();
            getExperiences = _db.Experiences.ToList();
            getProjects = _db.Projects.ToList();
            getResumes = _db.Resume.ToList();
        }
    }
}
