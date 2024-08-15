using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager_Web.Model;
using GymManager_Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace GymManager_Web.Controllers
{
    //[Authorize]
    public class MembersController : Controller
    {

        private readonly IMembersAppService _membersAppService;
        private readonly ILogger<MembersController> _logger;

        public MembersController(IMembersAppService membersAppService, ILogger<MembersController> logger) {
            _membersAppService = membersAppService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            DateTime fechaActual = DateTime.Now;
            string fecha = fechaActual.ToString("dd-MM-yyyy HH:mm:ss");
            _logger.LogInformation($"User executed Member's Index");

            List<Member> members = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppService.DeleteMemberAsync(memberId);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int memberId)
        {
            Member member = await _membersAppService.GetMemberAsync(memberId);

            MemberViewModel viewModel = new MemberViewModel
            {
                AllowNewsLetter = member.AllowNewsLetter,
                BirthDay = member.BirthDay,
                CityId = member.City.Id,
                Email = member.Email,
                Id = member.Id,
                LastName = member.LastName,
                Name = member.Name,
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MemberViewModel viewModel)
        {
            DateTime fechaActual = DateTime.Now;
            string fecha = fechaActual.ToString("yyyy-MM-dd");

            Member member = new Member
            {
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                City = new City
                {
                    Id = viewModel.CityId,
                },
                BirthDay = viewModel.BirthDay,
                RegisterDate = DateTime.Parse(fecha),
                AllowNewsLetter = viewModel.AllowNewsLetter
            };

            await _membersAppService.AddMemberAsync(member);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {
            await _membersAppService.EditMemberAsync(member);
            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
