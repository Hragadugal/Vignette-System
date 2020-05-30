using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vignette.Data.Model
{
    public class BoughtVignette
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(cars))]
        public int Id_Car { get; set; }
        public virtual Car cars { get; set; }
        [ForeignKey(nameof(vig))]
        public int VignettesId { get; set; }
        public virtual Vignettes vig { get; set; }
        public DateTime DateTime { get; set; }
    }
}
