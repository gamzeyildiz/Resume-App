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
    public class ProjectsController : ControllerBase
    {
        private IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public List<Project> Get()
        {
            return _projectService.GetAllProjects();
        }

        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return _projectService.GetProjectById(id);
        }

        [HttpPost]
        public Project Post([FromBody] Project project)
        {
            return _projectService.CreateProject(project);
        }

        [HttpPut]
        public Project Put([FromBody] Project project)
        {
            return _projectService.UpdateProject(project);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _projectService.DeleteProject(id);
        }
    }
}
