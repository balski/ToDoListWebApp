using System.ComponentModel.DataAnnotations;

namespace ToDoListWebApp.Models
{
    public class Users
    {
        [Key]
        [Required]
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
