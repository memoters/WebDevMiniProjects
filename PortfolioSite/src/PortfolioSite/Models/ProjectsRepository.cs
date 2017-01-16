using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioSite.Models
{
    public class ProjectsRepository : IProjectsRepository
    {
        private PortfolioDbContext _context;

        public ProjectsRepository(PortfolioDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ProjectDetails> GetAllProjects()
        {
            return _context.Projects.ToList();
        }

        public ProjectDetails GetProjectByID(int id)
        {
            return _context.Projects.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
