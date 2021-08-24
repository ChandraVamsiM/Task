using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignUpForm.Models;
using System.Net.Http;


namespace SignUpForm.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signup(SignupClass sc)
        {
            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44315/Admin/Signup");

                var insertrec = hc.PostAsJsonAsync<SignupClass>("Signup", sc);
                insertrec.Wait();

                var saverec = insertrec.Result;
                if (saverec.IsSuccessStatusCode)
                {
                    ViewBag.message = "Signup Successfull...!";

                }
            }
            return View();
        }
    }
}