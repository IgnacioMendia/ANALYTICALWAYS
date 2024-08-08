using DataAccess.Model;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANALYTICALWAYS.Interface;

namespace ANALYTICALWAYS.Controller
{
    public class CourseController
    {
        private readonly IContext _context;
        public CourseController(IContext context)
        {
            _context = context;
        }
        public string RegisterCourse(Course objCourse)
        {
            try
            {
                if (objCourse != null)
                {
                    int LastId = _context.lstCourse.Select(x => x.Id).LastOrDefault();
                    objCourse.Id = LastId++;
                    _context.lstCourse.Add(objCourse);
                    return "El curso fue creado con exito.";
                }
                else
                {
                    return "Faltan datos requeridos para poder crear el curso.";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
