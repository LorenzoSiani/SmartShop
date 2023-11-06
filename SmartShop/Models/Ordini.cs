namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ordini")]
    public partial class Ordini
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordini()
        {
            Dettagli = new HashSet<Dettagli>();
        }

        [Key]
        public int idOrdine { get; set; }

        public int idUtente { get; set; }

        public DateTime DataOrdine { get; set; }

        public decimal Totale { get; set; }

        [StringLength(50)]
        public string StatoOrdine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dettagli> Dettagli { get; set; }

        public virtual Utente Utente { get; set; }

        
    }
}
