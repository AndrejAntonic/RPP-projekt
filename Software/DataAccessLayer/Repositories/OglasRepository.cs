using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OglasRepository : Repository<Ogla>
    {
        public OglasRepository() : base (new AutoPrimeModel())
        {

        }
        public override IQueryable<Ogla> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Ogla> GetCertainOglas(string phrase)
        {
            var query = from e in Entities
                        where e.naziv.Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Ogla entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Ogla entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
