using LS_HW_eCOM.Models;
using System.Collections.Generic;

namespace LS_HW_eCOM
{
    public interface ICategory
    {
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void NewCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int id);
    }
}
