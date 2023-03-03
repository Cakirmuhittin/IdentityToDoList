using Microsoft.AspNetCore.Identity;

namespace IdentityToDoList.Models
{
    public class ApplicationUser:IdentityUser
    {
        public List<ToDoItem> TodoItems { get; set; } = new();
    }
}
