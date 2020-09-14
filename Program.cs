using System;
using TesteFactory.Model;
using TesteFactory.Validators;
using TesteFactory.Factories;
using Microsoft.Extensions.DependencyInjection;
using static System.Console;

namespace TesteFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Brincando com fabricas...");
            IServiceProvider services = new ServiceCollection()
                .AddTransient<IValidator<Customer>, CustomerValidator>()
                .AddTransient<IFactory<Customer, CustomerTemplate>, CustomerFactory>()
                .BuildServiceProvider();

            IFactory<Customer, CustomerTemplate> customerFactory = 
                services.GetService<IFactory<Customer, CustomerTemplate>>();

            customerFactory.FillData(c => {
                c.Name = "Teste";
                c.BirthDate = DateTime.Today.AddDays(-1);
                c.CPF = "052.034.000-08";
                c.Email = "teste@teste.com";
            });
            
            ICustomer customer = customerFactory.Create();
            WriteLine(customer.ToString());
            ReadKey();
        }
    }
}
