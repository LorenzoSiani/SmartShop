namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Spedizioni")]
    public partial class Spedizioni
    {
        [Key]
        public int idSpedizione { get; set; }

        public int idUtente { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeDestinatario { get; set; }

        [Required]
        [StringLength(50)]
        public string Indirizzo { get; set; }

        [Required]
        [StringLength(50)]
        public string Citta { get; set; }

        [Required]
        [StringLength(50)]
        public string CAP { get; set; }

        [Required]
        [StringLength(50)]
        public string Paese { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroDiContatto { get; set; }

        [StringLength(50)]
        public string NotePerCorriere { get; set; }

        public virtual Utente Utente { get; set; }
    }
}
