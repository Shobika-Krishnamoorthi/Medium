using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_details
{
    class Employee_Promotion
    {
        static void Main(string[] args)
        {
            int checker;
            int sample = 0;
            IDictionary<int, Tuple<string, int, double>> Employees = new Dictionary<int, Tuple<string, int, double>>();
            Employee emp = new Employee();

            //1.Entering the employee details and find the details using employee id

            Reenter_details:
            try
            {
                do
                {
                    emp.TakeEmployeeDetailsFromUser();
                    Employees.Add(emp.Id, Tuple.Create(emp.Name, emp.Age, emp.Salary));
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    checker = Convert.ToInt32(Console.ReadLine());
                } while (checker == 1);
            }
            catch(Exception)
            {
                Console.WriteLine("Id already exists!!,Reenter the details with different id");
                sample = 1;
            }
            if(sample==1)
            {
                sample = sample + 1;
                goto Reenter_details;
            }

            PrintEmployee();

            void PrintEmployee()
            {
                Console.WriteLine("Please enter the employee ID");
                int identityno = Convert.ToInt32(Console.ReadLine());
                if (Employees.ContainsKey(identityno))
                {
                    foreach (var empp in Employees)
                    {
                        if (empp.Key == identityno)
                        {
                            Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", empp.Key, empp.Value.Item1, empp.Value.Item2, empp.Value.Item3);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Id is invalid");
                    PrintEmployee();
                }
            }

            //void SortAndPrintEmployees()
            //{
            //    Console.WriteLine("The Sorted employee list");
            //    foreach (var empp in Employees.OrderBy(key => key.Value.Item3))
            //    {
            //        Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", empp.Key, empp.Value.Item1, empp.Value.Item2, empp.Value.Item3);
            //        Console.WriteLine("----------------------------------------");
            //    }
            //}


            //2. Entering the employee details,Sorting and printing the employee details

            //SortAndPrintEmployees();
            //PrintEmployee();


            //3.Entering the employee details,sorting and Finding the employee details using employee name

            //string ename;
            //SortAndPrintEmployees();
            //Console.WriteLine("Please enter the employee name");
            //ename = Console.ReadLine();
            //foreach (var empp in Employees)
            //{
            //    if (empp.Value.Item1 == ename)
            //    {
            //        Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", empp.Key, empp.Value.Item1, empp.Value.Item2, empp.Value.Item3);
            //    }
            //}




            //4.Entering the details and finding the employee who are elder than the given employee id

            //int age_checker;
            //var c_age = 0;
            //Console.WriteLine("Please enter the employee ID");
            //age_checker = Convert.ToInt32(Console.ReadLine());
            //foreach (var empp in Employees)
            //{
            //    if (empp.Key == age_checker)
            //    {
            //        c_age = empp.Value.Item2;
            //    }
            //}

            //foreach (var empp in Employees)
            //{
            //    if (c_age < empp.Value.Item2)
            //    {
            //        Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", empp.Key, empp.Value.Item1, empp.Value.Item2, empp.Value.Item3);
            //    }
            //}



            Console.ReadKey();
        }
    }
}
