using BTLWebNC_QLLopHocOnline.Databases;
using BTLWebNC_QLLopHocOnline.Interfaces;
using BTLWebNC_QLLopHocOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTLWebNC_QLLopHocOnline.Controllers
{
    public class ProfileController(DatabaseContext DB, ISessionService session) : BaseController(DB)
    {
        [HttpGet("/user/{id}")]
        public IActionResult Index(int id)
        {

            var user = DB.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }
        }

        public IActionResult Edit(int id)
        {
            var user = DB.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }
        }

        [HttpPost]
        public ActionResult Edit(UserModel userModel)
        {
            if (!ModelState.IsValid)
                return View("Edit");

            var existingUser = DB.Users
                .Where((u) => u.Username == userModel.Username)
                .FirstOrDefault();

            if (existingUser != null && existingUser.Id != userModel.Id)
            {
                ModelState.AddModelError("Username", "Username này đã tồn tại trong hệ thống!");
                return View("Edit");
            }

            existingUser = DB.Users
                .Where((u) => u.Id == userModel.Id)
                .FirstOrDefault();

            if (existingUser == null)
            {
                return View("Edit");
            }
            existingUser.Username = userModel.Username;
            existingUser.Password = userModel.Password;
            existingUser.Name = userModel.Name;
            existingUser.Email = userModel.Email;
            existingUser.Phone = userModel.Phone;
            existingUser.Address = userModel.Address;
            existingUser.Created = DateTime.Now;

            DB.Users.Update(existingUser);
            DB.SaveChanges();

            HttpContext.Session.SetInt32("UserId", userModel.Id);
            return RedirectToAction("Index", new { id = userModel.Id });
        }
    }
}
