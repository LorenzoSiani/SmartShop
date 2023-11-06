namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Prodotti")]
    public partial class Prodotti
    {
        [Key]
        public int idProdotto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Descrizione { get; set; }

        public decimal Prezzo { get; set; }

        public int idCategoria { get; set; }

        public int Disponibilita { get; set; }

        public string Immagine { get; set; }
    }
}
