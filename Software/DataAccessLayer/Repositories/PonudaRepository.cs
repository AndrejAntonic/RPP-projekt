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
            return base.Add(entity, saveChanges);
        }

        public override int Update(Ponuda entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
