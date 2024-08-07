using DataAccess.Model;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANALYTICALWAYS.Controller
{
    public class CourseController
    {
        public string RegisterCourse(Course objCourse)
        {
            try
            {
                if (objCourse != null)
                {
                    int LastId = Context.lstCourse.Select(x => x.Id).LastOrDefault();
                    objCourse.Id = LastId++;
                    Context.lstCourse.Add(objCourse);
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
