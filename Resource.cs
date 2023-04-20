using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Resource
{
    public string Code { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Publisher { get; set; }
    public DateTime pubDate { get; set; }


    public void printResourceHistory()
    {
        Console.WriteLine("Code : " + Code);
        Console.WriteLine("Title : " + Title);
        Console.WriteLine("Description : " + Description);
        Console.WriteLine("Publisher : " + Publisher);
        Console.WriteLine("Date of publishing : " + pubDate);

    }
}
