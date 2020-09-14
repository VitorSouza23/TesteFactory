using System;
using TesteFactory.Model;
using static System.Console;

namespace TesteFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Brincando com fabricas...");
            Customer customer = Customer.Factory("Teste", new DateTime(1995, 1, 1), 
            "052.034.000-08", "teste@teste.com");
            WriteLine(customer.ToString());
            ReadKey();
        }
    }
}
