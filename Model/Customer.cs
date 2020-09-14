using System;

namespace TesteFactory.Model
{
    public class Customer : ICustomer
    {
        public static readonly DateTime MinBithDate = new DateTime(1960, 1, 1);
        public Customer(string name, DateTime birthDate, string cpf, string email = "")
        {
            Name = name;
            BirthDate = birthDate;
            CPF = cpf;
            Email = email;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public int Age => DateTime.Today.Year - BirthDate.Year;


        public override string ToString()
        {
            return $@"
            Nome: {Name}
            Data de nasc.: {(BirthDate.ToString("dd/MM/yyyy"))}
            CPF: {CPF}
            Idade: {Age}
            {(string.IsNullOrWhiteSpace(Email) ? string.Empty : $"Email: {Email}")}";
        }
    }
}