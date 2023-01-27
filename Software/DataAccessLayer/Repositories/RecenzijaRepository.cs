using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RecenzijaRepository : Repository<Recenzija>
    {
        public RecenzijaRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Recenzija> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }
        public IQueryable<Recenzija> GetAllForUser(Korisnik korisnik)
        {
            var query = from e in Entities
                        where e.Za_korisnik_id == korisnik.Id_korisnika
                        select e;

            return query;
        }


        public IQueryable<Recenzija> GetCertainRecenzija(string phrase)
        {
            var query = from e in Entities
                        where e.Id_recenzije.ToString().Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Recenzija entity, bool saveChanges = true)
        {
            var korisnikk = Context.Korisniks.SingleOrDefault(k => k.Id_korisnika == entity.Korisnik.Id_korisnika);
            var recenzije = new Recenzija
            {
                Id_recenzije = entity.Id_recenzije,
                Korisnik = korisnikk,
                Ocjena = entity.Ocjena,
                Komentar = entity.Komentar,
                Za_korisnik_id = entity.Za_korisnik_id,
                Od_korisnik_id = entity.Od_korisnik_id,
                Datum = DateTime.Now
            };

            Entities.Add(recenzije);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Recenzija entity, bool saveChanges = true)
        {
            var korisnikk = Context.Korisniks.SingleOrDefault(k => k.Id_korisnika == entity.Korisnik.Id_korisnika);
            var recenzije = Entities.SingleOrDefault(r => r.Id_recenzije == entity.Id_recenzije);

            recenzije.Id_recenzije = entity.Id_recenzije;
            recenzije.Korisnik = korisnikk;
            recenzije.Ocjena = entity.Ocjena;
            recenzije.Komentar = entity.Komentar;
            recenzije.Za_korisnik_id = entity.Za_korisnik_id;
            recenzije.Od_korisnik_id = entity.Od_korisnik_id;


            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
