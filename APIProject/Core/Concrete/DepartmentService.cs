using APIProject.Core.Interfaces;
using Domain;
using Domain.Repository.Concrete;
using Domain.Repository.Interfaces;
using System.Linq.Expressions;

namespace APIProject.Core.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(
            IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }



        public async Task<IEnumerable<Department>> GetDepartmentName()
        {

            var departmentList = await _departmentRepository.FindAll(x => x.IsActive == true);

            return departmentList.AsEnumerable();
        }
    }
}
