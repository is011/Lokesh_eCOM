
using System;
using System.Collections.Generic;
using LS_HW_eCOM.Enums;

namespace LS_HW_eCOM.ViewModels.Order
{
	public class OrderArchiveModel
	{
		public DateTime? MinDate { get; set; }
		public DateTime? MaxDate { get; set; }
		public decimal? MinPrice { get; set; }
		public decimal? MaxPrice { get; set; }
		public OrderBy OrderBy { get; set; }
		public int Page { get; set; }
		public int PageCount { get; set; }
		public string ZipCode { get; set; }
		public string UserId { get; set; }
		public IEnumerable<OrderIndexModel> Orders { get; set; }
	}
}