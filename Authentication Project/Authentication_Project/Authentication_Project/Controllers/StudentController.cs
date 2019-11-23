using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_Project.Controllers
{
    [Route("/[Controller]")]
    public class StudentController : Controller
    {
        IDataProtector _protector;

        // the 'provider' parameter is provided by DI
        public StudentController(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Test");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = GetStudents();
            var result = students.Select(x => new { StudentId = _protector.Protect(x.StudentId.ToString()), x.Name });
            return Ok(result);
        }

        [HttpGet("{StudentId}")]
        public string Get(int StudentId)
        {
            return "Yes, this is a student id.";
        }

        private List<Models.Student> GetStudents()
        {
            var students = new List<Models.Student>();
            students.Add(new Models.Student() { StudentId = 1, Name = "Chandra" });
            return students;
        }
    }
}