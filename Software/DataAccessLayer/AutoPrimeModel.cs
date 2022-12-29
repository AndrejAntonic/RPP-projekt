using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class AutoPrimeModel : DbContext
    {
        public AutoPrimeModel()
            : base("name=AutoPrimeModel")
        {
        }

        public virtual DbSet<Aukcije> Aukcijes { get; set; }
        public virtual DbSet<Iznajmljeno> Iznajmljenoes { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Kreirao_aukcije_korisnik> Kreirao_aukcije_korisnik { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Motor> Motors { get; set; }
        public virtual DbSet<Ogla> Oglas { get; set; }
        public virtual DbSet<Oštećenja> Oštećenja { get; set; }
        public virtual DbSet<Ponuda> Ponudas { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<Slika> Slikas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aukcije>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Aukcije>()
                .Property(e => e.kilometraza)
                .IsUnicode(false);

            modelBuilder.Entity<Aukcije>()
                .Property(e => e.cijena)
                .IsUnicode(false);

            modelBuilder.Entity<Aukcije>()
                .Property(e => e.lokacija_vozila)
                .IsUnicode(false);

            modelBuilder.Entity<Aukcije>()
                .HasMany(e => e.Ponudas)
                .WithRequired(e => e.Aukcije)
                .HasForeignKey(e => e.Aukcije_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Iznajmljeno>()
                .HasMany(e => e.Oglas)
                .WithOptional(e => e.Iznajmljeno)
                .HasForeignKey(e => e.iznajmljeno_id);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Korimme)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Broj_telefona)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .Property(e => e.Grad)
                .IsUnicode(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Iznajmljenoes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.iznajmljeno_korisnik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Oglas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.korisnik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Oglas1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.prodano_korisnik_id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Ponudas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Korisnik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Recenzijas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Od_korisnik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Recenzijas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Za_korisnik_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Oglas2)
                .WithMany(e => e.Korisniks)
                .Map(m => m.ToTable("Zanimljivi_oglasi").MapLeftKey("Korisnik_id").MapRightKey("Oglas_id"));

            modelBuilder.Entity<Marka>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Aukcijes)
                .WithRequired(e => e.Marka)
                .HasForeignKey(e => e.marka_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Models)
                .WithOptional(e => e.Marka)
                .HasForeignKey(e => e.marka_id);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Oglas)
                .WithRequired(e => e.Marka)
                .HasForeignKey(e => e.marka_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Aukcijes)
                .WithRequired(e => e.Model)
                .HasForeignKey(e => e.model_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Oglas)
                .WithRequired(e => e.Model)
                .HasForeignKey(e => e.model_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Motor>()
                .Property(e => e.vrsta)
                .IsUnicode(false);

            modelBuilder.Entity<Motor>()
                .HasMany(e => e.Aukcijes)
                .WithRequired(e => e.Motor)
                .HasForeignKey(e => e.motor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Motor>()
                .HasMany(e => e.Oglas)
                .WithRequired(e => e.Motor)
                .HasForeignKey(e => e.motor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ogla>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Ogla>()
                .Property(e => e.kilometraza)
                .IsUnicode(false);

            modelBuilder.Entity<Ogla>()
                .Property(e => e.cijena)
                .IsUnicode(false);

            modelBuilder.Entity<Ogla>()
                .Property(e => e.lokacija_vozila)
                .IsUnicode(false);

            modelBuilder.Entity<Ogla>()
                .HasMany(e => e.Slikas)
                .WithRequired(e => e.Ogla)
                .HasForeignKey(e => e.oglas_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Oštećenja>()
                .Property(e => e.opis_ostecenja)
                .IsUnicode(false);

            modelBuilder.Entity<Oštećenja>()
                .HasMany(e => e.Slikas)
                .WithOptional(e => e.Oštećenja)
                .HasForeignKey(e => e.ostecenje_id);

            modelBuilder.Entity<Recenzija>()
                .Property(e => e.Komentar)
                .IsUnicode(false);
        }
    }
}
