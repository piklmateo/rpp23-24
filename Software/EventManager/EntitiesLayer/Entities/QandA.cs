namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class QandA
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Question { get; set; }

        [StringLength(255)]
        public string Answer { get; set; }

        [StringLength(255)]
        public string Keywords { get; set; }
    }
}
