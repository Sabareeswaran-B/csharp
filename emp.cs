using System;
namespace EmployeeExample
{
    public abstract class Emp
    {
        public abstract string getEmpName();
        public abstract int getEmpSalary(); 
    }

    public class Employee : Emp
    {
        public string name {get; set;}
        public int salary {get; set;}

        public Employee(string name, int salary){
            this.name = name;

            this.salary = salary;
        }
        public override string getEmpName()
        {
            return name;
        }
<<<<<<< HEAD
    //Changed by Tamizharivu
=======

        //This is the change from Kanishkar
        //EMP version 1
        // SALARY v2
        //This is the change
>>>>>>> 12735939f776c7ea5bc3570726066299af975093
        public override int getEmpSalary()
        {
            return salary;
        }
    }

    // public class MainEmployee
    // {
    //     public static void Main(){
    //         Employee objEmp = new Employee("Kanishkar", 50000);
    //         Console.WriteLine("The name of the employee is: {0}", objEmp.getEmpName());
    //         Console.WriteLine("The salary of the employee is: {0}", objEmp.getEmpSalary());            
    //     }
    // }
}