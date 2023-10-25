using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Models
{
    internal class Employee
    {
        private string _name;
        private string _surname;
        private string _username;
        private byte _age;

        public Employee(string name, string surname, byte age)
        {
            name = name.ToUpper()[0] + name.Substring(1);
            surname = surname.ToUpper()[0] + surname.Substring(1);
            this._age = age;
            _username = name +" "+ surname;
            if (age < 1)
            {
                Console.WriteLine("Age 0 ve ya 0-dan kicik ola bilmez.");
            }
            else
            {
                this._age = age;
                
            }


        }
        public byte GetAge => _age;
        public string GetUsername => _username;


        
    }
   
}
