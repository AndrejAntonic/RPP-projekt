using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PonudaRepository : Repository<Ponuda>
    {
        public PonudaRepository() : base (new AutoPrimeModel())
        {

        }

        private PrijavljeniKorisnik prijavljeni = new PrijavljeniKorisnik();

        public override IQueryable<Ponuda> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Ponuda> GetCertainPonuda(string phrase)
        {
            var query = from e in Entities
                        where e.Id_ponude.ToString().Contains(phrase)
                        select e;

            return query;
        }


        public IQueryable<Ponuda> GetPonudaAukcije(int id_aukcije)
        {
            var query = from e in Entities
                        where e.Id_ponude == id_aukcije
                        select e;

            return query;
        }

        public IQueryable<Ponuda> GetPonudaFromAuction(int aukcija_id)
        {
            var query = from k in Context.Ponudas
                        join a in Context.Aukcijes on k.Aukcije_id equals a.Id_aukcije
                        where a.Id_aukcije == aukcija_id
                        orderby k.Ponuda1 descending
                        select k;

          return query.Take(1);
        }


        public override int Add(Ponuda entity, bool saveChanges = true)
        {
            var ponuda = new Ponuda
            {
                Korisnik_id = entity.Korisnik_id,
                Aukcije_id = entity.Aukcije_id,
                Ponuda1 = entity.Ponuda1
            };

            Entities.Add(ponuda);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Ponuda entity, bool saveChanges = true)
        {
            var ponuda = Entities.SingleOrDefault(p => p.Id_ponude == entity.Id_ponude);

            ponuda.Ponuda1 = entity.Ponuda1;

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
