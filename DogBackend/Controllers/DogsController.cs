using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogBackend.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogBackend.Controllers
{
    public class DogVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DogsController : ControllerBase
    {
        private readonly EFDbContext _context;
        
        public DogsController(EFDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult DogList()
        {
            var dogs = new List<DogVM>
            {
                
            };
            return Ok(dogs);
        }
    }
}