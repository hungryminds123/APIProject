using APIProject.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _department;


        public DepartmentController(IDepartmentService department)
        {
            _department = department;
        }


        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            var departName = await _department.GetDepartmentName();

            return Ok(departName);
        }
    }
}
