using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SlikaRepository : Repository<Slika>
    {
        public SlikaRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Slika> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Slika> GetCertainSlika(string phrase)
        {
            var query = from e in Entities
                        where e.Id_slike.ToString().Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Slika entity, bool saveChanges = true)
        {
            var slika = new Slika
            {
                Id_slike = entity.Id_slike,
                slika1 = entity.slika1,
                ostecenje_id = entity.ostecenje_id
            };

            Entities.Add(slika);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Slika entity, bool saveChanges = true)
        {
            //var oglas = Context.Oglas.SingleOrDefault(o => o.Id_oglas == entity.Ogla.Id_oglas);
            var ostecenja = Context.Oštećenja.SingleOrDefault(o => o.Id_ostecenja == entity.Oštećenja.Id_ostecenja);

            var slika = Entities.SingleOrDefault(s => s.Id_slike == entity.Id_slike);

            slika.Id_slike = entity.Id_slike;
            slika.oglas_id = entity.oglas_id;
            slika.slika1 = entity.slika1;
            slika.Oštećenja = ostecenja;
            slika.ostecenje_id = entity.ostecenje_id;

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
