using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MLA.DAL.Common;
using MLA.Model.Classifier;

namespace MLA.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      //var repo = new GenericRepository<Room>(new RepoContext());
      var repo = new GenericRepository<Room>();
      var rooms = repo.GetAll();
      
      //repo.Create(new Room());

      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}