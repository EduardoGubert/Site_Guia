using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Site_Guia.API.Data;
using Site_Guia.API.Models;

namespace Site_Guia.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteController : ControllerBase
    {

        private readonly DataContext _context;

        public SiteController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Site> Get()
        {
            return _context.Sites;
        }

        [HttpGet("{id}")]
        public Site GetById(int id)
        {
            return _context.Sites.FirstOrDefault(site => site.SiteID == id);
        }
    }
}
