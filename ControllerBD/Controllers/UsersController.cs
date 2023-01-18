using ControllerBD.Interfaces;
using ControllerBD.Models;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    private readonly IUser _allUsers;
    private readonly ApplicationContext db;
    public UsersController(IUser allUsers, ApplicationContext db)
    {
        _allUsers = allUsers;
        this.db = db;
    }

    public ViewResult Get()
    {
        ViewBag.Title = "Все пользователи";
        var users = _allUsers.AllUsers;
        return View(users);
    }
    [HttpGet]
    public ViewResult GetId(int id)
    {
        var user = _allUsers.getObjUser(id);

        return View(user);
    }
    [HttpGet]
    public ViewResult Post()
    {
        return View (); 
    }

    [HttpPost]
    public string Post(User user)
    {
        db.Add(user);
        db.SaveChanges();
        return "OK";
    }
}

