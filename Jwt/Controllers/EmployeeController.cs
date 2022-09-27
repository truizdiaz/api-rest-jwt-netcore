using Jwt.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var listEmployee = EmployeeConstants.Employees;

            return Ok(listEmployee);
        }
    }
}
