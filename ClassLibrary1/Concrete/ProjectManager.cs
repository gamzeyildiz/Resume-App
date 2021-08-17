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
    class ProjectManager : IProjectService
    {
        private IProjectRepository _projectRepository;

        public ProjectManager(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public Project CreateProject(Project project)
        {
            return _projectRepository.CreateProject(project);
        }

        public void DeleteProject(int id)
        {
            _projectRepository.DeleteProject(id);
        }

        public List<Project> GetAllProjects()
        {
            return _projectRepository.GetAllProjects();
        }

        public Project GetProjectById(int id)
        {
            if (id > 0)
            {
                return _projectRepository.GetProjectById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public Project UpdateProject(Project project)
        {
            return _projectRepository.UpdateProject(project);
        }
    }
}
