using System.Collections.Generic;

namespace Job.Models
{
  public class Job
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Contact { get; set; }
    private static List<Job> _avaliable = new List<Job> {};

    public Job(string title, string description, string contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      __avaliable.Add(this);
    }

    public static List<Job> GetAll()
    {
      return _avaliable;
    }

  }
}