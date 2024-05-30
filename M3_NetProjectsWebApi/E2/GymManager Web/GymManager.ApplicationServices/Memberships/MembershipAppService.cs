using GymManager.Core.Memberships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Memberships
{
    public class MembershipAppService : IMembershipAppService
    {
        private static List<Membership> Memberships = new List<Membership>();

        public int AddMembership(Membership membership)
        {
            DateTime fechaActual = DateTime.Now;
            membership.ID = new Random().Next();
            membership.CreatedOn = fechaActual.ToString("dd-MM-yyyy");
            Memberships.Add(membership);
            return membership.ID;
        }

        public void DeleteMembership(int membershipId)
        {
            var m = Memberships.Where(x => x.ID == membershipId).FirstOrDefault();

            Memberships.Remove(m);
        }

        public void EditMembership(Membership membership)
        {
            var m = Memberships.Where(x => x.ID == membership.ID).FirstOrDefault();
            m.Name = membership.Name;
            m.Cost = membership.Cost;
            m.Duration = membership.Duration;
        }

        public Membership GetMembership(int membershipId)
        {
            var m = Memberships.Where(x => x.ID == membershipId).FirstOrDefault();
            return m;
        }

        public List<Membership> GetMemberships()
        {
            return Memberships;
        }

    }
}
