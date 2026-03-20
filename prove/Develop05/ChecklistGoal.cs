class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int count, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _count = count;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_count < _target)
        {
            _count++;
            return (_count == _target) ? _points + _bonus : _points;
        }
        return 0;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetStatus()
    {
        return $"[{(_count >= _target ? "X" : " ")}] {_name} ({_count}/{_target})";
    }

    public override string SaveFormat()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_count}|{_target}|{_bonus}";
    }
}