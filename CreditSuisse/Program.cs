using CreditSuisse.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using CreditSuisse.Extensions;

namespace CreditSuisse
{
    class Program
    {
        static void Main(string[] args)
        {
            Client();
            Console.ReadKey();
        }

        private static void Client()
        {
            Console.WriteLine("N lines with the category of each one of the n trades.");
            
            DateTime dateReference = InputReferenceDate();

            int numberOfTrade = InputNumberTrades();

            List<Trade> trades = InputTrades(numberOfTrade);

            CategorizationTrades categorizationTrades = new CategorizationTrades();

            foreach (var trade in trades)
            {
                Console.WriteLine(categorizationTrades.Categorization(dateReference, trade));
            }
        }

        private static DateTime InputReferenceDate()
        {
            Console.Write("Reference date: ");
            var dateReference = Console.ReadLine().ParseCultureEnUs();
            return dateReference;
        }

        private static int InputNumberTrades()
        {
            Console.Write("Number of trades in the portfolio: ");
            var numberOfTrade = int.Parse(Console.ReadLine());
            return numberOfTrade;
        }

        private static List<Trade> InputTrades(int numberOfTrade)
        {
            Console.WriteLine(@$"Insert {numberOfTrade} trades in the portfolio with the example: 
[Trade amount] [Client`s sector] [Date that represents the next pending payment.]");

            List<Trade> trades = GetTrades(numberOfTrade);
            return trades;
        }

        private static List<Trade> GetTrades(int numberOfTrade)
        {
            var trades = new List<Trade>();

            for (int i = 0; i < numberOfTrade; i++)
            {
                Console.Write($"Trade {i + 1}: ");
                var inputTrade = Console.ReadLine();
                var tradeInfos = inputTrade.Split(" ");
                var trade = new Trade(
                    double.Parse(tradeInfos[0]),
                    tradeInfos[1],
                    tradeInfos[2].ParseCultureEnUs());

                trades.Add(trade);
            }

            return trades;
        }
    }
}
