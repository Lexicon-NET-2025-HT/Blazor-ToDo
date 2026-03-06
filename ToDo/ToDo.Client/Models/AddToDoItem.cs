using System.ComponentModel.DataAnnotations;

namespace ToDo.Client.Models;

public class AddToDoItem
{
    [Required(ErrorMessage = "Please enter a todo.")]
    [MinLength(2, ErrorMessage = "Todo must be at least 2 characters.")]
    [MaxLength(15, ErrorMessage = "Todo can’t be longer than 15 characters.")]
    public string Text { get; set; } = string.Empty;
}
