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

        public IQueryable<Recenzija> GetCertainRecenzija(string phrase)
        {
            var query = from e in Entities
                        where e.Id_recenzije.ToString().Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Recenzija entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Recenzija entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
