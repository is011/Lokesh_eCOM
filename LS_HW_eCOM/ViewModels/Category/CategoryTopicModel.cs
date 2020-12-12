using LS_HW_eCOM.ViewModels.Food;
using System.Collections.Generic;

namespace LS_HW_eCOM.ViewModels.Category
{
    public class CategoryTopicModel
    {
        public CategoryListingModel Category { get; set; }
        public IEnumerable<FoodListingModel> Foods { get; set; }
        public string SearchQuery { get; set; }
    }
}
