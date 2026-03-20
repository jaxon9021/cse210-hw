class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points) { }

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return $"[∞] {_name}";
    }

    public override string SaveFormat()
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }
}