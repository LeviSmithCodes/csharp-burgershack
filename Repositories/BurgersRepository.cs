using System;
using System.Collections.Generic;
using System.Data;
using csharp_burgershack.Models;

namespace csharp_burgershack.Repositories
{
  public class BurgersRepository
  {
    private readonly IDbConnection _db;
    public BurgersRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Burger> Get()
    {
      throw new NotImplementedException();
    }

    internal Burger FindById(int id)
    {
      throw new NotImplementedException();
    }

    internal void Create(Burger newBurger)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}