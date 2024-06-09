using APIProject.Core.Interfaces;
using Domain;
using Domain.Repository.Interfaces;

namespace APIProject.Core.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            var employeeList = await _employeeRepository.FindAll(x => x.IsActive == true);

            return employeeList;
        }
    }
}
