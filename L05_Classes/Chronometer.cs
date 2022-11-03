namespace L05_Classes;

public class Chronometer
{
    // encapsulation
    // field  (to remember things)
    private long _startTime; // internal state
    private long _endTime;
    private bool _isRunning;
    
    
    // accessors (get, set)
    // Properties
    public long ElapsedMilliseconds
    {
        get
        {
            if(_isRunning)
                return Environment.TickCount64 - _startTime;
            
            return _endTime - _startTime;
        }
    }
    
    public void Start()
    {
        if (!_isRunning)
        {
            _isRunning = true;
            _startTime = Environment.TickCount64;
        }
    }
    public void Stop()
    {
        if (_isRunning)
        {
            _isRunning = false;
            _endTime = Environment.TickCount64;
        }
    }
}
