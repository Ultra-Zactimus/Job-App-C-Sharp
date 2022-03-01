using System.Collections.Generic;

namespace Job.Models
{
  public class Jobs
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Contact { get; set; }
    private static List<Jobs> _avaliable = new List<Jobs> {};

    public Jobs(string title, string description, string contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      _avaliable.Add(this);
    }

    public static List<Jobs> GetAll()
    {
      return _avaliable;
    }

  }
}