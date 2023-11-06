namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dettagli")]
    public partial class Dettagli
    {
        [Key]
        public int idDettagli { get; set; }

        public int idOrdine { get; set; }

        public int idProdotto { get; set; }

        public int Quantita { get; set; }

        public decimal PrezzoUnitario { get; set; }

        public virtual Ordini Ordini { get; set; }
    }
}
