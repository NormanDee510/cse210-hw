namespace ExerciseTracker
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(string date, int length, double speed) : base(date, length)
        {
            _speed = speed;
        }

        public override double GetDistance() => _speed * (Length / 60.0);

        public override double GetSpeed() => _speed;

        public override double GetPace() => 60.0 / _speed;

        protected override string GetActivityType() => "Cycling";
    }
}
