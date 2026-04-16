using Homework4_EF.Context;
using Homework4_EF.Entities;
using Homework4_EF.Interfaces;

namespace Homework4_EF.Repositories;

public class GradeRepository(AcademyDbContext _context) : ICRUD<Grade>
{
    public void Create(Grade model)
    {
        _context.Grades.Add(model);
        _context.SaveChanges();
    }

    public void Update(Grade model)
    {
        _context.Grades.Update(model);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Grades.Remove(_context.Grades.Find(id));
        _context.SaveChanges();
    }

    public Grade? GetById(int id)
    {
        return _context.Grades.Find(id);
    }

    public IEnumerable<Grade>? GetAll()
    {
        return _context.Grades;
    }
}