using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Borrowing : lDownloadable
{
    public List<Resource> res;
    public string Id;
    public DateTime startDate;
    public DateTime endDate;
    public bool pickedUp;

    //================== constructor ========================
    public Borrowing(string Id, List<Resource> res)
    {
        this.Id = Id;
        this.res = res;
        startDate = DateTime.Today;
        endDate = DateTime.Today.AddDays(10);
        pickedUp = false;

    }
    public string GenerateAccessLink()
    {
        return "https://library.georgiancollege.ca/welcome-online";
    }

    public void ReturnResources(DateTime retDate)
    {
        if (retDate > endDate)
        {
            Console.WriteLine("User must pay fine");
        }
        else
        {
            Console.WriteLine("Thank You");
        }

        pickedUp = true;
    }
}
