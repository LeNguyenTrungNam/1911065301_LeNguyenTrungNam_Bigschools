using _1911065301_LeNguyenTrungNam_Bigschool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911065301_LeNguyenTrungNam_Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }

        public bool ShowAction { get; set; }
    }
}