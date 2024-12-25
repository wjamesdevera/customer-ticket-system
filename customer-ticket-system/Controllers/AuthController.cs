using customer_ticket_system.Models;
using System.Web.Mvc;
using System.Web.Http;
using System;
using System.Web.Http.Results;

namespace customer_ticket_system.Controllers
{
    public class AuthController : Controller
    {

        readonly CustomerTicketDbContext _context = new CustomerTicketDbContext();

        [System.Web.Http.HttpPost]
        public ActionResult Login([FromBody] User loggingUser)
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public JsonResult Seed()
        {
            
            User[] users =
            {
                new User{FirstName="Winfrey", LastName="De Vera", Email="w.jamesdevera@gmail.com", PasswordHash="password123", RoleId=3, CreatedAt=DateTime.Now, UpdatedAt=DateTime.Now},
                new User{FirstName="Kristine", LastName="Vasquez",Email="cynthia95@example.org", PasswordHash="z$v7Nrku(b", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Brandon", LastName="Robertson",Email="erikaarnold@example.com", PasswordHash="Z6UgInMz%J", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Robert", LastName="Rice",Email="fernandeztracey@example.com", PasswordHash="R&v%q5D7tp", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Diane", LastName="Duncan",Email="bryan08@example.net", PasswordHash="z(0VEg^Hv^", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Jennifer", LastName="Brown",Email="tdaniel@example.com", PasswordHash="WW+7hPGguw", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="William", LastName="Clay",Email="christopher76@example.net", PasswordHash="+6hF#4bagP", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Catherine", LastName="Weaver",Email="marshallanthony@example.org", PasswordHash="u)S_0bWxyC", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Julie", LastName="Gillespie",Email="justin98@example.net", PasswordHash="$xGeNsee+6", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="David", LastName="Wilson",Email="browncatherine@example.org", PasswordHash="%Te8ShfMCM", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Stephanie", LastName="Carson",Email="sierraevans@example.org", PasswordHash="E9Dd8#FR_d", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Karina", LastName="Andrade",Email="shealorraine@example.net", PasswordHash="_LByqkjV21", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Brandon", LastName="Green",Email="andrew77@example.net", PasswordHash="P%V8V1B8Ks", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Rebecca", LastName="Brown",Email="ksmith@example.com", PasswordHash="7kwEP@dL#9", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Mallory", LastName="Gonzales",Email="mcobb@example.net", PasswordHash="GR51E#qS8(", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Jessica", LastName="Meyer",Email="russell22@example.org", PasswordHash="Rs_Fe_Qu&5", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Steven", LastName="Powell",Email="rayshannon@example.com", PasswordHash="pz&i0GKz8^", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Cesar", LastName="Reid",Email="tyler99@example.com", PasswordHash="&98F*V@uqE", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Eric", LastName="Wells",Email="robertoliver@example.com", PasswordHash="j+8BZaxB*T", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Stephen", LastName="Miller",Email="cooperkristine@example.net", PasswordHash="+TEB8(9cz4", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                new User{FirstName="Amber", LastName="Flores",Email="ahamilton@example.org", PasswordHash="iV5Z9Jiw*&", RoleId=3, CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now}
            };
            using(var db = _context)
            {
                foreach (User user in users)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
            return Json(new { status = "success"}, JsonRequestBehavior.AllowGet);
        }

        [System.Web.Http.HttpPost]
        public JsonResult CreateAccount([FromBody] User newUser)
        {
            using (var db = _context)
            {
                if (newUser == null)
                {
                    return Json(new {status= "failed"}, JsonRequestBehavior.AllowGet);
                }
                User user = new User { FirstName = newUser.FirstName, LastName = newUser.LastName, Email = newUser.Email, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now };
                User dbUser = db.Users.Add(user);
                Session dbSession = db.Sessions.Add(new Models.Session { UserId = dbUser.UserId, CreatedAt = DateTime.Now });
                db.SaveChanges();
            }
            return Json(new { status = "success" }, JsonRequestBehavior.AllowGet);
        }
    }
}