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
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
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
        public IActionResult Get()
        {
            //Émployee employee = new Émployee();
            //employee.AddNumbers(10, 20);


           int data =  _employee.AddNumbers(10, 20);


            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            _employee.SubtractNumbers(10, 20);

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
