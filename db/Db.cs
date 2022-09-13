using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogRoundUp.Models;

namespace dogRoundUp.db
{
  public static class Db
  {
    public static List<Dog> Dogs { get; set; } = new List<Dog>(){
          new Dog("Mr. Bitey", 4, "Tri-color", "M", true, 5000, 1),
          new Dog("Sir Fluffington", 10, "Brown", "M", false, 4, 2),
          new Dog("Shadow", 11, "Black and white", "M", false, 1, 3)
        };
  }
}