using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;

[Route("/user")]
public class UserController : Controller
{
    [HttpGet("add")]
    public IActionResult RenderAddUserForm()
    {
        return View("Add");
    }

    
    
    [HttpPost("add")]
    public IActionResult SubmitAddUserForm(User newUser, string verify) 
    {
      if(newUser.Password != verify)
      {
        ViewBag.Error = "Passwords must match";
        ViewBag.User = newUser;
        return View("Add");
      }
      
      ViewBag.UserName = newUser.UserName;
      return View("Index");
    }
}
