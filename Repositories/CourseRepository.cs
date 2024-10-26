using ModelSchool.Interfaces;
using ModelSchool.Models.Entities;

namespace ModelSchool.Repositories
{
    public class CourseRepository : ICourseInterface
    {
        public Course AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(string courseName)
        {
            throw new NotImplementedException();
        }

        public Course FindCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCoursesByStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetSelectedCourses(List<int> courseIds)
        {
            throw new NotImplementedException();
        }
    }
}
