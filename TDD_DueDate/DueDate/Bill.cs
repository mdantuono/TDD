using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        IHolidayService _holidayService;
        //use dependency injection
        public DateTime CheckDate (DateTime dueDate)
        {
            //DateTime returnedDate = dueDate;
            //if (_holidayService.isHoliday(dueDate));
            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
                return dueDate.AddDays(2);
            else if (dueDate.DayOfWeek == DayOfWeek.Sunday)
                return dueDate.AddDays(1);
            return dueDate;
        }
    }

}

