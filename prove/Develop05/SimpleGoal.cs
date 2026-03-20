class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points, bool complete = false)
        : base(name, desc, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name}";
    }

    public override string SaveFormat()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }
}