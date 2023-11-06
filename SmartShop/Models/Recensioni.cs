namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recensioni")]
    public partial class Recensioni
    {
        [Key]
        public int idRecensione { get; set; }

        public int idProdotto { get; set; }

        public int idUtente { get; set; }

        public int Valutazione { get; set; }

        public string TestoRecensione { get; set; }

        public DateTime DataRecensione { get; set; }
    }
}
