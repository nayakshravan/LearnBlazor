public class AppState
{
    public List<EventModel> Events { get; private set; } = new();

    public event Action? OnChange;

    public void AddEvent(EventModel ev)
    {
        Events.Add(ev);
        NotifyStateChanged();
    }

    public void DeleteEvent(int id)
    {
        Events.RemoveAll(e => e.Id == id);
        NotifyStateChanged();
    }

    public void UpdateEvent(EventModel updated)
    {
        var index = Events.FindIndex(e => e.Id == updated.Id);
        if (index >= 0)
        {
            Events[index] = updated;
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
