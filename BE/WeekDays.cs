using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeekDays
    {
        public bool sunday { get; set; }
        public bool monday { get; set; }
        public bool tuesday { get; set; }
        public bool wednesday { get; set; }
        public bool thursday { get; set; }
        public bool friday { get; set; }


        public WeekDays()
        {
            this.sunday = false;
            this.monday = false;
            this.tuesday = false;
            this.wednesday = false;
            this.thursday = false;
            this.friday = false;
        }
        public WeekDays(bool sunday, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday)
        {
            this.sunday = sunday;
            this.monday = monday;
            this.tuesday = tuesday;
            this.wednesday = wednesday;
            this.thursday = thursday;
            this.friday = friday;
        }

        public WeekDays(WeekDays weekDays)
        {
            sunday = weekDays.sunday;
            monday = weekDays.monday;
            tuesday = weekDays.tuesday;
            wednesday = weekDays.wednesday;
            thursday = weekDays.thursday;
            friday = weekDays.friday;
        }

        public int amountOfDays()
        {
            int count = 0;
            if (this.friday == true)
                count++;
            if (this.monday == true)
                count++;
            if (this.sunday == true)
                count++;
            if (this.thursday == true)
                count++;
            if (this.wednesday == true)
                count++;
            if (this.tuesday == true)
                count++;
            return count;
        }

        public bool myDayIs(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return this.sunday;
                case DayOfWeek.Monday:
                    return this.monday;
                case DayOfWeek.Tuesday:
                    return this.tuesday;
                case DayOfWeek.Wednesday:
                    return this.wednesday;
                case DayOfWeek.Thursday:
                    return this.thursday;
                case DayOfWeek.Friday:
                    return this.friday;
            }
            return false;
        }
    }
}
