using System;
using System.Collections.Generic;

namespace TesteFactory.Validators
{
    public interface IValidator<T>
    {
        bool IsValid(T entity, out IEnumerable<object> errors);
    }
}