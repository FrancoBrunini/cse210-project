class CheckListGoal : Goal
{


    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string shortName, string description, int points,int amountCompleted, int target,int bonus )
        : base(shortName, description, points) {
            _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        }
        public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string Show()
    {
    return $"{GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }
    public override string Save()
    {
    return $"CheckListGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";

    }
}