using ModelSchool.Models.Entities;

namespace ModelSchool.Interfaces
{
    public interface ILecturerRepository
    {
        public Lecturer GetLecturerByID (int employeeID);
        public Lecturer AddLecturer (Lecturer lecturer);
        public Lecturer DeleteLecturer (Lecturer lecturer);
        public void UpdateLecturerProfile(Lecturer lecturer);
        public IEnumerable<Lecturer> GetAllLecturers();
    }
}
