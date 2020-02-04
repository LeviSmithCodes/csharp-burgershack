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

    internal Burger Create(Burger newBurger)
    {
      string sql = @"
      INSERT INTO burgers
      (name, ingredients, cost, description)
      VALUES
      (@Name, @Ingredients, @Cost, @Description);
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, newBurger);
      newBurger.Id = id;
      return newBurger;
    }

    internal void Edit(Burger burgerUpdate)
    {
      string sql = @"
      UPDATE burgers
      SET 
      name = @Name,
      description = @Description,
      cost = @Cost
      WHERE id = @Id;
      ";
      _db.Execute(sql, burgerUpdate);
    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM burgers WHERE id = @id";
      _db.Execute(sql, new { id });
    }


  }
}