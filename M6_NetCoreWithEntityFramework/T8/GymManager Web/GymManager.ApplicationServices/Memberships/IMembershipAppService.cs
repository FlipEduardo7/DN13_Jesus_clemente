using GymManager.Core.Memberships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Memberships
{
    public interface IMembershipAppService
    {
        List<Membership> GetMemberships();

        int AddMembership(Membership membership);

        void DeleteMembership(int membershipId);

        Membership GetMembership(int membershipId);

        void EditMembership(Membership membership);
    }
}
