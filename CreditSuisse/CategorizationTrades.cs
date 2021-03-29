using CreditSuisse.Entities.Categorize;
using CreditSuisse.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisse
{
    public class CategorizationTrades
    {
        public CategorizeEnum Categorization(DateTime dateReference, ITrade trade)
        {
            foreach (CategorizeEnum categoria in Enum.GetValues(typeof(CategorizeEnum)))
            {
                var categorize = CategorizeFactory.CreateCategorize(categoria);
                var categorizeType = categorize.Categorize(dateReference, trade);

                if (categorizeType > 0)
                {
                    return categorizeType;
                }
            }

            return 0;
        }
    }
}
