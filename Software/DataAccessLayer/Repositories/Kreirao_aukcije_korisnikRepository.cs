using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Kreirao_aukcije_korisnikRepository : Repository<Kreirao_aukcije_korisnik>
    {
        public Kreirao_aukcije_korisnikRepository() : base (new AutoPrimeModel())
        {

        }

        public override IQueryable<Kreirao_aukcije_korisnik> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public override int Add(Kreirao_aukcije_korisnik entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Kreirao_aukcije_korisnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
