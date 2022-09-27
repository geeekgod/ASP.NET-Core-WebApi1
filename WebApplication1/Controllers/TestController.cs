using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TodoContext _context;
        private readonly IConfiguration _config;


        public TestController(TodoContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/TodoItems
        [HttpGet]
        public IActionResult Index()
        {
            Test test = new Test {
                Name = _config["test_key"]
            };

            return new JsonResult(test);
        }
    }
}