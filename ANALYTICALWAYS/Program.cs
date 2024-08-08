using ANALYTICALWAYS.Controller;
using ANALYTICALWAYS.Interface;
using DataAccess;
using DataAccess.Model;

IContext context = new Context();
while (true)
{
    Console.Clear();
    Console.WriteLine("Menú Principal");
    Console.WriteLine("1- Crear estudiante");
    Console.WriteLine("2- Crear curso");
    Console.WriteLine("3- Registrar estudiante en curso");
    Console.WriteLine("4- Salir");
    Console.Write("Seleccione una opción: ");

    switch (Console.ReadLine())
    {
        case "1":
            CreateStudent(context);
            break;
        case "2":
            CreateCourse(context);
            break;
        case "3":
            RegisterStudentInCourse(context);
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;

    }
}

static void CreateStudent(IContext context)
{
    Console.Clear();
    Console.WriteLine("Crear Estudiante");

    Console.Write("Nombre: ");
    string name = Console.ReadLine();

    Console.Write("Edad: ");
    if (int.TryParse(Console.ReadLine(), out int age))
    {
        Student objStudent = new Student() { Name= name, Age = age };
        StudentController objStudentController = new StudentController(context);
        string Response = objStudentController.RegisterStudent(objStudent);
        Console.WriteLine(Response);
    }
    else
    {
        Console.WriteLine("Edad no válida");
    }
    Console.ReadKey();
}

static void CreateCourse(IContext context)
{
    Console.Clear();
    Console.WriteLine("Crear Curso");

    Console.Write("Nombre: ");
    string name = Console.ReadLine();

    Console.Write("Tarifa de inscripción: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal fee))
    {
        Console.Write("Fecha de inicio (yyyy-mm-dd): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
        {
            Console.Write("Fecha de fin (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                Course objCourse = new Course()
                {
                    Name = name,
                    RegistrationFee = fee,
                    StartDate = startDate,
                    EndDate = endDate
                };
                CourseController objCourseController = new CourseController(context);
                string Response = objCourseController.RegisterCourse(objCourse);
                Console.WriteLine(Response);
            }
            else
            {
                Console.WriteLine("Fecha de fin no válida. Presione cualquier tecla para continuar...");
            }
        }
        else
        {
            Console.WriteLine("Fecha de inicio no válida. Presione cualquier tecla para continuar...");
        }
    }
    else
    {
        Console.WriteLine("Tarifa de inscripción no válida. Presione cualquier tecla para continuar...");
    }
    Console.ReadKey();
}

static void RegisterStudentInCourse(IContext context)
{
    Console.Clear();
    Console.WriteLine("Registrar Estudiante en Curso");

    Console.Write("ID del estudiante: ");
    if (int.TryParse(Console.ReadLine(), out int studentId))
    {
        Console.Write("ID del curso: ");
        if (int.TryParse(Console.ReadLine(), out int courseId))
        {
            StudentController objStudentController = new StudentController(context);
            string Response = objStudentController.RegisterStudentInCourse(studentId, courseId);
            Console.WriteLine(Response);
        }
        else
        {
            Console.WriteLine("ID de curso no válido. Presione cualquier tecla para continuar...");
        }
    }
    else
    {
        Console.WriteLine("ID de estudiante no válido. Presione cualquier tecla para continuar...");
    }
    Console.ReadKey();
}