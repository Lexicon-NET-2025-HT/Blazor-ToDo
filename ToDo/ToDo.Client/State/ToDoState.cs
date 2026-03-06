namespace ToDo.Client.State;

public class ToDoState
{
    public int Count { get; private set; }

    public event Action? Onchange;

    public void SetCount(int count)
    {
        Count = count;
        Onchange?.Invoke();
    }
}
