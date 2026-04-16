using Homework4_EF.Context;
using Homework4_EF.Entities;
using Homework4_EF.Interfaces;

namespace Homework4_EF.Repositories;

public class StudentRepository(AcademyDbContext _context) : ICRUD<Student>
{
    public void Create(Student model)
    {
        _context.Add(model);
        _context.SaveChanges();
    }

    public void Update(Student model)
    {
        _context.Update(model);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Students.Remove(_context.Students.Find(id));
        _context.SaveChanges();
    }

    public Student? GetById(int id)
    {
        return _context.Students.Find(id);
    }

    public IEnumerable<Student>? GetAll()
    {
        return _context.Students;
    }
}