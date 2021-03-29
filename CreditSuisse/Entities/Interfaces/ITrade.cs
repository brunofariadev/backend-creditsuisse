using System;
using System.Collections.Generic;
using System.Text;

namespace CreditSuisse.Entities.Categorize
{
    public interface ITrade
    {
        double Value { get; } 
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
    }
}
