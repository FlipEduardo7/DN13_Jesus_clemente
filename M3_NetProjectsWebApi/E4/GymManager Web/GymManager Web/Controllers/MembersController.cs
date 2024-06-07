﻿using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
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

        public IActionResult Index()
        {
            DateTime fechaActual = DateTime.Now;
            string fecha = fechaActual.ToString("dd-MM-yyyy HH:mm:ss");
            _logger.LogInformation($"User executed Member's Index");

            List<Member> members = _membersAppService.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int memberId)
        {
            _membersAppService.DeleteMember(memberId);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int memberId)
        {
            Member member = _membersAppService.GetMember(memberId);

            return View(member);
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppService.AddMember(member);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppService.EditMember(member);
            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
