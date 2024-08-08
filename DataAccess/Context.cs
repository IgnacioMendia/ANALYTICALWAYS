using ANALYTICALWAYS.Interface;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : IContext
    {
        public List<Student> lstStudent { get; } = new List<Student>();
        public List<Course> lstCourse { get; } = new List<Course>();
        public List<StudentCourse> lstStudentCourse { get; } = new List<StudentCourse>();
    }
}
