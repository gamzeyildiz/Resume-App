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
    public class CertificateManager : ICertificateService
    {
        private ICertificateRepository _certificateRepository;

        public CertificateManager(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }
        public Certificate CreateCertificate(Certificate certificate)
        {
            return _certificateRepository.CreateCertificate(certificate);
        }

        public void DeleteCertificate(int id)
        {
            _certificateRepository.DeleteCertificate(id);
        }

        public List<Certificate> GetAllCertificates()
        {
            return _certificateRepository.GetAllCertificates();
        }

        public Certificate GetCertificateById(int id)
        {
            if (id > 0)
            {
                return _certificateRepository.GetCertificateById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public Certificate UpdateCertificate(Certificate certificate)
        {
            return _certificateRepository.UpdateCertificate(certificate);

        }
    }
}
