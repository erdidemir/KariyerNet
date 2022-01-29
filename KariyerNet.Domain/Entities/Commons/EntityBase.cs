using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Domain.Entities.Commons
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; } 
        
        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime LastMofiedDate { get; set; }

        [Required]
        public int DisplarOrder { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
