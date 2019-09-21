using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [HttpGet]
        public IActionResult DogList()
        {
            var dogs = new List<DogVM>
            {
                new DogVM {
                    Id =1,
                    Name ="Шарік лизак",
                    Image ="https://85.img.avito.st/640x480/5408090485.jpg" },
                new DogVM {
                    Id =2,
                    Name ="Бім до ноги прилип",
                    Image ="https://images.ua.prom.st/1605725118_w640_h640_kopilka-sobaka-sharik.jpg" }
            };
            return Ok(dogs);
        }
    }
}