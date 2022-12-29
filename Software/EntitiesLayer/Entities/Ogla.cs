namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Ogla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogla()
        {
            Slikas = new HashSet<Slika>();
            Korisniks = new HashSet<Korisnik>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_oglas { get; set; }

        public int korisnik_id { get; set; }

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
        [StringLength(30)]
        public string lokacija_vozila { get; set; }

        public int motor_id { get; set; }

        public byte ostecenje { get; set; }

        public DateTime datum { get; set; }

        public byte? leasing { get; set; }

        public int? iznajmljeno_id { get; set; }

        public int? broj_pregleda { get; set; }

        public byte? prodano { get; set; }

        public int? prodano_korisnik_id { get; set; }

        public virtual Iznajmljeno Iznajmljeno { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Marka Marka { get; set; }

        public virtual Model Model { get; set; }

        public virtual Motor Motor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slika> Slikas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
