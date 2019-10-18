using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WwcUrpApi.Models;

namespace WwcUrpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrpController : ControllerBase
    {
        private readonly UrpContext _context;

        public UrpController(UrpContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IQueryable<Person> GetAll()
        {
            var people = _context.People
                .Include(a => a.Pronoun)
                .Include(a => a.Accomplishments)
                .Include(a => a.Education)
                //.ThenInclude(b => b.Location)
                .Include(a => a.OtherAssociations)
                .Include(a => a.Location);

            return people;

        }
    }
}

