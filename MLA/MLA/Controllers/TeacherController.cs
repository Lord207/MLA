using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLA.Controllers
{
  public class TeacherController : Controller
  {
    // GET: Teacher
    public ActionResult Index()
    {
      return View("Cabinet");
    }


    public ActionResult Cabinet()
    {
      return View();
    }



  }
}