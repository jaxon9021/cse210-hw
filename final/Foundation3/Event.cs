class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    protected string GetTitle() => _title;
    protected string GetDescription() => _description;
    protected string GetDate() => _date;
    protected string GetTime() => _time;
    protected Address GetAddress() => _address;

    public virtual string GetStandardDetails()
    {
        return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {_title} on {_date}";
    }
}