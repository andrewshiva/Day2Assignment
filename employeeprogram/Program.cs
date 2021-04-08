using System;
class Employee
{
    public string name;
    public string Designation;
    public int EmpNo;




    public Employee()
    {

    }

    public Employee(string name, string Designation, int EmpNo)
    {
        this.name = name;
        this.Designation = Designation;
        this.EmpNo = EmpNo;
    }

        //public Qualification(string UG, string PG, int Experience)
         //{
            //this.UG = UG;
            //this.PG = PG;
            //this.Experience = Experience;
        //}



public void GetEmployeeData()
{
    {
        Console.WriteLine("Enter the name of employee: ");
        name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the Designation of employee: ");
        Designation = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the EmpNo of employee: ");
        EmpNo = Convert.ToInt32(Console.ReadLine());
    }
}

public void DisplayEmployee()
{
    Console.WriteLine("The name of employee is: " + name);
    Console.WriteLine("The salary of employee is: " + Designation);
    Console.WriteLine("The date of  EmpNo of employee is: " + EmpNo);
}
    }
    class Program
{
    static void Main(string[] args)
    {
        Employee[] e = new Employee[10];
        for (int i = 0; i < 10; i++)
        {

            e[i] = new Employee();
            e[i].GetEmployeeData();
        }



        for (int i = 0; i < 10; i++)
        {
            e[i].DisplayEmployee();
        }
    }
}

