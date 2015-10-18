/*
 * Store time in 24hour format xxxx
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORS_Analyser
{
    class TimeSlot
    {
        //Properties

        public int startTime { get; set; }
        public int endTime { get; set; }

        public Boolean timeClash(TimeSlot a, TimeSlot b)
        {
            if (b.startTime < a.startTime)
                timeClash(b, a);

            return (a.endTime > b.startTime);
        }
    }
}
