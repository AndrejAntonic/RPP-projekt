using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AukcijeRepository : Repository<Aukcije>
    {
        public AukcijeRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Aukcije> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Aukcije> GetCertainAuction(string phrase)
        {
            var query = from e in Entities
                        where e.naziv.Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Aukcije entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Aukcije entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
