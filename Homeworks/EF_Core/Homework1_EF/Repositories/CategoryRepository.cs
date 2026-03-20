using Homework1_EF.Context;
using Homework1_EF.Entities;
using Homework1_EF.Interfaces;

namespace Homework1_EF.Repositories;

public class CategoryRepository(ShopDBContext _context) : ICategoryRepository
{
    public IEnumerable<Category> GetAll()
    {
        return _context.Categories.ToList();
    }
    public Category? GetById(int id)
    {
        return _context.Categories.FirstOrDefault(c => c.Id == id);
    }
    
    public void Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }

    public void Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
    }

    public void Delete(Category category)
    {
        _context.Categories.Remove(category);
        _context.SaveChanges();
    }
}