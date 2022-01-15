using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> db = new List<Student>();
            while (true)
            {

                menu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddStudent(ref db);
                        break;
                    case "2":
                        EditStudent(ref db);
                        break;
                    case "3":
                        DeleteStudents(ref db);
                        break;
                    case "4":
                        PrintStudents(db);

                        break;
                    case "5":
                        return;


                    default:
                        Console.WriteLine("Input Invalid Try Again");
                        Console.ReadKey();
                        break;
                }
            }

        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("1)Add Student");
            Console.WriteLine("2)Edit Student");
            Console.WriteLine("3)Delete Student");
            Console.WriteLine("4)Print Student");
            Console.WriteLine("5)Exit");
        }
        static void AddStudent(ref List<Student> data)
        {
            Console.Clear();
            Console.WriteLine("Add Student Page");
            Console.WriteLine("*******************************");
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(name, surname, age);
            data.Add(student);
            Console.WriteLine("Student Added!!!");
            Console.ReadKey();
        }

        static void PrintStudents(List<Student> data)
        {

            Console.Clear();
            Console.WriteLine("Print Student Page");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine("Name               Surname          Age");
            foreach (Student item in data)
            {
                if (item.Exist)
                {
                    Console.WriteLine();
                    Console.WriteLine(item.Name + "                  " + item.Surname + "                 " + item.Age);
                }
            }
            Console.ReadKey();
        }


        static void EditStudent(ref List<Student> data)
        {
            Console.Clear();
            Console.WriteLine("Edit Student Page");
            Console.WriteLine("*******************************");
            Console.WriteLine("Enter Surname");
            string search = Console.ReadLine();
            int index = Find(data, search);
            if (index!=-1 && data[index].Exist)
            {
                Console.WriteLine("Enter New Name");
                data[index].Name = Console.ReadLine();

                Console.WriteLine("Enter New Surname");
                data[index].Surname = Console.ReadLine();

                Console.WriteLine("Enter New Age");
                data[index].Age =Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Student Updated");

            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
            Console.ReadKey();
        }

        static void DeleteStudents(ref 
            List<Student> data)
        {

            Console.Clear();
            Console.WriteLine("Print Student Page");
            Console.WriteLine("*******************************");
            Console.WriteLine("Enter Surname");
            string search = Console.ReadLine();
            int index = Find(data, search);
            if (index != -1 && data[index].Exist)
            {
                data[index].Deactive();
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

            static int Find(List<Student> data,string surname)
        {
            int index = -1;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Surname==surname)
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
