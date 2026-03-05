namespace ToDo.Client.Models;

public class ToDoItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Text { get; set; } 
    public DateTime Created { get; set; } = DateTime.Now;
    public bool Completed { get; set; } = false;

}
