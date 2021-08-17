using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResumeApp.Business.Abstract;
using ResumeApp.Entities;

namespace ResumeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        private ICertificateService _certificateService;
        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpGet]
        public List<Certificate> Get()
        {
            return _certificateService.GetAllCertificates();
        }

        [HttpGet("{id}")]
        public Certificate Get(int id)
        {
            return _certificateService.GetCertificateById(id);
        }

        [HttpPost]
        public Certificate Post([FromBody] Certificate certificate)
        {
            return _certificateService.CreateCertificate(certificate);
        }

        [HttpPut]
        public Certificate Put([FromBody] Certificate certificate)
        {
            return _certificateService.UpdateCertificate(certificate);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _certificateService.DeleteCertificate(id);
        }
    }
}
