using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioSite.Models
{
    public interface IProjectsRepository
    {
        IEnumerable<ProjectDetails> GetAllProjects();
        ProjectDetails GetProjectByID(int id);
    }
}
