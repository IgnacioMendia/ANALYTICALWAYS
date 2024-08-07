using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdCourse { get; set; }
    }
}
