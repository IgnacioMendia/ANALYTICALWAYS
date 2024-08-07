using DataAccess;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANALYTICALWAYS.Controller
{
    public class StudentController
    {
		PaymentGatewayController _paymentGateway = new PaymentGatewayController();
        public string RegisterStudent(Student objStudent)
        {
			try
			{
				if (objStudent != null)
				{
					if (objStudent.Age >= 18)
					{
						int LastId = Context.lstStudent.Select(x => x.Id).LastOrDefault();
						objStudent.Id = LastId++;
                        Context.lstStudent.Add(objStudent);
						return "El estudiante fue creado con exito.";
                    }
					else
					{
                        return "El estudiante es menor de 18 años, por lo que no puede ser creado.";
                    }
                }
				else 
				{ 
					return "Faltan datos requeridos para poder crear al estudiante."; 
				}
			}
			catch (Exception)
			{
				throw;
			}
        }
		public string RegisterStudentInCourse(int idStudent, int IdCourse)
		{
			try
			{
				if (idStudent != 0 && IdCourse != 0)
				{
					if (_paymentGateway.PaymentStudent() == true)
					{
                        int LastId = Context.lstStudentCourse.Select(x => x.Id).LastOrDefault();
                        StudentCourse studentCourse = new StudentCourse() {Id = LastId++, IdStudent = idStudent, IdCourse = IdCourse};
                        Context.lstStudentCourse.Add(studentCourse);
                        return "El estudiante fue inscripto en el curso.";
                    }
					else
					{
                        return "El pago no pudo ser procesado.";
                    }
				}
				else 
				{
					return "El estudiante no pudo ser inscripto por falta de datos.";
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
    }
}
