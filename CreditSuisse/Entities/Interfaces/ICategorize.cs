using CreditSuisse.Enumerators;
using System;

namespace CreditSuisse.Entities.Categorize
{
    public interface ICategorize
    {
        CategorizeEnum Categorize(DateTime dateReference, ITrade trade);
    }
}
