using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Calculator;
using Repository;
using WebCalculatorMvc.Models;

namespace WebCalculatorMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringCalculator _calculator;
        private readonly IRepositoryService _respository;

        public HomeController(IRepositoryService respository, IStringCalculator calculator)
        {
            _calculator = calculator;
            _respository = respository;
        }

        public ActionResult Index()
        {
            var history = _respository.ReadCalculationHistory(10);
            
            //List<string> history = new List<string>() { "test1", "test2" };
            CalculatorModel calculatorModel = new CalculatorModel
            {
                Expression = "",
                History = history,
                IsOnlyInteger = false
            };

            return View(calculatorModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        [HttpPost]
        public ActionResult Calculate(string expression, bool isIntegerOnly)
        {

            string result;
            List<string> history = new List<string>();
            try
            {
                result = _calculator.Calculate(expression, isIntegerOnly);
                history = _respository.ReadCalculationHistory(10);

            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return Json(new
            {
                success = true,
                response = result,
                history = history

            });
        }

    }
}