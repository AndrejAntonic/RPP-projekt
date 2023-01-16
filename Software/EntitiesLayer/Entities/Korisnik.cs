namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            Iznajmljenoes = new HashSet<Iznajmljeno>();
            Oglas = new HashSet<Ogla>();
            Oglas1 = new HashSet<Ogla>();
            Ponudas = new HashSet<Ponuda>();
            Recenzijas = new HashSet<Recenzija>();
            Recenzijas1 = new HashSet<Recenzija>();
            Oglas2 = new HashSet<Ogla>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_korisnika { get; set; }

        [Required]
        [StringLength(40)]
        public string Ime { get; set; }

        [Required]
        [StringLength(40)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(50)]
        public string Korimme { get; set; }

        [Required]
        [StringLength(50)]
        public string Lozinka { get; set; }

        [Required]
        [StringLength(10)]
        public string Broj_telefona { get; set; }

        [StringLength(50)]
        public string Grad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Iznajmljeno> Iznajmljenoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogla> Oglas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogla> Oglas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ponuda> Ponudas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recenzija> Recenzijas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recenzija> Recenzijas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogla> Oglas2 { get; set; }
    }
}
