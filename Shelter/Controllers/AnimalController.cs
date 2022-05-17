using Microsoft.AspNetCore.Mvc;
using Shelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shelter.Controllers
{
  public class AnimalController : Controller
  {
    private readonly ShelterContext _db;

    public AnimalController(ShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animals.OrderBy(x => x.DateOfAdmit).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
        _db.Animals.Add(animal);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

  }
}