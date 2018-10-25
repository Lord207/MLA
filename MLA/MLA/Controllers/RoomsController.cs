using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MLA.DAL.Common;
using MLA.Model.Classifier;

namespace MLA.Controllers
{
  public class RoomsController : Controller
  {
    //private readonly GenericRepository<Room> _repo = new GenericRepository<Room>(new RepoContext());
    private readonly GenericRepository<Room> _repo = new GenericRepository<Room>();

    // GET: Rooms
    public ActionResult Index()
    {
      //var tType = typeof(Room);
      //var repo = new GenericRepository<tType>(new RepoContext());


      return View(_repo.GetAll());
    }

    // GET: Rooms/Details/5
    public ActionResult Details(Guid? id)
    {
      if (id == null)
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

      var room = _repo.GetById(id.Value);
      if (room == null)
        return HttpNotFound();

      return View(room);
    }

    // GET: Rooms/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Rooms/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "Id,Name,Comment,Deleted,ReadOnly")] Room room)
    {
      room.DateModified = DateTime.Now;
      if (!ModelState.IsValid) return View(room);

      room.Id = Guid.NewGuid();
      _repo.Create(room);
      return RedirectToAction("Index");
    }

    // GET: Rooms/Edit/5
    public ActionResult Edit(Guid? id)
    {
      if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      var room = _repo.GetById(id.Value);
      if (room == null) return HttpNotFound();

      return View(room);
    }

    // POST: Rooms/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "Id,Name,Comment,Deleted,ReadOnly,DateModified")] Room room)
    {
      if (!ModelState.IsValid) return View(room);
      _repo.Update(room);
      return RedirectToAction("Index");
    }

    // GET: Rooms/Delete/5
    public ActionResult Delete(Guid? id)
    {
      if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      var room = _repo.GetById(id.Value);
      if (room == null) return HttpNotFound();

      return View(room);
    }

    // POST: Rooms/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(Guid id)
    {
      _repo.Remove(id);
      return RedirectToAction("Index");
    }
  }
}