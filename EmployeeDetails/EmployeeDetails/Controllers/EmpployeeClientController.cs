using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetails.Controllers
{
    public class EmpployeeClientController : Controller
    {
        //https://localhost:7221/EmpployeeClient/Login
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public string Login(string userid, string password)
        {
            string message = "Success";
            if(userid != "admin")
                {
                message = "Failure";
            }
                if(password!="admin")
            {
                message = "Failure";
            }
            
            return message;
        }
    }
}
