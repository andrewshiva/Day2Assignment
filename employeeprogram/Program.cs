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
        Console.WriteLine("The  is: " + UG);
        Console.WriteLine("The is: " + PG);
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
        Qualification myclass = new Qualification();
        myclass.name = "jason";
        myclass.Designation = "Associate Developer";
        myclass.UG = "B.tech";
        myclass.PG = "M.tech";
        //myclass.Experience = "Fresher";

        Console.WriteLine("The name of employee is: " + myclass.name);
        Console.WriteLine("The Designation of employee is: " +  myclass.Designation);
        Console.WriteLine("Enter  EmpNo of employee is: " + myclass. EmpNo);
        Console.WriteLine("The  UG degree  of employee is: " +  myclass.UG);
        Console.WriteLine("The PG degree of employee is: " +  myclass.PG);
        //Console.WriteLine("The Experience) of employee is: " +  myclass.Experience);
        Console.ReadLine();
     }
}







