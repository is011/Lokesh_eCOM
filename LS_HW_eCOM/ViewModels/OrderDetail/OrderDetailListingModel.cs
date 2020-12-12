
namespace LS_HW_eCOM.ViewModels.OrderDetail
{
	public class OrderDetailListingModel
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int FoodId { get; set; }
        public FoodSummaryModel Food { get; set; }
        public int Amount { get; set; }
		public decimal Price { get; set; }	
	}
}