using ModelSchool.Models.Entities;

namespace ModelSchool.Interfaces
{
    public interface IDepartmentRepository
    {
        public Department AddDepartment(Department department);
        public Department FindDepartmentById(int id);
        public void DeleteDepartment(int id);
        public Department UpdateDepartment(Department department);
        public List<Department> GetAllDepartments();
        public bool Exists(string name);
    }
}
