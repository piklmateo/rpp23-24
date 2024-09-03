namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        public decimal? Amount { get; set; }

        public int Id_Users { get; set; }

        public int Id_Events { get; set; }

        public virtual Event Event { get; set; }

        public virtual User User { get; set; }
    }
}
