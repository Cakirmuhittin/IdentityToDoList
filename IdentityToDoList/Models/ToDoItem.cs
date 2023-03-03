using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityToDoList.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public bool Done { get; set; }
        public string AuthorId { get; set; } = null!;
        public ApplicationUser Author { get; set; } = null!;
    }
}
