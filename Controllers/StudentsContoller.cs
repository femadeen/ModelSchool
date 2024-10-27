using Microsoft.AspNetCore.Mvc;
using ModelSchool.Interfaces;

namespace ModelSchool.Controllers
{
    public class StudentsContoller : Controller
    {
        private readonly IStudentRepository _studentInterface;

        public StudentsContoller(IStudentRepository studentInterface)
        {
            _studentInterface = studentInterface;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
