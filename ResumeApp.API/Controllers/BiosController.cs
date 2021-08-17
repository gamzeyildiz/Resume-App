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
    public class BiosController : ControllerBase
    {
        private IBioService _bioService;
        public BiosController(IBioService bioService)
        {
            _bioService = bioService;
        }

        [HttpGet]
        public List<Bio> Get()
        {
            return _bioService.GetAllBios();
        }

        [HttpGet("{id}")]
        public Bio Get(int id)
        {
            return _bioService.GetBioById(id);
        }

        [HttpPost]
        public Bio Post([FromBody] Bio bio)
        {
            return _bioService.CreateBio(bio);
        }

        [HttpPut]
        public Bio Put([FromBody] Bio bio)
        {
            return _bioService.UpdateBio(bio);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bioService.DeleteBio(id);
        }

    }
}
