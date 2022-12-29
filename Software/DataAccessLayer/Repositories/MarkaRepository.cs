using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MarkaRepository : Repository<Marka>
    {
        public MarkaRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Marka> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Marka> GetCertainMarka(string phrase)
        {
            var query = from e in Entities
                        where e.Naziv.Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Marka entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Marka entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
