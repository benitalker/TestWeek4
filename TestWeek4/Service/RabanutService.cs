using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static TestWeek4.Configuration.RabanutConfiguration;

namespace TestWeek4.Service
{
    internal class RabanutService
    {
        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(rabanutPath))
            {
                XDocument document = new();
                XElement rabanut = new("Queries");
                document.Add(rabanut);
                document.Save(rabanutPath);
            }
        }
        public static string AddQueryToXml(string day, string numDay, string month, string year)
        {
            XDocument document = XDocument.Load(rabanutPath);
            var queries = document.Descendants("Queries").FirstOrDefault();
            if (queries != null)
            {
                string resultText = 
                    $"{GetDay(day)} " +
                    $"{GetNumDay(int.Parse(numDay), month)} " +
                    $"{GetMonth(month)} " +
                    $"{GetYear(year)}";
                XElement element = new(
                "Query",
                new XElement("Day", day),
                new XElement("DayMonth", numDay),
                new XElement("Month", month),
                new XElement("Year", year),
                new XElement("Result", resultText)
                );
                queries.Add(element);
                document.Save(rabanutPath);
                return resultText;
            }
            return "";
        }
        private static string GetDay(string day)
        {
            return day switch
            {
                "ראשון" => "באחד בשבת",
                "שני" => "בשני בשבת",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "שישי" => "בששי בשבת",
                _ => throw new ArgumentOutOfRangeException(nameof(day), $"Invalid day: {day}")
            };
        }
        private static string GetNumDay(int day, string monthName)
        {
            return day switch
            {
                1 => $"יום אחד",
                2 => $"שני ימים",
                3 => $"שלשה ימים",
                4 => $"ארבעה ימים",
                5 => $"חמשה ימים",
                6 => $"ששה ימים",
                7 => $"שבעה ימים",
                8 => $"שמנה ימים",
                9 => $"תשעה ימים",
                10 => $"עשרה ימים",
                11 => $"אחד עשר יום",
                12 => $"שנים עשר יום",
                13 => $"שלשה עשר יום",
                14 => $"ארבעה עשר יום",
                15 => $"חמשה עשר יום",
                16 => $"ששה עשר יום",
                17 => $"שבעה עשר יום",
                18 => $"שמנה עשר יום",
                19 => $"תשעה עשר יום",
                20 => $"עשרים יום",
                21 => $"אחד ועשרים יום",
                22 => $"שנים ועשרים יום",
                23 => $"שלשה ועשרים יום",
                24 => $"ארבעה ועשרים יום",
                25 => $"חמשה ועשרים יום",
                26 => $"ששה ועשרים יום",
                27 => $"שבעה ועשרים יום",
                28 => $"שמנה ועשרים יום",
                29 => $"תשעה ועשרים יום",
                30 => $"יום שלשים לחדש {monthName} שהוא ראש חודש {GetNextMonth(monthName)}",
                _ => throw new ArgumentOutOfRangeException(nameof(day), $"Invalid day: {day}")
            };
        }
        private static string GetMonth(string monthName)
        {
            return monthName switch
            {
                "תשרי" => "לירח תשרי",
                "מרחשון" => "לירח מרחשון",
                "כסלו" => "לירח כסלו",
                "טבת" => "לירח טבת",
                "שבט" => "לירח שבט",
                "אדר" => "לירח ניסן",
                "אדר הראשון" => "לירח אדר הראשון",
                "אדר השני" => "לירח אדר השני",
                "ניסן" => "לירח ניסן",
                "אייר" => "לירח אייר",
                "סיון" => "לירח סיון",
                "תמוז" => "לירח תמוז",
                "אב" => "לירח אב",
                "אלול" => "לירח אלול",
                _ => throw new ArgumentOutOfRangeException(nameof(monthName), $"Invalid day: {monthName}")
            };
        }
        private static string GetNextMonth(string monthName)
        {
            return monthName switch
            {
                "תשרי" => "מרחשון",
                "מרחשון" => "כסלו",
                "כסלו" => "טבת",
                "טבת" => "שבט",
                "שבט" => "אדר",
                "אדר" => "ניסן",
                "אדר הראשון" => "אדר השני",
                "אדר השני" => "ניסן",
                "ניסן" => "אייר",
                "אייר" => "סיון",
                "סיון" => "תמוז",
                "תמוז" => "אב",
                "אב" => "אלול",
                "אלול" => "תשרי",
                _ => throw new ArgumentOutOfRangeException(nameof(monthName), $"Invalid day: {monthName}")
            };
        }
        private static string GetYear(string yearName)
        {
            return yearName switch
            {
                @"תשפ""ד" => "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם",
                @"תשפ""ה" => "בשנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם",
                @"תשפ""ו" => "בשנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם",
                @"תשפ""ז" => "בשנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם",
                @"תשפ""ח" => "בשנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם",
                @"תשפ""ט" => "בשנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם",
                @"תש""צ" => "בשנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם",
                @"תשצ""א" => "בשנת חמשת אלפים ושבע מאות ותשעים ואחד לבריאת העולם",
                @"תשצ""ב" => "בשנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם",
                @"תשצ""ג" => "בשנת חמשת אלפים ושבע מאות ותשעים ושלוש לבריאת העולם",
                _ => throw new ArgumentOutOfRangeException(nameof(yearName), $"Invalid day: {yearName}")
            };
        }
    }
}
