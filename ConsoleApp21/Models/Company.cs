using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Models
{
    internal class Company
    {
        private string _name;
        private Employee[] _employes;


        public Employee[] Empoyes;
        public Company(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ad teleb olunur");
            }
            this._name= name.ToUpper()[0]+name.Substring(1);
            _employes = new Employee[0];
        }

        public void AddUser(Employee employee)
        {
            Array.Resize(ref _employes, _employes.Length+1);
            _employes[_employes.Length-1] = employee;
            Console.WriteLine("Succesfull added!");
        }

        public void RemoveUser(Employee user)
        {
            int index=Array.IndexOf(_employes, user);
            if (index > 0)
            {
                for(int i=0;i<_employes.Length;i++)
                {
                    _employes[i] = _employes[i+1];
                }
                Array.Resize(ref _employes,_employes.Length-1);
                Console.WriteLine("Succesfully removed");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

        }
        //public Employee GetUser(string username)
        //{
        //    foreach(Employee emp in _employes)
        //    {
        //        if (_employes.Username == username)
        //        {
        //            return emp;
        //        }
        //    }
        //    return null;


        //}
        public void GetAllUser()
        {
            Console.WriteLine(_employes);
        }


        
        //public void UpdateUser(string username)
        //{
        //    foreach (Employee emp in _employes)
        //    {
        //        if (_employes.Username() == username)
        //        {
        //            return _employes;
        //        }
        //    }
        //    return null;
        //}

    }
    
}
