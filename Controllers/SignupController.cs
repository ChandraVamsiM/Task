using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SignUpForm.Models;

namespace SignUpForm.Controllers
{
    public class SignupController : ApiController

    {
        public IHttpActionResult Signupform(SignupClass sc)
        {
            SignupdbEntities db = new SignupdbEntities();
            db.Signuptbs.Add(new Signuptb()
            {
                Userid = sc.Userid,
                Firstname = sc.Firstname,
                Lastname = sc.Lastname,
                Dateofbirth = sc.Dateofbirth,
                Email = sc.Email,
                Password = sc.Password,
                Confirmpassword = sc.Confirmpassword,

            });
            db.SaveChanges();
            return Ok();
        }
    }
}
