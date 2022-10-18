using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;

namespace PasswordGenerator.Controllers
{
    public class PasswordController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            PasswordModel myfirstPassword = new PasswordModel();
            return View(myfirstPassword);
        }

        [HttpPost]
        public IActionResult Index(int passlength)
        {
            PasswordModel mypasword = new PasswordModel();

            int minCharCode = 35;
            int maxCharCode = 126;
            string result = "";

            Random myRandom = new Random();

            for (int i = 0; i < passlength; i++)
            {

                int myValue = myRandom.Next(minCharCode, maxCharCode);
                char myChar = Convert.ToChar(myValue);
                result = result + myChar;
            }
            mypasword.passwordResult = result;

            return RedirectToAction("Index", mypasword);
        }
    }
}
