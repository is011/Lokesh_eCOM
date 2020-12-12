using LS_HW_eCOM.ViewModels.Food;
using System.Collections.Generic;

namespace LS_HW_eCOM.ViewModels.Home
{
    public class HomeIndexModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<FoodListingModel> FoodsList { get; set; }
    }
}
