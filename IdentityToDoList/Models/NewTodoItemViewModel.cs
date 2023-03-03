namespace IdentityToDoList.Models
{
    public class NewTodoItemViewModel
    {
        public string Title { get; set; } = null!;
        public List<ToDoItem>? TodoItems { get; set; }

    }
}
