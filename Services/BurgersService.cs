using System;
using System.Collections.Generic;
using csharp_burgershack.DB;
using csharp_burgershack.Models;
using csharp_burgershack.Repositories;

namespace csharp_burgershack.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _repo;
    public BurgersService(BurgersRepository br)
    {
      _repo = br;
    }
    public IEnumerable<Burger> Get()
    {
      return _repo.Get();
    }

    internal Burger GetById(int id)
    {
      Burger found = _repo.FindById(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Burger Create(Burger newBurger)
    {
      _repo.Create(newBurger);
      return newBurger;
    }

    internal Burger Edit(Burger burgerUpdate)
    {
      var current = _repo.FindById(burgerUpdate.Id);
      if (current == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Edit(burgerUpdate);
      return burgerUpdate;
    }

    internal String Delete(int id)
    {
      var current = _repo.FindById(id);
      if (current == null)
      {
        throw new Exception("Invalid Id");
      }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}