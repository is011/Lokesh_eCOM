using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using LS_HW_eCOM.Models;
using LS_HW_eCOM.ViewModels.Account;
using LS_HW_eCOM.ViewModels.ShoppingCart;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LS_HW_eCOM.Components
{
	public class AccountSummary : ViewComponent
	{
		private readonly UserManager<ApplicationUser> _userManager;

		public AccountSummary(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		private ApplicationUser _user;

		public IViewComponentResult Invoke()
		{
			GetUser().Wait();
			
			if(_user != null)
			{
                var model = new AccountSummaryModel
                {
                    ImageUrl = _user.ImageUrl,
                    Name = $"{_user.FirstName} {_user.LastName}"
                };

				return View(model);
			}
			return View();
		}

		private async Task GetUser()
		{
			_user = await _userManager.FindByNameAsync(User.Identity.Name);
		}
	}
}
