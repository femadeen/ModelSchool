using Dapper;
using ModelSchool.Enums;
using ModelSchool.Interfaces;
using ModelSchool.Models.Entities;
using MySqlConnector;

namespace ModelSchool.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static readonly string connectionString = "Server = localhost; User ID = root; Database =modeldb; Password=Oladimeji33;";

        public Student AddStudent(Student student)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO Student (Id, Age, FirstName, LastName, EmailAddress, PhoneNumber, DateOfBirth, Address, Password, Gender, Level, Department) " +
                    "VALUES (@Id, @age, @EmailAddress, @PhoneNumber, @DateOfBirth, @Address, @Password, @Gender, @Level, @department)",student);
            }
            return student;
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
