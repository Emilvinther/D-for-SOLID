using D_for_SOLID;
using System.Collections;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        
        // Input and Objects

        RequestResult rr = new RequestResult();
        WebRequestHandler wr = new WebRequestHandler();
        FileRequestHandler frh = new FileRequestHandler();
        Console.WriteLine(rr.Results("test.txt", frh));
        Console.WriteLine(rr.Results("https://jsonplaceholder.typicode.com/todos/1", wr));
        



        Console.ReadKey();
    } 

    
}
