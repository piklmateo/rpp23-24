namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Review
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Review()
        {
        }

        public int Id { get; set; }

        public int? Rate { get; set; }

        public int? Recommend { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public int Id_Events { get; set; }

        public virtual Event Event { get; set; }

        public int Id_Users { get; set; }

        public virtual User User { get; set; }
    }
}
