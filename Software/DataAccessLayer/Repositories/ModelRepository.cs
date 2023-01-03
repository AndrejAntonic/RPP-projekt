using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ModelRepository : Repository<Model>
    {
        public ModelRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Model> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Model> GetCertainModel(int phrase)
        {
            var query = from e in Entities
                        where e.marka_id == phrase
                        select e;

            return query;
        }

        public override int Add(Model entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Model entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
