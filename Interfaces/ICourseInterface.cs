using ModelSchool.Models.Entities;

namespace ModelSchool.Interfaces
{
    public interface ICourseInterface
    {
        public Course AddCourse(Course course);
        public Course FindCourseById(int id);
        public void DeleteCourse(int id);
        public List<Course> GetAllCourses();
        public List<Course> GetCoursesByStudent(int studentId);
        public List<Course> GetSelectedCourses(List<int> courseIds);
        public bool Exist(string courseName);
    }
}
