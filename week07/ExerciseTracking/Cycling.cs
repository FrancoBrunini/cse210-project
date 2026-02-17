//Distance (km) = swimming laps * 50 / 1000
//Distance (miles) = swimming laps * 50 / 1000 * 0.62//
//Speed (mph or kph) = (distance / minutes) * 60//
//Pace (min per mile or min per km)= minutes / distance//
//Speed = 60 / pace//
//Pace = 60 / speed//


class Cycling : Activity
{
    private double _speed;
    public Cycling(int minutes, DateTime date, double speed)
        : base(minutes, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetMinutes() / GetPace();
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}