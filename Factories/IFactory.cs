using System;

namespace TesteFactory.Factories
{
    public interface IFactory<TEntity, TTemplate>
    {
        TEntity Create();
        void FillData(Action<TTemplate> fillDataFunction);
    }
}