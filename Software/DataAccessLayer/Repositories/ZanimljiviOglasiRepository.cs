using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ZanimljiviOglasiRepository : Repository<Zanimljivi_oglasi>
    {
        public ZanimljiviOglasiRepository() : base(new AutoPrimeModel())
        {

        }

        public override IQueryable<Zanimljivi_oglasi> GetAll()
        {
            var query = from e in Entities
                        select e;

            return query;
        }

        public override int Add(Zanimljivi_oglasi entity, bool saveChanges = true)
        {
            var zanimiljiviOglas = new Zanimljivi_oglasi
            {
                Korisnik_id = entity.Korisnik_id,
                Oglas_id = entity.Oglas_id
            };

            Entities.Add(zanimiljiviOglas);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Zanimljivi_oglasi entity, bool saveChanges = true)
        {
            var zanimljiviOglasi = Entities.SingleOrDefault(z => z.Oglas_id == entity.Oglas_id);

            zanimljiviOglasi.Korisnik_id = entity.Korisnik_id;
            zanimljiviOglasi.Oglas_id = entity.Oglas_id;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
