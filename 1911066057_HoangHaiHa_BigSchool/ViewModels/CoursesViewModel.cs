using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1911066057_HoangHaiHa_BigSchool.Models;

namespace _1911066057_HoangHaiHa_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}