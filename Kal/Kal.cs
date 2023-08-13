using System.Globalization;

namespace Kal;

public class Kalc
{
    public int YearNow { get; set; } = DateTime.Now.Year;
    public int MonthNow { get; set; } = DateTime.Now.Month;

    string currentMonthName => new DateTime(YearNow, MonthNow, 1).ToString("MMMM", CultureInfo.InvariantCulture);
    void PreviousMonth()
    {
        if (MonthNow == 1)
        {
            MonthNow = 12;
            YearNow--;
        }
        else
        {
            MonthNow--;
        }
    }
    void NextMonth()
    {
        if (MonthNow == 12)
        {
            MonthNow = 1;
            YearNow++;
        }
        else
        {
            MonthNow++;
        }
    }
}