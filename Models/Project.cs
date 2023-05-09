using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lucas_management_system.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string ?Name { get; set; }

        public virtual ICollection<Task> ?Tasks { get; set; }
    }
}
