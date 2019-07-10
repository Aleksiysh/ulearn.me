using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIntegrity
{
    public class Student
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentException();
        }
    }

    class StudentTask
    {
        public static void Run()
        {
            WriteStudent();
        }
        private static void WriteStudent()
        {
            // ReadName считает неизвестно откуда имя очередного студента
            var student = new Student { Name = null };
            Console.WriteLine("student " + FormatStudent(student));
        }

        private static string FormatStudent(Student student)
        {
            return student.Name.ToUpper();
        }
    }
}
