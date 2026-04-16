using Homework4_EF.Entities;
using Homework4_EF.Interfaces;
using Homework4_EF.Repositories;

namespace Homework4_EF.Services;

public class CuratorService(CuratorRepository _repo) : IService<Curator>
{
    public void Add(Curator entity)
    {
        _repo.Create(entity);
    }

    public void Update(Curator entity)
    {
        _repo.Update(entity);
    }

    public void Delete(int id)
    {
        _repo.Delete(id);
    }

    public Curator? GetById(int id)
    {
        return _repo.GetById(id);
    }

    public IEnumerable<Curator>? GetAll()
    {
        return _repo.GetAll();
    }
}