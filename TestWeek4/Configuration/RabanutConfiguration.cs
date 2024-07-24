using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek4.Configuration
{
    internal static class RabanutConfiguration
    {
        public static string rabanutPath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Rabanut.xml"
            );
    }

}
