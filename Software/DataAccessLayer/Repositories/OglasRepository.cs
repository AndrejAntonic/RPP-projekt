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
            var markaa = Context.Markas.SingleOrDefault(m => m.Id_marka == entity.Marka.Id_marka);
            var modell = Context.Models.SingleOrDefault(m => m.Id_model == entity.Model.Id_model);
            var motorr = Context.Motors.SingleOrDefault(m => m.Id_motor == entity.Motor.Id_motor);

            var oglass = new Ogla
            {
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

            oglass.Id_oglas = entity.Id_oglas;
            oglass.korisnik_id = entity.korisnik_id;
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
