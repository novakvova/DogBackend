using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogBackend.DAL.Entities;
using DogBackend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogBackend.Controllers
{
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
            var model = _context.Dogs.Select(d => new DogVM
            {
                Id=d.Id,
                Name=d.Name,
                Image=d.Image
            }).ToList();

            return Ok(model);
        }
    }
}