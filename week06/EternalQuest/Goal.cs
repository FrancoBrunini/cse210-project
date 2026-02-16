using System.ComponentModel;

abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();


    public  virtual string Show() {
        return $"{_shortName} ({_description})";
    }


    public abstract string Save();

    public virtual int GetPoints()
    {
        return _points;
    }
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
}