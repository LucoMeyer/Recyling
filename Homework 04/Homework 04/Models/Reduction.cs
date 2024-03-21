using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_04.Models
{
    public class Reduction
    {
        public int WeekID { get; set; }
        public double KilosNotRecycled { get; set; }
        public string Comment { get; set; }


        public Reduction()
        {
            WeekID = -1;
            KilosNotRecycled = 0;
            Comment = "Nothing";
        }

        public Reduction(int weekID, double kilosNotRecycled, string comment)
        {
            WeekID = weekID;
            KilosNotRecycled = kilosNotRecycled;
            Comment = comment;
        }
    }
}