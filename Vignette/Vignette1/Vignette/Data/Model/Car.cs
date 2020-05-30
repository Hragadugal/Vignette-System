using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vignette.Data.Model
{
    public class Car
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey(nameof(user))]
        public int Id_User { get; set; }
        public virtual User user { get; set; }
        [Required]
        [MaxLength(8)]
        public string CarRegistration { get; set; }
    }
}
