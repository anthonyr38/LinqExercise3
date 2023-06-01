using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine();
            Console.WriteLine("Sum of numbers");

            var sumOfNums = numbers.Sum();

            Console.WriteLine(sumOfNums);
            Console.WriteLine();

            //TODO: Print the Average of numbers

            Console.WriteLine("Average of numbers");
            Console.WriteLine();
            var avgOfNums = numbers.Average();
            Console.WriteLine(avgOfNums);
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending order");
            Console.WriteLine();

            var ascNums = numbers.OrderBy(nums => nums).ToList();

            foreach (int nums in ascNums)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("Descending order");
            Console.WriteLine();

            var descendingNums = numbers.OrderByDescending(nums => nums).ToList();

            foreach (int nums in descendingNums)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Greater than 6");
            Console.WriteLine();

            var greaterNums = numbers.Where(nums => nums > 6).ToList();
            foreach (int nums in greaterNums)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Four Numbers");
            Console.WriteLine();

            var fourNums = numbers.Where(nums => (nums > 3) && (nums < 8)).ToList();

            foreach (int nums in fourNums)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            Console.WriteLine("Change index 4");
            Console.WriteLine();

            numbers[4] = 42;

            Console.WriteLine(numbers[4]);
            Console.WriteLine();

            foreach (int nums in numbers)
            { 
                Console.WriteLine(nums);


            }
                Console.WriteLine();
        
            ascNums = numbers.OrderBy(nums => nums).ToList();

            foreach (int nums in ascNums)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine();

            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            
            var empNamesSandC =
                employees.Where(emp1stNames => emp1stNames.FirstName.StartsWith('C') || emp1stNames.FirstName.StartsWith('S'))
                .OrderBy(emp1stNames => emp1stNames.FirstName).ToList();

            foreach (var emp1stNames in empNamesSandC) 
            {
                Console.WriteLine(emp1stNames.FullName);
            }
                Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var overAge26 = employees.Where(empAge => empAge.Age > 26).OrderBy(empAge => empAge.FirstName).
                OrderBy(empAge => empAge.Age).ToList();

            foreach(var empAge in overAge26) 
            {
                Console.WriteLine($"{empAge.Age} {empAge.FullName}");

            }
                Console.WriteLine();



            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            
            var sumAvgExp = employees.Where(empYOE => (empYOE.YearsOfExperience <= 10 && empYOE.Age  > 35)).ToList();

           
            
            Console.WriteLine($"{sumAvgExp.Sum(empYOE => empYOE.YearsOfExperience)}");
            Console.WriteLine();
            Console.WriteLine($"{sumAvgExp.Average(empYOE => empYOE.YearsOfExperience)}");
            Console.WriteLine();








            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Bart", "Simpson", 15, 2)).ToList();

            Console.WriteLine();

         
            foreach (var employee in employees) 
            {
                
                Console.WriteLine(employee.FullName, employee.Age, employee.YearsOfExperience);
                
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
