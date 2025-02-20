namespace ExerciseTracker
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int length, int laps) : base(date, length)
        {
            _laps = laps;
        }

        public override double GetDistance() => (_laps * 50.0 / 1000) * 0.621371; // Converts meters to miles

        public override double GetSpeed() => (GetDistance() / Length) * 60;

        public override double GetPace() => Length / GetDistance();

        protected override string GetActivityType() => "Swimming";
    }
}
