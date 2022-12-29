using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OstecenjaRepository : Repository<Oštećenja>
    {
        public OstecenjaRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Oštećenja> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Oštećenja> GetCertainOstecenja(string phrase)
        {
            var query = from e in Entities
                        where e.Id_ostecenja.ToString().Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Oštećenja entity, bool saveChanges = true)
        {
            var ostecenja = new Oštećenja
            {
                Id_ostecenja = entity.Id_ostecenja,
                opis_ostecenja = entity.opis_ostecenja,
                Slikas = entity.Slikas
            };

            Entities.Add(ostecenja);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Oštećenja entity, bool saveChanges = true)
        {
            var ostecenja = Entities.SingleOrDefault(o => o.Id_ostecenja == entity.Id_ostecenja);

            ostecenja.Id_ostecenja = entity.Id_ostecenja;
            ostecenja.opis_ostecenja = entity.opis_ostecenja;
            ostecenja.Slikas = entity.Slikas;


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
