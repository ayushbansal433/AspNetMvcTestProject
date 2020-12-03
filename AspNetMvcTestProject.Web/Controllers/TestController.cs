using AspNetMvcTestProject.Service.ITestProjectService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcTestProject.Web.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }
        // GET: Test
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var result = await _testService.GetAllUsers();
            return View(result); 
        }
    }
}