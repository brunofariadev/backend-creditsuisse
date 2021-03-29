using CreditSuisse.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisse.Entities.Categorize
{
    public class MediumRiskCategorize : ICategorize
    {
        public CategorizeEnum Categorize(DateTime dateReference, ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "Public")
            {
                return CategorizeEnum.MediumRisk;
            }

            return 0;
        }
    }
}
