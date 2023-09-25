namespace day_two_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("mohamed", "manager", "minia", 123654789, 6000);
            Employee emp2 = new Employee("mohamed", "manager", "minia", 123654789, 6000);
            Employee emp3 = new Employee("mohamed", "manager", "minia", 123654789, 6000);
            Employee emp4 = new Employee("mohamed", "manager", "minia", 123654789, 6000);

            Employee.displayCountEmployee();

        }
       
    
    }
    public class Employee
    {
        #region Fields
        public string Name;
        public string Address;
        public int NID;
        public string Title;
        public static string DepartmentName;
        public static int Count;
        #endregion

        #region constructors
        //static constructor
         static Employee()
        {
            DepartmentName = ".Net";
            Count = 0;
        }
        //constructor used to initialized all data of hte class
        public Employee(string name,string title,string adress,int nid,int salary)
        {
            this.Name = name;
            this.Title = title;
            this.Address = adress;
            this.salary = salary;
            this.NID = nid;

            Count++;
        }

        //constructor to initial only name and the salary
        public Employee(string name,int nid):this(name,"maanger","minia",nid,5000)
        {
            
        }
        #endregion

        #region property
        private int salary;

        public int Salary
        {
            get
            {

                return salary;
            }
            set
            {
                if (salary > 5000)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("you enter salary less than 5000");
                    salary = 5000;
                }

            }
        }

        #endregion

        public static void displayCountEmployee()
        {
            Console.WriteLine($"the total number of the emplyee:- {Count} ");
        }
    }
}