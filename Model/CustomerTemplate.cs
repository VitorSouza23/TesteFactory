using System;

namespace TesteFactory.Model
{
    public class CustomerTemplate : ICustomer
    {
        public CustomerTemplate()
        {
            Name = "Nome padrão";
            BirthDate = Customer.MinBithDate.AddDays(1);
            CPF = "000.000.000-00";
            Email = string.Empty;
            Age = 0;
        }
        
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public int Age { get; set; }
    }
}