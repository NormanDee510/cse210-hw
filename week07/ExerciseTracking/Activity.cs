using System;

namespace ExerciseTracker
{
    public abstract class Activity
    {
        private string _date;
        private int _lengthInMinutes;

        public Activity(string date, int length)
        {
            _date = date;
            _lengthInMinutes = length;
        }

        public string Date => _date;
        public int Length => _lengthInMinutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public virtual string GetSummary()
        {
            return $"{Date} {GetActivityType()} ({Length} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }

        protected abstract string GetActivityType();
    }
}
