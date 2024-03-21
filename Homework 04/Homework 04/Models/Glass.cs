using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_04.Models
{
    public class Glass : Materials
    {

        private string opacity;

        public string Opacity { get => opacity; set => opacity = value; }

        public Glass()
        {
            Name = "Glass";
            Description = "Mostly bottles and drinking glasses";
            Procedure = "Glass is recycled by melting it down";
            BiodegradeTime = 1000000;
            PollutionPercentage = 4.4;
            Opacity = "clear";
            getPriority();
            getThreat();
        }


        public override double getThreat()
        {
            if ( PollutionPercentage >= 4 && PollutionPercentage <7)
            {
                mThreat = 1;

            }
            else if (PollutionPercentage >= 8 && PollutionPercentage < 11)
            {
                mThreat = 2;
            }
            else if (PollutionPercentage >= 12 && PollutionPercentage < 15)
            {
                mThreat = 3;
            }
            else if (PollutionPercentage >= 16)
            {
                mThreat = 4;
            }
            return mThreat;
        }


        public override double getPriority()
        {
            if (BiodegradeTime >= 100 && BiodegradeTime < 199)
            {
                mPriority = 1;

            }
            if (BiodegradeTime >= 200 && BiodegradeTime < 299)
            {
                mPriority = 2;

            }
            else if (BiodegradeTime >= 300 && BiodegradeTime < 100000)
            {
                mPriority = 4;
            }
            else if (BiodegradeTime >= 1000000 && BiodegradeTime < 1000000000000)
            {
                mPriority = 6;
            }
            else if (BiodegradeTime >= 10000000000000)
            {
                mPriority = 9;
            }
            return mPriority;
        }

        public static implicit operator Glass(Aluminum v)
        {
            throw new NotImplementedException();
        }
    }
}