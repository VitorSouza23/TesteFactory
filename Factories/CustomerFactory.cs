using System;
using System.Collections.Generic;
using TesteFactory.Model;
using TesteFactory.Validators;
using System.Linq;

namespace TesteFactory.Factories 
{
    public class CustomerFactory : IFactory<Customer, CustomerTemplate>
    {
        private IValidator<Customer> _validator;
        private CustomerTemplate _customerTemplate;

        public CustomerFactory(IValidator<Customer> validator)
        {
            _validator = validator;
            _customerTemplate = new CustomerTemplate();
        }

        public Customer Create()
        {
            Customer customer = new Customer(_customerTemplate.Name, _customerTemplate.BirthDate, _customerTemplate.CPF, 
            _customerTemplate.Email);
            if(_validator.IsValid(customer, out IEnumerable<object> errors))
            {
                return customer;
            }
            throw new Exception($"Não foi possível criar o cliente. Detalhes: {errors.Aggregate((message, e) => message += " " + e.ToString())}");
        }

        public void FillData(Action<CustomerTemplate> fillDataFunction)
        {
            fillDataFunction(_customerTemplate);
        }
    }
}