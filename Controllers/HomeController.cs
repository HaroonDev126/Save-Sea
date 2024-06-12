using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Save_Seas.Data;
using Save_Seas.Models;
using System.Diagnostics;

namespace Save_Seas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Formdbcontext _formdbcontext;

        public HomeController(ILogger<HomeController> logger, Formdbcontext formdbcontext)
        {
            _logger = logger;
            _formdbcontext = formdbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactForm(ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newContact = new ContactForm
                    {
                        firstname = contactForm.firstname,
                        lastname = contactForm.lastname,
                        email = contactForm.email,
                        phone = contactForm.phone,
                        message = contactForm.message
                    };

                    _formdbcontext.ContactForm.Add(newContact);
                    _formdbcontext.SaveChanges();

                    //return Redirect("/home/Contact");
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError(ex, "Error occurred while saving changes to the database");
                    ModelState.AddModelError("", "An error occurred while processing your request. Please try again later.");
                }
            }

            return View("/Contact/Contact");
        }

        public IActionResult ContactSuccess()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
