using Homework1_EF.Entities;

namespace Homework1_EF.Interfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAll();
    Category? GetById(int id);
    
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}