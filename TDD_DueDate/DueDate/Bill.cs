using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        private IHolidayService _holidayService = new HolidayService();
        //use dependency injection
        public DateTime CheckDate (DateTime dueDate)
        {
            //DateTime returnedDate = dueDate;
            if (_holidayService.isHoliday(dueDate))
            {
                dueDate = dueDate.AddDays(1);
            }
            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
                return dueDate.AddDays(2);
            else if (dueDate.DayOfWeek == DayOfWeek.Sunday)
                return dueDate.AddDays(1);
            return dueDate;
        }
    }

}

