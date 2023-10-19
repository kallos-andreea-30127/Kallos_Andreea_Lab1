using Microsoft.AspNetCore.Mvc;

namespace Kallos_Andreea_Lab1.Controllers
{
    public class WelcomeController : Controller
    {
        public string Index()
        {
            return "Welcome!";
        }

        public string sayHello()
        {
            return "Hello from Andreea!";
        }

        public string showData(string msg, int nbr)
        {
            return "Your message is " + msg + " and your value is " + nbr;
        }
    }
}
