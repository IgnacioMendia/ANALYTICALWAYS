using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context
    {
        public static List<Student> lstStudent = new List<Student>();
        public static List<Course> lstCourse = new List<Course>();
        public static List<StudentCourse> lstStudentCourse = new List<StudentCourse>();
    }
}
