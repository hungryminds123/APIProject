using APIProject.Core.Interfaces;

namespace APIProject.Core.Concrete
{
    public class DepartmentService : IDepartment
    {
        public string GetDepartmentName()
        {

            return "Inventory";
        }
    }
}
