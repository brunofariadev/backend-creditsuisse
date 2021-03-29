using CreditSuisse.Enumerators;
using System;

namespace CreditSuisse.Entities.Categorize
{
    public class DefaultedCategorize : ICategorize
    {
        int delayOfDays = 30;

        public CategorizeEnum Categorize(DateTime dateReference, ITrade trade)
        {
            if ((dateReference - trade.NextPaymentDate).TotalDays > delayOfDays)
            {
                return CategorizeEnum.Defaulted;
            }

            return 0;
        }
    }
}
