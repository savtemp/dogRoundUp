using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogRoundUp.Models;
using dogRoundUp.Services;
using Microsoft.AspNetCore.Mvc;

namespace dogRoundUp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DogsController : ControllerBase
  {
    private readonly DogsService _dogsService;
    public DogsController(DogsService dogsService)
    {
      _dogsService = dogsService;
    }

    [HttpGet]
    public ActionResult<List<Dog>> GetDogs()
    {
      try
      {
        List<Dog> dogs = _dogsService.GetDogs();
        return Ok(dogs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Dog> GetDogById(int id)
    {
      try
      {
        Dog dog = _dogsService.GetDogById(id);
        return Ok(dog);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Dog> CreateDog([FromBody] Dog body)
    {
      try
      {
        Dog dog = _dogsService.CreateDog(body);
        return Ok(dog);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Dog> UpdateDog([FromBody] Dog body, int id)
    {
      try
      {
        body.Id = id;
        Dog dog = _dogsService.UpdateDog(body);
        return Ok(dog);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<string> DeleteDog(int id)
    {
      try
      {
        string message = _dogsService.DeleteDog(id);
        return Ok(message);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}