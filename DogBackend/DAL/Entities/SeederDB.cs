using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBackend.DAL.Entities
{
    public class SeederDB
    {
        public static void SeedData(IServiceProvider services, 
            IHostingEnvironment env, 
            IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();

                string name = "Шарік лизак";
                if(context.Dogs.SingleOrDefault(d=>d.Name==name)==null)
                {
                    DbDog dog = new DbDog
                    {
                        Name = name,
                        Image = "https://85.img.avito.st/640x480/5408090485.jpg"
                    };
                    context.Dogs.Add(dog);
                    context.SaveChanges();
                }
                
                name = "Бім до ноги прилип";
                if (context.Dogs.SingleOrDefault(d => d.Name == name) == null)
                {
                    DbDog dog = new DbDog
                    {
                        Name = name,
                        Image = "https://images.ua.prom.st/1605725118_w640_h640_kopilka-sobaka-sharik.jpg"
                    };
                    context.Dogs.Add(dog);
                    context.SaveChanges();
                }
            }
        }
    }
}
