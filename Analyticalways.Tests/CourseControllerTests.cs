using ANALYTICALWAYS.Controller;
using ANALYTICALWAYS.Interface;
using DataAccess;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyticalways.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void RegisterCourse_ValidCourse_ShouldReturnSuccessMessage()
        {
            var course = new Course
            {
                Name = "Introduccion a la programacion",
                RegistrationFee = 1000,
                StartDate = new DateTime(2024, 9, 1),
                EndDate = new DateTime(2024, 12, 15)
            };

            IContext testContext = new Context();
            var courseController = new CourseController(testContext);

            var result = courseController.RegisterCourse(course);

            Assert.Equal("El curso fue creado con exito.", result);
            Assert.Contains(course, testContext.lstCourse);
        }

        [Fact]
        public void RegisterCourse_NullCourse_ShouldReturnErrorMessage()
        {
            IContext testContext = new Context();
            var courseController = new CourseController(testContext);

            var result = courseController.RegisterCourse(null);

            Assert.Equal("Faltan datos requeridos para poder crear el curso.", result);
        }
    }
}