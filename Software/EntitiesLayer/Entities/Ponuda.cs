namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Ponuda")]
    public partial class Ponuda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_ponude { get; set; }

        [Column("Ponuda")]
        public int Ponuda1 { get; set; }

        public int Aukcije_id { get; set; }

        public int Korisnik_id { get; set; }

        public virtual Aukcije Aukcije { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
