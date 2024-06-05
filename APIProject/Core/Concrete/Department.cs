using APIProject.Core.Interfaces;

namespace APIProject.Core.Concrete
{
    public class Department : IDepartment
    {
        public string GetDepartmentName()
        {

            return "Inventory";
        }
    }
}
