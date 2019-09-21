using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBackend.DAL.Entities
{
    public class EFDbContext : IdentityDbContext<DbUser, DbRole, long, IdentityUserClaim<long>,
        DbUserRole, IdentityUserLogin<long>,
        IdentityRoleClaim<long>, IdentityUserToken<long>>
    {
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {

        }
    }
}
