using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lucas_management_system.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string ?Name { get; set; }

        public virtual ICollection<User> ?Users { get; set; }
    }
}
