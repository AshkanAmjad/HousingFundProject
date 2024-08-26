using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFund.DAL.Utilities
{
    internal static class DateConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            var hour = pc.GetHour(date);
            var minute = pc.GetMinute(date);
            var second = pc.GetSecond(date);
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);

            return $"{year}/{month:D2}/{day:D2}-{hour:D2}:{minute:D2}:{second:D2}";
                               
        }
    }
}
