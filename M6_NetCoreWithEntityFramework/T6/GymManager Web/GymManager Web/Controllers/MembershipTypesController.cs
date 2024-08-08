using GymManager.ApplicationServices.Memberships;
using GymManager.Core.Memberships;
using GymManager_Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace GymManager_Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipAppService _membershipAppService;

        public MembershipTypesController(IMembershipAppService membershipAppService)
        {
            _membershipAppService = membershipAppService;
        }

        public IActionResult Index()
        {
            List<Membership> memberships = _membershipAppService.GetMemberships();

            MembershipTypesListModel viewModel = new MembershipTypesListModel();

            viewModel.NewMembershipCount = 5;
            viewModel.Memberships = memberships;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int membershipId)
        {
            _membershipAppService.DeleteMembership(membershipId);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int membershipId)
        {
            Membership membership = _membershipAppService.GetMembership(membershipId);

            return View(membership);
        }

        [HttpPost]
        public IActionResult Create(Membership membership)
        {
            _membershipAppService.AddMembership(membership);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Membership membership)
        {
            _membershipAppService.EditMembership(membership);
            return RedirectToAction("Index");
        }
    }
}
