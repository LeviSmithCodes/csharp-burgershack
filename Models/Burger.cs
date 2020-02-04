using System;
using System.Collections.Generic;

namespace csharp_burgershack.Models
{
  public class Burger
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Ingredients { get; set; }

    public float Cost { get; set; }

    public string Description { get; set; }

    public Burger()
    {
    }
    public Burger(string name, string ingredients, float cost, string description)
    {
      Name = name;
      Ingredients = ingredients;
      Cost = cost;
      Description = description;
    }
  }
}