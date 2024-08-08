using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GymManager.DataAccess.Repositories
{
    public class MembersRepository : Repository<int, Member>
    {
        public MembersRepository(GymManagerContext context) : base(context)
        {

        }

        public override async Task<Member> AddAsync(Member entity)
        {
            var city = await Context.Cities.FindAsync(entity.City.Id);
            entity.City = null;
            await Context.Members.AddAsync(entity);
            city.Members.Add(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<Member> GetAsync(int id)
        {
            var member = await Context.Members.Include(x => x.City).FirstOrDefaultAsync(x => x.Id == id);
            return member;
        }
    }
}
