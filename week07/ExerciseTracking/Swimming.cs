//Distance (km) = swimming laps * 50 / 1000
//Distance (miles) = swimming laps * 50 / 1000 * 0.62//
//Speed (mph or kph) = (distance / minutes) * 60//
//Pace (min per mile or min per km)= minutes / distance//
//Speed = 60 / pace//
//Pace = 60 / speed//

class Swimming : Activity
{

    private int _laps;
    public Swimming(int minutes, DateTime date, int laps)
        : base(minutes, date )
    {
        _laps = laps;
    }    
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
        
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
        
    }
    public override double GetPace()
    {
       return  GetMinutes() / GetDistance();
        
    }
}