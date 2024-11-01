﻿using ModelSchool.Enums;
using ModelSchool.Models.Entities;

namespace ModelSchool.Interfaces
{
    public interface IStudentRepository
    {
        public Student AddStudent(Student student);
        public Student FindStudentById(int id);
        public void DeleteStudent(int id);
        public Student UpdateStudent(Student student);
        public List<Student> GetAllStudents();
        public List<Student> GetMaleStudents();
        public List<Student> GetFemaleStudents();
        public List<Student> GetStudentsByLevel(Level Level);
        public List<Student> GetStudentsByCourse(int courseId);
        public List<Student> GetStudentsByDepartment(int departmentId);
        public bool Exists(string firstName, string lastName, string emailAddress);

        public bool AddStudentCourses(List<StudentCourse> studentCourses);

        public Student FindStudentByEmail(string email);
    }
}
