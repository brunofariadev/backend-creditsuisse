using CreditSuisse.Enumerators;
using System;

namespace CreditSuisse.Entities.Categorize
{
    public class HighRiskCategorize : ICategorize
    {
        public CategorizeEnum Categorize(DateTime dateReference, ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Private")
            {
                return CategorizeEnum.HighRisk;
            }

            return 0;
        }
    }
}
