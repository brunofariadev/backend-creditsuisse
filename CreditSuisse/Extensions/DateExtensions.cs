using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CreditSuisse.Extensions
{
    public static class DateExtensions
    {
        public static DateTime ParseCultureEnUs(this string date)
        {
            return DateTime.Parse(date, new CultureInfo("en-US"));
        }
    }
}
