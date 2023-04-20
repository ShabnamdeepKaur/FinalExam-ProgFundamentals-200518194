using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Student : User, lBillable
{
    public int refNo { get; set; }
    public int StudentId{ get; set; }
    public string Id { get; set; }
    public string FName{ get; set; }
    public string LName{ get; set; }
    public string address{ get; set; }
    public string phone{ get; set; }

    private DateTime DOB=DateTime.Today;

    public bool ProcessPayment()
    {
        return true;
    }


    public void printBorrowingHistory()
    {
        Console.WriteLine("Student Id : " + StudentId);
        Console.WriteLine("Student First Name : " + FName);
        Console.WriteLine("Student Last Name : " + LName);
        Console.WriteLine("Student Address : " + address);
        Console.WriteLine("Student Phone Number : " + phone);
        Console.WriteLine("Student Date of birth : " + DOB);

    }

}