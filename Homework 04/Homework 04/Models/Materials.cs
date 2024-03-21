using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_04.Models
{
    public abstract class Materials
    {


        public string _Name;
        public string _Description;
        public string _Procedure;
        public double _BiodegradeTime;
        public double _PollutionPercentage;
        public int _mPriority;
        public int _mThreat;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }

        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }

        }

        public string Procedure
        {
            get { return _Procedure; }
            set { _Procedure = value; }

        }

        public double BiodegradeTime
        {
            get { return _BiodegradeTime; }
            set { _BiodegradeTime = value; }

        }

        public double PollutionPercentage
        {
            get { return _PollutionPercentage; }
            set { _PollutionPercentage = value; }

        }

        public int mThreat
        {
            get { return _mThreat; }
            set { _mThreat = value; }
        }

        public int mPriority
        {
            get { return _mPriority; }
            set { _mPriority = value; }
        }


        protected Materials()
        {
        }


        protected Materials(string name, string description, string procedure, double biodegradeTime, double pollutionPercentage)
        {
            Name = name;
            Description = description;
            Procedure = procedure;
            BiodegradeTime = biodegradeTime;
            PollutionPercentage = pollutionPercentage;
        }

        public abstract double getThreat();
        

        public virtual double getPriority()
        {

            return 0;
        }

    }
}