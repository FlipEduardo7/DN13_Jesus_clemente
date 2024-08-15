using GymManager.Core.Members;
using GymManager.Core.Memberships;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class GymManagerContext : IdentityDbContext
    {
        public virtual DbSet<Member> Members { get; set; }
        //public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options)
        {

        }
    }
}
