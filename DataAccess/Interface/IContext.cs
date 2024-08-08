using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANALYTICALWAYS.Interface
{
    public interface IContext
    {
        List<Student> lstStudent { get; }
        List<Course> lstCourse { get; }
        List<StudentCourse> lstStudentCourse { get; }
    }
}
