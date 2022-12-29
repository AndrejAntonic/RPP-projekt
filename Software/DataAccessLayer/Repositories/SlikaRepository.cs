using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class SlikaRepository : Repository<Slika>
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

        public IQueryable<Slika> GetCertainAuction(string phrase)
        {
            var query = from e in Entities
                        where e.Id_slike.ToString().Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Slika entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Slika entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
