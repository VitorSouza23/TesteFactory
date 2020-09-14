using System;

namespace TesteFactory.Model
{
    public interface ICustomer
    {
        string Name { get; }
        DateTime BirthDate { get; }
        string Email { get; }
        string CPF { get; }
        int Age { get;}
    }
}