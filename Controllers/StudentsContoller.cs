using Microsoft.AspNetCore.Mvc;
using ModelSchool.Interfaces;
using ModelSchool.Models.Entities;

namespace ModelSchool.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
            return View(student);
        }



    }
}
