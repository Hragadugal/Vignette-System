using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vignette.Data.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string PersonalCode { get; set; }

    }
}
