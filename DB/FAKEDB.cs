using System;
using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.DB
{
  static class FAKEDB
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>(){
      new Burger("Impossible Levi", new List<string>() {"Impossible Patty", "Extra Pickles", "Extra Onions", "American Cheese", "Lettuce", "Fry Sauce"}, 12.99f)
    };
  }
}