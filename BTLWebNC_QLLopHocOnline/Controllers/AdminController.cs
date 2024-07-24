using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTLWebNC_QLLopHocOnline.Models;
using BTLWebNC_QLLopHocOnline.Databases;
using Microsoft.EntityFrameworkCore;

namespace BTLWebNC_QLLopHocOnline.Controllers;

public class AdminController : BaseController {

    private readonly DatabaseContext _context;

    public AdminController(DatabaseContext context) : base(context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("/admin/accounts")]
    public IActionResult Accounts() {
        var results = _context.Users.ToList();
        return View( results);
    }
    [HttpGet("/admin/getdata")]
    public async Task<IActionResult> GetData()
    {
        var results = await _context.Users.ToListAsync();
        return new JsonResult(new { Data = results, TotalItems = results.Count });
    }
    [HttpPost("/admin/create")]
    public async Task<IActionResult> Create(UserModel model)
    {
        model.Created = DateTime.Now;
        _context.Users.Add(model);
        try
        {
            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return Ok(new { success = false });
        }
    }
    [HttpGet("/admin/search")]
    public IActionResult Search(string query)
    {
        var users = _context.Users.Where(u =>
            u.Username.Contains(query) ||
            u.Name.Contains(query) ||
            u.Email.Contains(query) ||
            u.Address.Contains(query) ||
            u.Role.Contains(query)
        ).ToList();
        return PartialView("_UserTablePartial", users);
    }
    [HttpGet]
    [Route("/admin/courses")]
    public IActionResult Courses() {
        return View("Courses");
    }
}
