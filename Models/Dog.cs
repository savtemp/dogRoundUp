using System.ComponentModel.DataAnnotations;

namespace dogRoundUp.Models
{
  public class Dog
  {
    public Dog(string name, int age, string color, string gender, bool isHandsome, int toys, int id)
    {
      Name = name;
      Age = age;
      Color = color;
      Gender = gender;
      IsHandsome = isHandsome;
      Toys = toys;
      Id = id;

    }

    public Dog()
    {

    }

    [Required]
    [MaxLength(15)]
    public string Name { get; set; }
    public int Age { get; private set; }
    public string Color { get; set; }
    public string Gender { get; set; }
    public bool? IsHandsome { get; set; }
    public int? Toys { get; set; }

    public int Id { get; set; }
  }
}