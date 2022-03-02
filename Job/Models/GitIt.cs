using System.Collections.Generic;

namespace Job.Models
{
  public class Jobs : Contact
  {
    // Contact Contact = new Contact();
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact Contact { get; set; }
    private static List<Jobs> _avaliable = new List<Jobs> {};

    public Jobs(string title, string description, Contact contact)
    {
      Title = title;
      Description = description;
      Contact = new Contact();
      _avaliable.Add(this);
    }

    public static List<Jobs> GetAll()
    {
      return _avaliable;
    }

  }
  public class Contact
  {
    public string Email { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }

    // public Contact(string email, string name, int number)
    // {
    //   Email = email;
    //   Name = name;
    //   Number = number;
    // }
  }
}