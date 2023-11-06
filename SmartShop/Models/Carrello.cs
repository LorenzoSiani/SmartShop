namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carrello")]
    public partial class Carrello
    {
        [Key]
        public int idCarrello { get; set; }

        public int idUtente { get; set; }

        public virtual Utente Utente { get; set; }
    }
}
