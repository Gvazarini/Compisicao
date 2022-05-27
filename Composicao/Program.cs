using System;
using Composicao.Entities.Enuns;
using Composicao.Entities;
using System.Globalization;
using System.Collections.Generic;
namespace Composicao
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.Write("Insert department`s name: ");
            string depName = Console.ReadLine();
            Console.Write("Enter worker`s data: ");
            Console.Write("Name: ");
            string workName = Console.ReadLine();
            Console.Write("Level: (Junior/Mid Lavel/Sebior) ");
            WorkerLevel lvl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double bSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Deparment dept = new Deparment(depName);
            Worker woker = new Worker(workName, lvl, bSalary, dept);
            Console.Write("How many contracts does this worker has?");
            int ncontracts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ncontracts; i++)
            {
                Console.WriteLine($"Values of the #{i} Contract: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Ammount os hours: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hours);
                woker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter now, month and year to calculate the income: ");
            string monthNyear = Console.ReadLine();
            int month = int.Parse(monthNyear.Substring(0, 2));
            int year = int.Parse(monthNyear.Substring(3));
            Console.WriteLine("Name: " + woker.Name);
            Console.WriteLine("Department: " + woker.Department.Name );
            Console.WriteLine("Income for: " + monthNyear + ": " + woker.Income(year, month));

        }

        
    }
}
