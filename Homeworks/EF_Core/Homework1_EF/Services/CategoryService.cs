using Homework1_EF.Entities;
using Homework1_EF.Interfaces;

namespace Homework1_EF.Services;

public class CategoryService(ICategoryRepository _repo) : ICategoryService
{
    public IEnumerable<Category> GetAllCategories()
    {
        return _repo.GetAll();
    }

    public Category? GetCategoryById(int id)
    {
        return _repo.GetById(id);
    }

    public void Add(Category category)
    {
        _repo.Add(category);
    }

    public void Update(Category category)
    {
       _repo.Update(category);
    }

    public void Delete(Category category)
    {
       _repo.Delete(category);
    }
}