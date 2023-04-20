using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Standard : User, lBillable
{
    public string PostCode{ get; set; }
    public string LibCardNo{ get; set; }
    private string CreditCardno="12345678987654321";
    public bool ProcessPayment()
    {
        return true;
    }

    public void printBorrowingHistory()
    {
        Console.WriteLine("Student Postal Code : " + PostCode);
        Console.WriteLine("Student Library Card Number : " + LibCardNo);
        Console.WriteLine("Student Credit Card Number : " + CreditCardno);
    }
}