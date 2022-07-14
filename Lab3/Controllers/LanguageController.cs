using Microsoft.AspNetCore.Mvc;
using Lab3.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab3.Controllers
{
    public class LanguageController : Controller
    {
        private readonly LanguagesRepositary languagesRepositary;
        private readonly LanguagesModelRepositary languagesModelRepositary;

        public LanguageController(LanguagesRepositary _languagesRepositary, LanguagesModelRepositary _languagesModelRepositary)
        {
            languagesRepositary = _languagesRepositary;
            languagesModelRepositary = _languagesModelRepositary;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(languagesRepositary.ReadAll());
        }
    }
}

