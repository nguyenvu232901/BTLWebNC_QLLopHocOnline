using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTLWebNC_QLLopHocOnline.Models;
using BTLWebNC_QLLopHocOnline.Databases;
using BTLWebNC_QLLopHocOnline.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;

namespace BTLWebNC_QLLopHocOnline.Controllers;

public class HomeController(DatabaseContext DB, ISessionService Session) : BaseController(DB)
{

    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        var user = Session.CurrentUser();

        if (user == null)
            return RedirectToAction("LoginPage", "Login");

        List<CourseModel> courses;

        if (user.Role == UserModel.ROLE_ADMIN)
        {
            courses = DB.Courses.ToList();
        }
        else
        {
            var query = from c in DB.Set<CourseModel>()
                        join eu in DB.Set<CourseUserModel>()
                            on c.Id equals eu.CourseId
                        where eu.UserId == user.Id
                        select c;

            courses = query.ToList();
        }

        return View(courses);
    }

    [HttpGet]
    [Route("/calendar")]
    public IActionResult Calendar()
    {
        return View();
    }

    [HttpGet]
    [Route("/sandbox")]
    public IActionResult Sandbox()
    {
        return View();
    }

    [HttpGet]
    [Route("/newpage")]
    public IActionResult NewPage()
    {
        var user = Session.CurrentUser();

        if (user == null)
            return RedirectToAction("LoginPage", "Login");

        List<CourseModel> courses;

        if (user.Role == UserModel.ROLE_ADMIN)
        {
            courses = DB.Courses.ToList();
        }
        else
        {
            var query = from c in DB.Set<CourseModel>()
                        join eu in DB.Set<CourseUserModel>()
                            on c.Id equals eu.CourseId
                        where eu.UserId == user.Id
                        select c;

            courses = query.ToList();
        }

        return View(courses);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }



    [HttpDelete]
    [Route("/Course/Delete/{id}")]
    [ValidateAntiForgeryToken] // Ensure this attribute is present
    public IActionResult DeleteCourse(int id)
    {
        var course = DB.Courses.Find(id);
        if (course == null)
        {
            return NotFound();
        }

        DB.Courses.Remove(course);
        DB.SaveChanges();

        return Ok();
    }

}



