using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MotorRepository : Repository<Motor>
    {
        public MotorRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Motor> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Motor> GetCertainMotor(string phrase)
        {
            var query = from e in Entities
                        where e.vrsta.Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Motor entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Motor entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
