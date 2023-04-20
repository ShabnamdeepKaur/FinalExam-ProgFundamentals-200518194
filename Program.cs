namespace FinalExam_200518194;
class Program
{
    static void Main(string[] args)
    {
        //instance of standard class
        Standard standard=new Standard()
        {
            PostCode="L4M2R6",
            LibCardNo="200518194",
        };

        //instance of student class
        Student student = new Student()
        {
            refNo=001,
            StudentId = 200518194,
            Id = "1234",
            FName = "Shabnamdeep",
            LName="Kaur",
            
            phone="4375594448",
            address="319 Grove St East Barrie"
        };

        //instance1 for resource
        Resource res1 = new Resource()
        {
            Code = "M001234",
            Title = "Book",
            Description = "The Holy Homes",
            Publisher="BBC",
            pubDate=DateTime.MaxValue
        };

        //instance2 for resource
        Resource res2 = new Resource()
        {
            Code = "N001567",
            Title = "Novel",
            Description = "The Merchant Of Venice",
            Publisher="Om Publishers",
            pubDate=DateTime.MaxValue
        };

        List<Resource> resources = new List<Resource>();
        resources.Add(res1);
        resources.Add(res2);

        //instance of class Borrowing
        Borrowing borrow = new Borrowing(student.Id, resources);

        //============== student record ==========================
        Console.WriteLine("***************************** STUDENT HISTORY *****************************");
        student.printBorrowingHistory();
        standard.printBorrowingHistory();

        //============== resource record ==========================
        Console.WriteLine("***************************** RESOURCE1 RECORD *****************************");
        res1.printResourceHistory();
        Console.WriteLine("***************************** RESOURCE2 RECORD *****************************");
        res2.printResourceHistory();

        //===================================== access link ===================================================
        string access = borrow.GenerateAccessLink();
        Console.WriteLine("***************************** ACCESS LINK *****************************");
        Console.WriteLine("Access Link is " + access);

        //=========================== payment results ================================================
        Console.WriteLine("***************************** PAYMENT RESULTS *****************************");
        Console.WriteLine("Processed Payment : " + student.ProcessPayment());

        //======================== return date ====================================
        borrow.ReturnResources(DateTime.Today.AddDays(11));
        Console.WriteLine("***************************** PICKED UP *****************************");
        Console.WriteLine("Picked Up : " + borrow.pickedUp);


    }
}
