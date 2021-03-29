﻿using CreditSuisse.Entities.Categorize;
using System;

namespace CreditSuisse.Entities
{
    public class Trade : ITrade
    {
        public double Value { get; private set; }

        public string ClientSector { get; private set; }

        public DateTime NextPaymentDate { get; private set; }
        
        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }
    }
}
