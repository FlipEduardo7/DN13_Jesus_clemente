using GymManager.Core.Memberships;

namespace GymManager_Web.Model
{
    public class MembershipTypesListModel
    {
        public int NewMembershipCount { get; set; }

        public List<Membership> Memberships { get; set; }
    }
}
