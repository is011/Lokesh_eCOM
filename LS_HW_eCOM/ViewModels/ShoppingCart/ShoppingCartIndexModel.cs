namespace LS_HW_eCOM.ViewModels.ShoppingCart
{
    public class ShoppingCartIndexModel
    {
        public LS_HW_eCOM.Models.ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
        public string ReturnUrl { get; set; }
    }
}
