using CreditSuisse.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisse.Entities.Categorize
{
    public class CategorizeFactory
    {
        public static ICategorize CreateCategorize(CategorizeEnum categorize)
        {
            switch (categorize)
            {
                case CategorizeEnum.Defaulted:
                    return new DefaultedCategorize();

                case CategorizeEnum.HighRisk:
                    return new HighRiskCategorize();

                case CategorizeEnum.MediumRisk:
                    return new MediumRiskCategorize();

                default:
                    throw new ApplicationException("Categoria não conhecida");
            }
        }
    }
}
