using System;

namespace TesteFactory.Model
{
    public class Customer
    {
        private Customer(string name, DateTime birthDate, string email, string cpf)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
            CPF = cpf;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public int Age => DateTime.Today.Year - BirthDate.Year;

        public static Customer Factory(string name, DateTime birthDate, string cpf, string emai = "")
        {
            return new Customer(name, birthDate, emai, cpf);
        }

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