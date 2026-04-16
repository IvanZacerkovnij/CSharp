using Homework4_EF.Context;
using Homework4_EF.Entities;
using Homework4_EF.Interfaces;

namespace Homework4_EF.Repositories;

public class SubjectRepository(AcademyDbContext _context) : ICRUD<Subject>
{
    public void Create(Subject model)
    {
        _context.Subjects.Add(model);
        _context.SaveChanges();
    }

    public void Update(Subject model)
    {
        _context.Subjects.Update(model);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Subjects.Remove(_context.Subjects.Find(id));
        _context.SaveChanges();
    }

    public Subject? GetById(int id)
    {
        return _context.Subjects.Find(id);
    }

    public IEnumerable<Subject>? GetAll()
    {
        return _context.Subjects;
    }
}