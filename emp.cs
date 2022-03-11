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
        // My name is vishnuprashob git
        public override string getEmpName()
        {
            return name;
        }
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