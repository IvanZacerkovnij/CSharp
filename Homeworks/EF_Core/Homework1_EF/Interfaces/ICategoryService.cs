using Homework1_EF.Entities;

namespace Homework1_EF.Interfaces;

public interface  ICategoryService
{
    IEnumerable<Category> GetAllCategories();
    Category? GetCategoryById(int id);
    
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}