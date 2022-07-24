using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ToDoList.Controllers
{
  public class RestourantsController : Controller
  {
    private readonly ToDoListContext _db;

    public RestaurantsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
      return View(model);
    }

    //EDIT OUR DESCRIPTION
    public ActionResult Edit(int id)
    {
        var thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
        return View(thisItem);
    }

    [HttpPost]
    public ActionResult Edit(Item item)
    {
        _db.Entry(item).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    //UPDATING THE CONTROLLER
    public ActionResult Delete(int id)
    {
        var thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
        ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "CuisineName");
        return View(thisItem);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisRestaurant = _db.Restaurants.FirstOrDefault(restarant => restarant.RestarantId == id);
        _db.Items.Remove(thisRestaurant);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
        ViewBag.PageTitle = "View All Restaurants";
        return View(thisRestaurant);
    }

    public ActionResult Create()
    {
      ViewBag.CuisineId = new SelectList(_db.Cuisines, "CuisineId", "CuisineName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Restaurant restaurant)
    {
      _db.Items.Add(restaurant);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}