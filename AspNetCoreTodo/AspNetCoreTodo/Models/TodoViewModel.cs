
namespace AspNetCoreTodo.Models
{
    // A separate class to hold a list of todo items that 
    // will be displayed to the user.
    public class TodoViewModel
    {
        public TodoItem[] Items {get; set; }
    }
}