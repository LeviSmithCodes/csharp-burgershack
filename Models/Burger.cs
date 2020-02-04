using System;
using System.Collections.Generic;

namespace csharp_burgershack.Models
{
  public class Burger
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public List<string> Ingredients { get; set; }

    public float Cost { get; set; }

    public Burger()
    {
    }
    public Burger(string name, List<string> ingredients, float cost)
    {
      Name = name;
      Ingredients = ingredients;
      Cost = cost;
    }
  }
}