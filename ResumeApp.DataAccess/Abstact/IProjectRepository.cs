using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeApp.DataAccess.Abstact
{
    public interface IProjectRepository
    {
        List<Project> GetAllProjects();
        Project GetProjectById(int id);
        Project CreateProject(Project project);
        Project UpdateProject(Project project);
        void DeleteProject(int id);
    }
}
