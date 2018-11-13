using System;

namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        private readonly IHolidayService holidayService;
        //use dependency injection
        public Bill(IHolidayService holidayService)
        {
            this.holidayService = holidayService;
        }

        public DateTime CheckDate (DateTime dueDate)
        {
            DateTime paymentDate = dueDate;
            while (holidayService.isHoliday(paymentDate) || paymentDate.DayOfWeek == DayOfWeek.Saturday || paymentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                paymentDate = paymentDate.AddDays(1);
            }
            //if (holidayService.isHoliday(dueDate))
            //    dueDate = dueDate.AddDays(1);
            //if (dueDate.DayOfWeek == DayOfWeek.Saturday)
            //    return dueDate.AddDays(2);
            //else if (dueDate.DayOfWeek == DayOfWeek.Sunday)
            //    return dueDate.AddDays(1);
            return paymentDate;
        }
    }

}

