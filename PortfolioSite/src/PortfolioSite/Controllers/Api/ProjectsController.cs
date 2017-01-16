using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioSite.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PortfolioSite.Controllers.Api
{
    [Route("api/projects")]
    public class ProjectsController : Controller
    {
        private IProjectsRepository _repository;

        public ProjectsController(IProjectsRepository repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repository.GetAllProjects();

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _repository.GetProjectByID(id);

            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        
    }
}
