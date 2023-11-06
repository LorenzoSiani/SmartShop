namespace SmartShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categorie")]
    public partial class Categorie
    {
        [Key]
        public int idCategoria { get; set; }

        [Required]
        [StringLength(50)]
        public string NomeCategoria { get; set; }
    }
}
