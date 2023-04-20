using HW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HW.ViewModels;

namespace HW.Controllers
{
    public class StudentController : Controller
    {

        List<Student> _students;
        List<Group> _groups;

        public StudentController()
        {
            _students= new List<Student>
            {
                new Student { Id = 1, FullName = "Mariya H", Point = 50},
                new Student { Id = 2, FullName = "Lena S", Point = 60},
                new Student { Id = 3, FullName = "Liza X", Point = 70},
                new Student { Id = 4, FullName = "Larisa N", Point = 80},
                new Student { Id = 5, FullName = "Dima M", Point = 90},
                new Student { Id = 6, FullName = "Tima D", Point = 40},
            };

            _groups = new List<Group>
            {
                new Group { Id = 1, Name = "P232"},
                new Group { Id = 2, Name = "D230"},
                new Group { Id = 3, Name = "T200"},
                new Group { Id = 4, Name = "S200"},
                new Group { Id = 5, Name = "A132"},
            };
        }
        public IActionResult Index()
        {
            StudentViewModel studentVM = new StudentViewModel
            {
                Students = _students,
                Groups = _groups
            };

            return View(studentVM);
        }

        public IActionResult Detail(int id)
        {
        Student std = _students.Find(x => x.Id == id);

        if (std == null)
            return View("Error");

            return View(std);
        }
    }
}
