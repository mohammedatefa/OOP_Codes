namespace day_one_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 6 employees instances 
            Employee[] employees = new Employee[5];


            #region first_employee
            employees[0]=new Employee(1,"Ahmed",24,8500);
            #endregion

            #region second_employee using normal way
            //second Employee with deep copy
            //employees[1] = new Employee();

            //employees[1].id = employees[0].id;
            //employees[1].name = employees[0].name;
            //employees[1].age = employees[0].age;
            //employees[1].salary = employees[0].salary;

            #endregion

            #region second_employee using copy_constructor way

            employees[1] = new Employee(employees[0]);

            #endregion

            #region third and fourth employee
            employees[2] = new Employee(3, "ali", 26, 9500);
            employees[3] = new Employee(4, "omar", 26, 6500);
            #endregion

            #region fifth employee a reference to the fourth employee (no copy constructor needed)

            employees[4] = employees[3];

            #endregion

            #region sixth_employee
            employees[5] = new Employee(5, "ayman", 22, 4300);
            #endregion


            #endregion


            #region dispaly_employees
            for (int i = 0; i <= employees.Length; i++)
            {
                Console.WriteLine($"Employee number {employees[i]}:");
                employees[i].EmpInfo();
                Console.WriteLine();
            }
            #endregion

        }
    }
}