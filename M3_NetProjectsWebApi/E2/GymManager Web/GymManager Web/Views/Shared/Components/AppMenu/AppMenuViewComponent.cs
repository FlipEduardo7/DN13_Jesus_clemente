using GymManager.ApplicationServices.Navigation;
using GymManager_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymManager_Web.Views.Shared.Components.AppMenu
{
    public class AppMenuViewComponent : ViewComponent
    {
        public readonly IMenuAppService _menuAppService;

        public AppMenuViewComponent(IMenuAppService menuAppService) {
            _menuAppService = menuAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string currentPageName = null)
        {
            var model = new MenuViewModel
            {
                CurrentPageName = currentPageName,
                Menu = _menuAppService.GetMenu()
            };
            return View("Default", model);
        }
    }
}
