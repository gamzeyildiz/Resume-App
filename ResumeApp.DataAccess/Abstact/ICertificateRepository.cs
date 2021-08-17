using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeApp.DataAccess.Abstact
{
    public interface ICertificateRepository
    {
        List<Certificate> GetAllCertificates();
        Certificate GetCertificateById(int id);
        Certificate CreateCertificate(Certificate certificate);
        Certificate UpdateCertificate(Certificate certificate);
        void DeleteCertificate(int id);
    }
}
