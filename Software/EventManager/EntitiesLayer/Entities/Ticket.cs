namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Ticket
    {
        public int Id { get; set; }

        public int Id_Events { get; set; }

        public int? Id_Users { get; set; }

        public decimal? Price { get; set; }
        public int? Amount { get; set; }

        public int? Id_Category { get; set; }

        public virtual Event Event { get; set; }

        public virtual TicketCategory TicketCategory { get; set; }

        public virtual User User { get; set; }
    }
}
