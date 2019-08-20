using System;
namespace TheContent.Models
{
    public class EventDay : BaseModel
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public int StartHour { get; set; }
        public int StartMinutes { get; set; }

        public int EndHour { get; set; }
        public int EndMinutes { get; set; }

        public string EventId { get; set; }

        public static EventDay Create(int day, int month, int year, int startHour, int startMinutes, int endHour, int endMinutes)
            => new EventDay
            {
                Day = day,
                Month = month,
                Year = year,
                StartHour = startHour,
                StartMinutes = startMinutes,
                EndHour = endHour,
                EndMinutes = endMinutes,
            };
    }
}
