using Domain;

namespace APIProject.Core.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartmentName();
    }
}
