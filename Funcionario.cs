using System.Globalization;
namespace Listas
{
    public class Funcionario
    {
        public int Id{get; private set;}
        public string Name{get; private set;}
        public double Salary{get; private set;}

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentage)
        {
            Salary += Salary * porcentage / 100.0;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}