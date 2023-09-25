using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_three
{
    public class Person
    {
        public int Id;
        public string Name;
    }

    public class Emloyee:Person
    {
        protected int _age;
        protected string _certification;

        public string title;
        internal int Phone;
        protected internal string Adress;

       public void shoData()
        {
            Console.WriteLine($"the name is {Name} and its age is {_age} he is live in {Adress}");
        }

    }
    public class manger:Emloyee
    {
        
    } 
}
