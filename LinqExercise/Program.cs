using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            
            var listSum = numbers.Sum();
            Console.WriteLine($"Sum: {listSum}");

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");

            var listAvg = numbers.Average();
            Console.WriteLine($"Average: {listAvg}");

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("Numbers in ascending order:");
            var numbersAscending = numbers.OrderBy(x => x).ToList();
            foreach(var num in numbersAscending)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");
            //TODO: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers in descending order:");
            var numbersDescending = numbers.OrderByDescending(x => x).ToList(); 
            foreach(var num in numbersDescending)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("Numbers greater than 6:");
            foreach(var num in numbers)
            {
                if(num > 6)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("First 4 numbers in ascending order:");
            var firstFour = numbers.OrderBy(x => x).Take(4);
            foreach(var num in firstFour)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");

            Console.WriteLine("New list after changing index 4 to value 26:");
            numbers[4] = 26;
            var newList = numbers.OrderByDescending(x => x);
            foreach(var num in newList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");

            var employees = CreateEmployees();


            Console.WriteLine("Employees with names starting with A, C or S:");

            var myEmployees = employees.Where(x => x.FirstName.StartsWith("A") || 
            x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S"));

            var sortedMyEmployees = myEmployees.OrderBy(x => x.FirstName);

            foreach(var employee in sortedMyEmployees)
            {
                Console.WriteLine($"{employee.FullName}");
            }

            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");


            Console.WriteLine("Employees over 26:");

            var employeesOver26 = employees.Where(x => x.Age > 26);
            var over26InOrder = employeesOver26.OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach( var employee in over26InOrder)
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}");
            }




            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
