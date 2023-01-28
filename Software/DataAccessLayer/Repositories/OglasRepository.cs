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
                        .Include("Iznajmljeno")
                        .Include("Motor")
                        .Include("Korisnik")
                        .Include("Marka")
                        .Include("Model")
                        select e;

            return query;
        }

        public IQueryable<Ogla> GetCertainOglas(string phrase)
        {
            var query = from e in Entities
                        .Include("Iznajmljeno")
                        .Include("Motor")
                        .Include("Korisnik")
                        .Include("Marka")
                        .Include("Model")
                        where e.naziv.Contains(phrase) 
                        select e;

            return query;
        }

        public IQueryable<Ogla> GetMostWantedOglas()
        {
            var query = from e in Entities
                        orderby e.broj_pregleda descending
                        select e;

            return query.Take(5);
        }

        public IQueryable<Ogla> FilterOglas(string marka,string model,string godina,string kilometraza,string cijena )
        {
            var query = from e in Entities
                        .Include("Iznajmljeno")
                        .Include("Motor")
                        .Include("Korisnik")
                        .Include("Marka")
                        .Include("Model")
                        select e;

            if (!string.IsNullOrEmpty(marka))
            {
                query = query.Where(e=>e.Marka.Naziv == marka);
            }
            
            if (!string.IsNullOrEmpty(model))
            {
                query = query.Where(e => e.Model.naziv == model);
            }
            
            if (!string.IsNullOrEmpty(godina))
            {
                var poljeGodina = godina.Split('-');
                var prvaGOdina = Int32.Parse(poljeGodina[0]);
                var drugaGodina = Int32.Parse(poljeGodina[1]);
                query = query.Where(e => e.godina > prvaGOdina  && e.godina <= drugaGodina);
            }

            if (!string.IsNullOrEmpty(kilometraza))
            {
                var poljeKilometara = kilometraza.Split('-');
                int kilometri1, kilometri2;
                if (int.TryParse(poljeKilometara[0], out kilometri1) && int.TryParse(poljeKilometara[1], out kilometri2))
                {
                    query = query.Where(FilterByKilometraza(kilometri1, kilometri2)).AsQueryable();
                }
            }

            if (!string.IsNullOrEmpty(cijena))
            {
                var poljeCijena = cijena.Split('-');
                int cijena1, cijena2;
                if (int.TryParse(poljeCijena[0], out cijena1) && int.TryParse(poljeCijena[1], out cijena2))
                {
                    query = query.Where(FilterByCijena(cijena1, cijena2)).AsQueryable();
                }
            }

            return query;
        }

        private static Func<Ogla, bool> FilterByKilometraza(int kilometri1, int kilometri2)
        {
            return e =>
            {
                int km;
                return int.TryParse(e.kilometraza, out km) && km > kilometri1 && km <= kilometri2;
            };
        }

        private static Func<Ogla, bool> FilterByCijena(int cijena1, int cijena2)
        {
            return e =>
            {
                int cijena;
                return int.TryParse(e.cijena, out cijena) && cijena > cijena1 && cijena <= cijena2;
            };
        }

        public override int Add(Ogla entity, bool saveChanges = true)
        {
            var markaa = Context.Markas.SingleOrDefault(m => m.Id_marka == entity.Marka.Id_marka);
            var modell = Context.Models.SingleOrDefault(m => m.Id_model == entity.Model.Id_model);
            var motorr = Context.Motors.SingleOrDefault(m => m.Id_motor == entity.Motor.Id_motor);

            var oglass = new Ogla
            {
                Id_oglas = entity.Id_oglas,
                korisnik_id = entity.korisnik_id,
                naziv = entity.naziv,
                Marka = markaa,
                Model = modell,
                lokacija_vozila = entity.lokacija_vozila,
                godina = entity.godina,
                cijena = entity.cijena,
                kilometraza = entity.kilometraza,
                Motor = motorr,
                ostecenje = entity.ostecenje,
                datum = entity.datum,
                leasing = entity.leasing,
                Iznajmljeno = entity.Iznajmljeno,
                broj_pregleda = entity.broj_pregleda,
                prodano = entity.prodano,
                prodano_korisnik_id = entity.korisnik_id
            };

            Entities.Add(oglass);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Ogla entity, bool saveChanges = true)
        {
            var markaa = Context.Markas.SingleOrDefault(m => m.Id_marka == entity.Marka.Id_marka);
            var modell = Context.Models.SingleOrDefault(m => m.Id_model == entity.Model.Id_model);
            var motorr = Context.Motors.SingleOrDefault(m => m.Id_motor == entity.Motor.Id_motor);

            var oglass = Entities.SingleOrDefault(o => o.Id_oglas == entity.Id_oglas);

            //oglass.Id_oglas = entity.Id_oglas;
            //oglass.korisnik_id = entity.korisnik_id;
            oglass.naziv = entity.naziv;
            oglass.Marka = markaa;
            oglass.Model = modell;
            oglass.lokacija_vozila = entity.lokacija_vozila;
            oglass.godina = entity.godina;
            oglass.cijena = entity.cijena;
            oglass.kilometraza = entity.kilometraza;
            oglass.Motor = motorr;
            oglass.ostecenje = entity.ostecenje;
            oglass.datum = entity.datum;
            oglass.leasing = entity.leasing;
            oglass.Iznajmljeno = entity.Iznajmljeno;
            oglass.broj_pregleda = entity.broj_pregleda;
            oglass.prodano = entity.prodano;
            oglass.prodano_korisnik_id = entity.prodano_korisnik_id;

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
