using System.ComponentModel.DataAnnotations;

namespace ToDoListWebApp.Models
{
    public class Activities
    {
        [Key]
        public int ActivityNo { get; set; }
        public string UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public Boolean IsActive { get; set; }
    }
}
