using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogRoundUp.db;
using dogRoundUp.Models;

namespace dogRoundUp.Repositories
{
  public class DogsRepository
  {
    internal List<Dog> GetDogs()
    {
      return Db.Dogs;
    }

    internal Dog GetDogById(int id)
    {
      Dog dog = Db.Dogs.Find(d => d.Id == id);
      if (dog != null)
      {
        return dog;
      }
      throw new Exception("No dog at this id");
    }

    internal Dog CreateDog(Dog body)
    {
      body.Id = Db.Dogs.Count + 1;
      Db.Dogs.Add(body);
      return body;
    }

    internal Dog UpdateDog(Dog update)
    {
      Dog original = GetDogById(update.Id);
      original.Name = update.Name != null ? update.Name : original.Name;

      original.Toys = update.Toys ?? original.Toys;
      original.IsHandsome = update.IsHandsome ?? original.IsHandsome;

      return original;
    }

    internal string DeleteDog(int id)
    {
      Dog dog = Db.Dogs.Find(d => d.Id == id);
      if (!Db.Dogs.Remove(dog))
      {
        throw new Exception("no dog at that id");
      }
      return $"{dog.Name} was deleted";
    }
  }
}