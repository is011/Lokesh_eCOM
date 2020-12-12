using System;
using System.Collections.Generic;
using System.Text;

namespace LS_HW_eCOM.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Food Food { get; set; }
        public int Amount { get; set; }
        public string LS_HW_eCOMpingCartId { get; set; }
    }
}
