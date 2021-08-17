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
    public class ExperiencesController : ControllerBase
    {
        private IExperienceService _experienceService;
        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpGet]
        public List<Experience> Get()
        {
            return _experienceService.GetAllExperiences();
        }

        [HttpGet("{id}")]
        public Experience Get(int id)
        {
            return _experienceService.GetExperienceById(id);
        }

        [HttpPost]
        public Experience Post([FromBody] Experience experience)
        {
            return _experienceService.CreateExperience(experience);
        }

        [HttpPut]
        public Experience Put([FromBody] Experience experience)
        {
            return _experienceService.UpdateExperience(experience);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _experienceService.DeleteExperience(id);
        }
    }
}
