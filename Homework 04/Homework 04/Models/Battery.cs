using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_04.Models
{
    public class Battery : Materials
    {

        private string BatteryType;

        public string BatteryType1 { get => BatteryType; set => BatteryType = value; }

        public Battery()
        {
            Name = "Battery";
            Description = "Home use batteries";
            Procedure = "Stripped of outside layer and discarded";
            BiodegradeTime = 100;
            PollutionPercentage = 3;
            BatteryType = "Lithium";

            getThreat();
            getPriority();
        }


        public Battery(string name, string description, string procedure, double biodegradeTime, double pollutionPercentage, int mPriority, int mThreat): base(name, description, procedure, biodegradeTime ,pollutionPercentage)
        {
        }

        public override double getThreat()
        {
            if (PollutionPercentage >= 2 && PollutionPercentage < 7)
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


    }
}