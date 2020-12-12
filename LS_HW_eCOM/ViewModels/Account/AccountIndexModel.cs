using System.Collections.Generic;

namespace LS_HW_eCOM.ViewModels.Account
{
	public class AccountIndexModel
	{
		public IEnumerable<AccountProfileModel> Accounts { get; set; }
		public string SearchQuery { get; set; }
	}
}