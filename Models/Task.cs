using System.ComponentModel.DataAnnotations;

namespace lucas_management_system.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string ?Title { get; set; }

        public string ?Description { get; set; }

        public TaskStatus Status { get; set; }

        public int ProjectId { get; set; }
        public virtual Project? Project { get; set; }

        public string ?UserId { get; set; }
        public virtual User ?User { get; set; }
    }

    public enum TaskStatus
    {
        Todo,
        InProgress,
        Done
    }
}
