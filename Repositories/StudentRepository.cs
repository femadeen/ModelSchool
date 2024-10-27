using ModelSchool.Enums;
using ModelSchool.Interfaces;
using ModelSchool.Models.Entities;

namespace ModelSchool.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public Student AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool AddStudentCourses(List<StudentCourse> studentCourses)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string firstName, string lastName, string emailAddress)
        {
            throw new NotImplementedException();
        }

        public Student FindStudentByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Student FindStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetFemaleStudents()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetMaleStudents()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByDepartment(int departmentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsByLevel(Level Level)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
