using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

namespace FutureValue.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(FutureValueModel model)
    {
        var interest = model.YearlyInterestRate / 100;

        var fv = ModelState.IsValid ? model.MonthlyInvestment * 12
               * ((Math.Pow(interest + 1, model.Years) - 1)
               / interest) : 0;
        model.FutureValue = fv.ToString("C2");
        return View(model);
    }
}
