using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Abstract
{
    public interface ICertificateService
    {
        List<Certificate> GetAllCertificates();
        Certificate GetCertificateById(int id);
        Certificate CreateCertificate(Certificate certificate);
        Certificate UpdateCertificate(Certificate certificate);
        void DeleteCertificate(int id);
    }
}
