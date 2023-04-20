using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public abstract class User
{
    public int StudentId { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string address { get; set; }
    public string phone { get; set; }

    public void printBorrowingHistory()
    {

    }


    public bool sendReminder()
    {
        return true;
    }



}
