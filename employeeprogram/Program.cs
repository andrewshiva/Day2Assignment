using System;
class Employee
{
    public string name;
    public string Designation;
    public int EmpNo;

    public void DisplayEmployee()
    {
        Console.WriteLine("The name of employee is: " + name);
        Console.WriteLine("The salary of employee is: " + Designation);
        Console.WriteLine("The date of  EmpNo of employee is: " + EmpNo);
    }
}
class Qualification:Employee 
{
    public string UG;
    public string PG;
    public int Experience;
    public void DisplayQualification()
   {
        Console.WriteLine("The name of employee is: " + UG);
        Console.WriteLine("The salary of employee is: " + PG);
        Console.WriteLine("The date of  EmpNo of employee is: " + Experience);
    }
}
class Salary : Qualification
{
    float salary;
    public void Displaysalary()
    {
        Console.WriteLine("input your salary:"+salary);
    }
    public static void Main (string [] args)
    {
        Salary myclass = new Salary();
        myclass.name = "jason";
        myclass.Designation = "Associate Developer";
        myclass.UG = "B.tech";

        Console.WriteLine("The name of employee is: " + Employee.name);
        //Console.WriteLine("The Designation of employee is: " + Designation);
        //Console.WriteLine("The date of  EmpNo of employee is: " + EmpNo);
        //Console.WriteLine("The  UG degree  of employee is: " + UG);
        //Console.WriteLine("The PG degree of employee is: " + PG);
        //Console.WriteLine("The Experience) of employee is: " + Experience);
        Console.ReadLine();
     }
}







