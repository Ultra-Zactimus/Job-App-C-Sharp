using Microsoft.AspNetCore.Mvc;
using Job.Models;
using System.Collections.Generic;

namespace Job.Controllers
{
  public class JobController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Jobs> allJobs = Jobs.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/create")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, Contact contact)
    {
      Jobs myJob = new Jobs(title, description, contact);
      return RedirectToAction("Index");
    }
  }

}