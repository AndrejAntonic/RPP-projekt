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

        public override int Add(Ponuda entity, bool saveChanges = true)
        {
            var aukcijaa = Context.Aukcijes.SingleOrDefault(a => a.Id_aukcije == entity.Aukcije.Id_aukcije);
            var ponuda = new Ponuda
            {
                Id_ponude = entity.Id_ponude,
                Aukcije = aukcijaa,
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
            var aukcijaa = Context.Aukcijes.SingleOrDefault(a => a.Id_aukcije == entity.Aukcije.Id_aukcije);
            var ponuda = Entities.SingleOrDefault(p => p.Id_ponude == entity.Id_ponude);

            ponuda.Id_ponude = entity.Id_ponude;
            ponuda.Aukcije = aukcijaa;
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
