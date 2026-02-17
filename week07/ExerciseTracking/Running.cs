//Distance (km) = swimming laps * 50 / 1000
//Distance (miles) = swimming laps * 50 / 1000 * 0.62//
//Speed (mph or kph) = (distance / minutes) * 60//
//Pace (min per mile or min per km)= minutes / distance//
//Speed = 60 / pace//
//Pace = 60 / speed//


class Running : Activity
{

    private double _distance;
    public Running(int minutes, DateTime date, double distance)
        : base(minutes, date)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
}