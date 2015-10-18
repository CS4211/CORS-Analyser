/*
 * Setting details for each module
 * Only allowing max 10 time slots
 * 
 */

using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CORS_Analyser
{
    class Module
    {

        //Properties
        public String ModuleCode { get; set; }
        public int vacancy { get; set; }
        public ArrayList lessonTime = new ArrayList();
        public int numTS = 0;

        public void addTimeSlot(TimeSlot s)
        {
            lessonTime.Add(s);
        }

        public void removeTimeSlot(TimeSlot s)
        {
            lessonTime.Remove(s);
        }
        

    }


}
