using System;
using System.Collections.Generic;
using System.Text;

namespace LuccaDevisesTest
{
    public static class GoodEntries
    {
        public const string GivenExempleFirstLine = "EUR;550;JPY";

        public const string GivenExempleSecondLine = "6";

        public const string OtherLineOK = "EUR;CHF; 0.9661";

        public const string CurrencyOk = "EUR";

        public const string IntegrerOk = "1";

        public const string RateOk1 = "1";
        public const string RateOk2 = "1.1";
        public const string RateOk3 = "1.01";
        public const string RateOk4 = "1.001";
        public const string RateOk5 = "1.0001";

        public static List<string> GivenExempleOthersLine = new List<string>
        {
            "AUD;CHF;0.9661",
            "JPY;KRW;13.1151",
            "EUR;CHF;1.2053",
            "AUD;JPY;86.0305",
            "EUR;USD;1.2989",
            "JPY;INR;0.6571"
        };

        public static List<string> GivenExemple = new List<string>
        {
            "EUR;550;JPY",
            "6",
            "AUD;CHF;0.9661",
            "JPY;KRW;13.1151",
            "EUR;CHF;1.2053",
            "AUD;JPY;86.0305",
            "EUR;USD;1.2989",
            "JPY;INR;0.6571"
        };
    }
}
