using System.Reflection.Emit;
using System.Reflection;
using ModelSchool.Enums;

namespace ModelSchool.Models.Entities
{
    public class Student : Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public Level Level { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
