using Homework4_EF.Entities;
using Homework4_EF.Interfaces;
using Homework4_EF.Repositories;

namespace Homework4_EF.Services;

public class GroupService(GroupRepository _repo) : IService<Group>
{
    public void Add(Group entity)
    {
        _repo.Create(entity);
    }

    public void Update(Group entity)
    {
        _repo.Update(entity);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }

    public Group? GetById(int id)
    {
        return _repo.GetById(id);
    }

    public IEnumerable<Group>? GetAll()
    {
        return _repo.GetAll();
    }
}