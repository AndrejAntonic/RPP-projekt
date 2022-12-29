namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Recenzija")]
    public partial class Recenzija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_recenzije { get; set; }

        public int Od_korisnik_id { get; set; }

        public int Ocjena { get; set; }

        [StringLength(255)]
        public string Komentar { get; set; }

        public int Za_korisnik_id { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }
    }
}
