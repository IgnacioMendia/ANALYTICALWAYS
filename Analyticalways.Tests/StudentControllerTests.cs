using ANALYTICALWAYS.Controller;
using ANALYTICALWAYS.Interface;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using DataAccess;

namespace Analyticalways.Tests
{
    public class StudentControllerTests
    {
        [Fact]
        public void RegisterStudent_ValidStudent_ShouldReturnSuccessMessage()
        {
            var student = new Student
            {
                Name = "Martin Garcia",
                Age = 20
            };

            IContext testContext = new Context();
            var studentController = new StudentController(testContext);

            var result = studentController.RegisterStudent(student);

            Assert.Equal("El estudiante fue creado con exito.", result);
            Assert.Contains(student, testContext.lstStudent);
        }

        [Fact]
        public void RegisterStudent_StudentUnderage_ShouldReturnErrorMessage()
        {
            var student = new Student
            {
                Name = "Marta Gimenez",
                Age = 17
            };

            IContext testContext = new Context();
            var studentController = new StudentController(testContext);

            var result = studentController.RegisterStudent(student);

            Assert.Equal("El estudiante es menor de 18 años, por lo que no puede ser creado.", result);
            Assert.DoesNotContain(student, testContext.lstStudent);
        }

        [Fact]
        public void RegisterStudent_NullStudent_ShouldReturnErrorMessage()
        {
            IContext testContext = new Context();
            var studentController = new StudentController(testContext);

            var result = studentController.RegisterStudent(null);

            Assert.Equal("Faltan datos requeridos para poder crear al estudiante.", result);
        }
    }
}
