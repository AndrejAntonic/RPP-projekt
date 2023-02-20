namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Slika")]
    public partial class Slika
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_slike { get; set; }

        public int oglas_id { get; set; }

        [Column("slika")]
        public byte[] slika1 { get; set; }

        public int? ostecenje_id { get; set; }

        public virtual Ogla Ogla { get; set; }

        public virtual Oštećenja Oštećenja { get; set; }
    }
}
