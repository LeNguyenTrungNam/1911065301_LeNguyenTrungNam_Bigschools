using _1911065301_LeNguyenTrungNam_Bigschool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _1911065301_LeNguyenTrungNam_Bigschool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public bool IsCanceled { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Category { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
                }
        public string Heading { get; set; }
        public string Action
        {
            get
            {
                return (Id != 0) ? "Update" : "Create";
            }
        }
    }
}






