using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeApp.DataAccess.Concrete
{
    public class CertificateRepository : ICertificateRepository
    {
        public Certificate CreateCertificate(Certificate certificate)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Certificates.Add(certificate);
                resumeDbContext.SaveChanges();
                return certificate;
            }
        }

        public void DeleteCertificate(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                var deletedCertificate = GetCertificateById(id);
                resumeDbContext.Certificates.Remove(deletedCertificate);
                resumeDbContext.SaveChanges();
            }
        }

        public List<Certificate> GetAllCertificates()
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Certificates.ToList();
            }
        }

        public Certificate GetCertificateById(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Certificates.Find(id);
            }
        }

        public Certificate UpdateCertificate(Certificate certificate)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Certificates.Update(certificate);
                return certificate;
            }
        }
    }
}
