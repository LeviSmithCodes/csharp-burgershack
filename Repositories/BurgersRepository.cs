using System;
using System.Collections.Generic;
using System.Data;
using csharp_burgershack.Models;
using Dapper;

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
      string sql = "SELECT * FROM burgers";
      return _db.Query<Burger>(sql);
    }

    internal Burger FindById(int id)
    {
      string sql = "SELECT * FROM burgers WHERE id = @id";
      return _db.QueryFirstOrDefault<Burger>(sql, new { id });
    }

    internal void Create(Burger newBurger)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }

    internal void Edit(Burger burgerUpdate)
    {
      throw new NotImplementedException();
    }
  }
}