namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Aukcije")]
    public partial class Aukcije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aukcije()
        {
            Ponudas = new HashSet<Ponuda>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_aukcije { get; set; }

        [Required]
        [StringLength(50)]
        public string naziv { get; set; }

        public int marka_id { get; set; }

        public int model_id { get; set; }

        public int godina { get; set; }

        [Required]
        [StringLength(10)]
        public string kilometraza { get; set; }

        [Required]
        [StringLength(10)]
        public string cijena { get; set; }

        [Required]
        [StringLength(40)]
        public string lokacija_vozila { get; set; }

        public int motor_id { get; set; }

        public DateTime datum_aukcije { get; set; }

        public DateTime rok { get; set; }

        public virtual Marka Marka { get; set; }

        public virtual Model Model { get; set; }

        public virtual Motor Motor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ponuda> Ponudas { get; set; }
    }
}
