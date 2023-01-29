using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Kreirao_aukcije_korisnikRepository : Repository<Kreirao_aukcije_korisnik>
    {
        public Kreirao_aukcije_korisnikRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Kreirao_aukcije_korisnik> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }



        public IQueryable<Korisnik> GetKorisnikFromAukcija(int aukcija_id)
        {
            var query = from k in Context.Korisniks
                        join e in Entities on k.Id_korisnika equals e.Korisnik_id
                        join a in Context.Aukcijes on e.Aukcija_id equals a.Id_aukcije
                        where a.Id_aukcije == aukcija_id
                        select k;

            return query;
        }

        public override int Add(Kreirao_aukcije_korisnik entity, bool saveChanges = true)
        {
            var korisnikkreirao = new Kreirao_aukcije_korisnik
            {
                Korisnik_id = entity.Korisnik_id,
                Aukcija_id = entity.Aukcija_id
            };

            Entities.Add(korisnikkreirao);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Kreirao_aukcije_korisnik entity, bool saveChanges = true)
        {
            var korisnikkreirao = Entities.SingleOrDefault(kk => kk.Korisnik_id == entity.Korisnik_id);

            korisnikkreirao.Korisnik_id = entity.Korisnik_id;
            korisnikkreirao.Aukcija_id = entity.Aukcija_id;

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
