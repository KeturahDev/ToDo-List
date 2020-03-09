using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult ToDoPage(string task) 
    { 
      Item newItem = new Item(task);
      return View(newItem);
    }

  } 
}

  

  