using GymManager.Core.Members;

namespace GymManager_Web.Models
{
    public class MemberListViewModel
    {
        public int NewMembersCount { get; set; }

        public List<Member> Members { get; set; }
    }
}
