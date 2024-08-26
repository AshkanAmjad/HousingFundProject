using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFundProject.Utilities
{
    internal class DateAndTimeFormat
    {
        internal static string DateFormat()
        {
            return $"امروز : {DateTime.Now.ToShamsi()} |";
        }

        internal static string TimeFormat()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
