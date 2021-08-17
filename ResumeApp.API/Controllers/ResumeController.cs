using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeApp.Business.Abstract;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private IResumeService _resumeService;
        public ResumeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        [HttpGet]
        public List<Resume> Get()
        {
            return _resumeService.GetAllResumes();
        }

        [HttpGet("{id}")]
        public Resume Get(int id)
        {
            return _resumeService.GetResumeById(id);
        }

        [HttpPost]
        public Resume Post([FromBody] Resume resume)
        {
            return _resumeService.CreateResume(resume);
        }

        [HttpPut]
        public Resume Put([FromBody] Resume resume)
        {
            return _resumeService.UpdateResume(resume);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _resumeService.DeleteResume(id);
        }
    }
}

