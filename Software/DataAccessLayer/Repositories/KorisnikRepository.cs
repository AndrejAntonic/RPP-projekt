using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KorisnikRepository : Repository<Korisnik>
    {
        public KorisnikRepository() : base(new AutoPrimeModel())
        {

        }

        public override IQueryable<Korisnik> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public IQueryable<Korisnik> GetCertainKorisnik(string phrase)
        {
            var query = from e in Entities
                        where e.Ime.Contains(phrase) || e.Prezime.Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Korisnik entity, bool saveChanges = true)
        {
            return base.Add(entity, saveChanges);
        }

        public override int Update(Korisnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
