using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogRoundUp.Models;
using dogRoundUp.Repositories;

namespace dogRoundUp.Services
{
  public class DogsService
  {
    private readonly DogsRepository _dogRepo;
    public DogsService(DogsRepository dogRepo)
    {
      _dogRepo = dogRepo;
    }
    internal List<Dog> GetDogs()
    {
      List<Dog> dogs = _dogRepo.GetDogs();
      return dogs;
    }

    internal Dog GetDogById(int id)
    {
      Dog dog = _dogRepo.GetDogById(id);
      return dog;
    }

    internal Dog CreateDog(Dog body)
    {
      Dog dog = _dogRepo.CreateDog(body);
      return dog;
    }

    internal Dog UpdateDog(Dog update)
    {
      return _dogRepo.UpdateDog(update);
    }

    internal string DeleteDog(int id)
    {
      return _dogRepo.DeleteDog(id);
    }
  }
}