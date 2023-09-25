using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_one_oop
{
    internal class Employee
    {
        #region Fields
        public int id;
        public string name;
        public int age;
        public int salary;
        private int experinceYear = 3;
        #endregion

        #region defualt_constructor
        public Employee()
        {
            this.id = 1;
            this.name = "mohamed";
            this.age = 24;
            this.salary = 7500;
            this.experinceYear = 3;
        }
        #endregion

        #region parametrized_constructor
        public Employee(int id, string name, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;

        }
        #endregion

        #region copy_constructor
        public Employee(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;

        }
        #endregion

        #region Display Employee_Info
        public void EmpInfo()
        {
            Console.WriteLine($"you are Employee in our company with \n ID :- {this.id} \nName :- {this.name} \n age :- {this.age} \n Experince Years :- {this.experinceYear}\n Salary :- {this.salary} ");
        }
        #endregion

        #region bounce_expereince
        public void bounce_expereince() {
            double bounce_expereince;
            bounce_expereince = this.salary * 0.1;
            double salaryAfterBounce = this.salary + bounce_expereince;
            Console.WriteLine($"salaryAfterBounce:- {salaryAfterBounce} with {this.experinceYear} years of experince");

        }

        #endregion

        #region deepcopy_constructor
        public Employee(Employee e)
        {
            this.id = e.id;
            this.name = e.name;
            this.salary = e.salary;
            this.age = e.age;
        }
        #endregion

    }
}
