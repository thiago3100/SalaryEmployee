using System.Collections.Generic;
using System.Globalization;
namespace Listas
{
    public class Program
    {
        static void Main(string[] args)
        {

          List<Funcionario> list = new List<Funcionario>();  

          Console.Write("How many employees will be registered?: ");
          int n = int.Parse(Console.ReadLine());

          for(int i = 0; i < n; i++)
          {
            Console.WriteLine($"Employee # {i}: ");
            
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            

            Console.Write("Name: ");
            string name = Console.ReadLine();
            

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            list.Add(new Funcionario(id, name, salary));

            Console.WriteLine();

          }

          System.Console.Write("Enter the employee id that will have salary increase : ");
          int dig = int.Parse(Console.ReadLine());
          
          Funcionario func = list.Find(x => x.Id == dig);
          if(func != null)
          {
            Console.WriteLine("Enter the percentage: ");
            double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.IncreaseSalary(porcentage);
          }
          else {
                Console.WriteLine("This id does not exist!");
            }
         
          Console.WriteLine();
          Console.WriteLine("Update list of employees :");

          foreach(Funcionario emp in list)
          {
            Console.WriteLine(emp);
          }
        }
    }
}
