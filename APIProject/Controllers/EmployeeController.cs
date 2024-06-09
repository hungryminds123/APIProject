using APIProject.Core.Concrete;
using APIProject.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employee;

        public EmployeeController(
            IEmployeeService employee)
        {
            _employee = employee;
        }



        // HTTP Verbs

        // HttpGet  -- Get some records from database 
        // HttpPost  -- insert some records in database
        // HttpDelete  -- Delete records from database,
        // HttpPut  -- Update records in database



        // 1. I want to call AddNumbers method inside Get
        // 2.I don't want to create a new object

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var empList = await _employee.GetEmployeesAsync();
            return Ok(empList);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
           
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        [HttpDelete("deleteById/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    return Ok();
        //}

        [HttpGet("getEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok();
        }

    }
}
