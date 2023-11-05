using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult Index()
        {
            return View(new VelusViewModel());
        }

        [HttpPost]
        public IActionResult Index(VelusViewModel model)
        {
            var scale = new ScaleConverter();

            if (!string.IsNullOrWhiteSpace(model.Number))
            {
                long number;
                if (long.TryParse(model.Number, out number))
                {
                    model.Convert36 = scale.ToCurrent(number);
                }
            }

            if (!string.IsNullOrWhiteSpace(model.Alphanumeric))
            {
                model.Convert10 = scale.ToInt32(model.Alphanumeric).ToString();
            }

            return View(model);
        }
    }
}
