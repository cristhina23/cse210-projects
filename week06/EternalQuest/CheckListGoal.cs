class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        int total = _points;
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            total += _bonus;
        }
        return total;
    }

    public override bool IsCompleted() => _amountCompleted >= _target;

  public override string GetDetailsString()
  {
    string status;

    if (_amountCompleted >= _target)
    {
        status = "X";
    }
    else
    {
        status = " ";
    }

    string result = "[" + status + "] " + _shortName + " (" + _description + ") -- Completed " + _amountCompleted + "/" + _target;
    return result;
  }
  public override string GetStringRepresentation()
  {
    string result = "ChecklistGoal|" + _shortName + "|" + _description + "|" + _points + "|" + _target + "|" + _bonus + "|" + _amountCompleted;
    return result;
  }

    public void LoadState(string[] parts)
    {
        _amountCompleted = int.Parse(parts[6]);
    }
}