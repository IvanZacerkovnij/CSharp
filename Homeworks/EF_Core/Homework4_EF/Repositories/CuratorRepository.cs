using Homework4_EF.Context;
using Homework4_EF.Entities;
using Homework4_EF.Interfaces;

namespace Homework4_EF.Repositories;

public class CuratorRepository(AcademyDbContext _context) : ICRUD<Curator>
{
    public void Create(Curator model)
    {
        _context.Curators.Add(model);
        _context.SaveChanges();
    }

    public void Update(Curator model)
    {
        _context.Curators.Update(model);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Curators.Remove(_context.Curators.Find(id));
        _context.SaveChanges();
    }

    public Curator? GetById(int id)
    {
        return _context.Curators.Find(id);
    }

    public IEnumerable<Curator>? GetAll()
    {
        return _context.Curators;
    }
}