using ConsoleApp21.Models;
using System.Reflection;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("melek", "azizova", 21);
            Company company = new Company("AZAL");
            
            Console.WriteLine($"Username: {employee.GetUsername}");
            Console.WriteLine($"User age: {employee.GetAge}");
            Console.WriteLine(company.AddUser);

            //Console.WriteLine("Istifadeci adini daxil edin: ");
            //string usernameToUpdate = Console.ReadLine();
            //company.UpdateUser(usernameToUpdate);















        }
    }
}