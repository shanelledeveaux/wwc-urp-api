using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<List<Person>> GetAll()

        {
            return _context.People.ToList();
        }
    }
}
