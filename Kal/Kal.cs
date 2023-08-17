using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Components.Forms;

namespace Kal;

public class Kalc
{
    public int YearNow { get; set; } = DateTime.Now.Year;
    public int MonthNow { get; set; } = DateTime.Now.Month;

    public string currentMonthName => new DateTime(YearNow, MonthNow, 1).ToString("MMMM yyyy", CultureInfo.InvariantCulture);


    public void PreviousMonth()
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
    public void NextMonth()
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

    public int GetBlankColumnsOffset()
    {
        var firstDayOfMonth = new DateTime(YearNow, MonthNow, 1);
        return ((int)firstDayOfMonth.DayOfWeek - (int)DayOfWeek.Monday + 8) % 7;
    }

    private DateTime selectedDate = DateTime.Now;
    public DateTime SelectedDate
    {
        get => selectedDate;
        set
        {
            selectedDate = value;
            MonthNow = value.Month;
            YearNow = value.Year;
        }
    }

    //public void GoToSelectedMonth()
    //{
    //    YearNow = SelectedDate.Year;
    //    MonthNow = SelectedDate.Month;
    //}


}