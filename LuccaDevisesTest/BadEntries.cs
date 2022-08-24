using System.Collections.Generic;

namespace LuccaDevisesTest
{
    public static class BadEntries
    {
        public static List<string> EmptyLines = new List<string>();
        public static List<string> PartialLines = new List<string>
        {
            "test"
        };

        public const string CurrencyKo1 = "";
        public const string CurrencyKo2 = "EU";
        public const string CurrencyKo3 = "EUROS";

        public const string IntegerKo1 = "";
        public const string IntegerKo2 = "1,1";
        public const string IntegerKo3 = "1.1";
        public const string IntegerKo4 = "test";

        public const string RateKo1 = "";
        public const string RateKo2 = "test";

        public const string OtherLineKO1 = ";CHF; 0.9661";
        public const string OtherLineKO2 = "EU;CHFX; 0.9661";
        public const string OtherLineKO3 = "EURX;CHF; 0.9661";
        public const string OtherLineKO4 = "EUR;; 0.9661";
        public const string OtherLineKO5 = "EUR;CH; 0.9661";
        public const string OtherLineKO6 = "EUR;CHF; ";
        public const string OtherLineKO7 = "EUR;CHF; 0.9661";
        public const string OtherLineKO8 = "EUR ;CHF; 0.9661";
        public const string OtherLineKO9 = "EUR; CHF; 0.9661";

        public static List<string> Currency1 = new List<string>
        {
            "USDX;5012;EUR",
            "3",
            "EUR;CHF;60.1046",
            "USD;CHF;0.9946",
            "RON;CHF;0.2322"
        };

        public static List<string> Currency2 = new List<string>
        {
            "USD;5012;EURX",
            "3",
            "EUR;CHF;60.1046",
            "USD;CHF;0.9946",
            "RON;CHF;0.2322"
        };

        public static List<string> Currency3 = new List<string>
        {
            "USD;5012;EUR",
            "3",
            "EURX;CHF;60.1046",
            "USD;CHF;0.9946",
            "RON;CHF;0.2322"
        };

        public static List<string> Currency4 = new List<string>
        {
            "USD;5012;EUR",
            "3",
            "EUR;CHFX;60.1046",
            "USD;CHF;0.9946",
            "RON;CHF;0.2322"
        };
    }
}
