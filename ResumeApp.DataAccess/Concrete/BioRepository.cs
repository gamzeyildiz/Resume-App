using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeApp.DataAccess.Concrete
{
    public class BioRepository : IBioRepository
    {
        public Bio CreateBio(Bio bio)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Bios.Add(bio);
                resumeDbContext.SaveChanges();
                return bio;
            }
        }

        public void DeleteBio(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                var deletedBio = GetBioById(id);
                resumeDbContext.Bios.Remove(deletedBio);
                resumeDbContext.SaveChanges();
            }
        }

        public List<Bio> GetAllBios()
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Bios.ToList();
            }
        }

        public Bio GetBioById(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Bios.Find(id);
            }
        }

        public Bio UpdateBio(Bio bio)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Bios.Update(bio);
                return bio;
            }
        }
    }
}
