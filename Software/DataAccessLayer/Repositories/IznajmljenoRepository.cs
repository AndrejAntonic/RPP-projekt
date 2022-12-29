using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class IznajmljenoRepository : Repository<Iznajmljeno>
    {
        public IznajmljenoRepository() : base(new AutoPrimeModel())
        {

        }

        public override IQueryable<Iznajmljeno> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public override int Add(Iznajmljeno entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Iznajmljeno entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
