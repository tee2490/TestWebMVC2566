using Microsoft.AspNetCore.Mvc;
using P02_Depency.Models;

namespace P02_Depency.Controllers
{
    public class TestDependencyController : Controller
    {
        private readonly ITest test;
        private readonly ITest test1;

        public TestDependencyController(ITest test,ITest test1)
        {
            this.test = test;
            this.test1 = test1;
        }
        public IActionResult Index()
        {
            return View(test.GenerateData());
        }

        public IActionResult Index1()
        {
            var group = new { data1 = test.GenerateData(), data2 = test1.GenerateData() };

            return View(group);
        }

        public IActionResult Index2()
        {
            return View(test.GenerateData());
        }
    }
}
