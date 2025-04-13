class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
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

    public override bool IsCompleted() => _isComplete;

  public override string GetDetailsString()
  {
    string status;
    if (_isComplete)
    {
        status = "X";
    }
    else
    {
        status = " ";
    }

    string result = "[" + status + "] " + _shortName + " (" + _description + ")";
    return result;
  }

  public override string GetStringRepresentation()
  {
    string result = "SimpleGoal|" + _shortName + "|" + _description + "|" + _points + "|" + _isComplete;
    return result;
  }
    public void LoadState(string[] parts)
    {
        _isComplete = bool.Parse(parts[4]);
    }
}