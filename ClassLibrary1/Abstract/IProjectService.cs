using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApp.Business.Abstract
{
    public interface IProjectService
    {
        List<Project> GetAllProjects();
        Project GetProjectById(int id);
        Project CreateProject(Project project);
        Project UpdateProject(Project project);
        void DeleteProject(int id);
    }
}
