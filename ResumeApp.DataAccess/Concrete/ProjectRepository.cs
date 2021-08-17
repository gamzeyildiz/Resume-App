using ResumeApp.DataAccess.Abstact;
using ResumeApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResumeApp.DataAccess.Concrete
{
    class ProjectRepository : IProjectRepository
    {
        public Project CreateProject(Project project)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Projects.Add(project);
                resumeDbContext.SaveChanges();
                return project;
            }
        }

        public void DeleteProject(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                var deletedProject = GetProjectById(id);
                resumeDbContext.Projects.Remove(deletedProject);
                resumeDbContext.SaveChanges();
            }
        }

        public List<Project> GetAllProjects()
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Projects.ToList();
            }
        }

        public Project GetProjectById(int id)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                return resumeDbContext.Projects.Find(id);
            }
        }

        public Project UpdateProject(Project project)
        {
            using (var resumeDbContext = new ResumeDbContext())
            {
                resumeDbContext.Projects.Update(project);
                return project;
            }
        }
    }
}
