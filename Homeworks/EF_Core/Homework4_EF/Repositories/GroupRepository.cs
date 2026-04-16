using Homework4_EF.Context;
using Homework4_EF.Entities;
using Homework4_EF.Interfaces;

namespace Homework4_EF.Repositories;

public class GroupRepository(AcademyDbContext _context) : ICRUD<Group>
{
    public void Create(Group model)
    {
        _context.Groups.Add(model);
        _context.SaveChanges();
    }

    public void Update(Group model)
    {
        _context.Groups.Update(model);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Groups.Remove(_context.Groups.Find(id));
        _context.SaveChanges();
    }

    public Group? GetById(int id)
    {
        return _context.Groups.Find(id);
    }

    public IEnumerable<Group>? GetAll()
    {
        return _context.Groups;
    }
}