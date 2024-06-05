using APIProject.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _department;


        public DepartmentController(IDepartment department)
        {
            _department = department;
        }


        [HttpGet]
        public IActionResult Delete()
        {
            string departName =  _department.GetDepartmentName();

            return Ok(departName);
        }
    }
}
