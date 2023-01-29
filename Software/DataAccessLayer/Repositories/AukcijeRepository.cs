using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AukcijeRepository : Repository<Aukcije>
    {
        public AukcijeRepository() : base (new AutoPrimeModel())
        {

        }

        private Ponuda ponudaa = new Ponuda();

        public override IQueryable<Aukcije> GetAll()
        {
            var query = from e in Entities
                        .Include("Motor")
                        .Include("Marka")
                        .Include("Model")
                        select e;

            return query;
        }

        public IQueryable<Aukcije> GetLast()
        {
            var query = from e in Entities
                        orderby e.Id_aukcije descending
                        select e;

            return query.Take(1);
        }

        public IQueryable<Aukcije> GetCertainAuction(string phrase)
        {
            var query = from e in Entities
                        .Include("Motor")
                        .Include("Marka")
                        .Include("Model")
                        where e.naziv.Contains(phrase)
                        select e;

            return query;
        }

        public override int Add(Aukcije entity, bool saveChanges = true)
        {
            var markae = Context.Markas.SingleOrDefault(m => m.Id_marka == entity.Marka.Id_marka);
            var modelae = Context.Models.SingleOrDefault(m => m.Id_model == entity.Model.Id_model);
            var motorae = Context.Motors.SingleOrDefault(m => m.Id_motor == entity.Motor.Id_motor);

            var aukcije = new Aukcije
            {
                naziv = entity.naziv,
                Marka = markae,
                Model = modelae,
                lokacija_vozila = entity.lokacija_vozila,
                godina = entity.godina,
                cijena = entity.cijena,
                kilometraza = entity.kilometraza,
                Motor = motorae,
                datum_aukcije = entity.datum_aukcije,
                rok = entity.rok
            };

            Entities.Add(aukcije);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Aukcije entity, bool saveChanges = true)
        {
            var markae = Context.Markas.SingleOrDefault(m => m.Id_marka == entity.Marka.Id_marka);
            var modelae = Context.Models.SingleOrDefault(m => m.Id_model == entity.Model.Id_model);
            var motorae = Context.Motors.SingleOrDefault(m => m.Id_motor == entity.Motor.Id_motor);
            var aukcije = Entities.SingleOrDefault(a => a.Id_aukcije == entity.Id_aukcije);

            aukcije.naziv = entity.naziv;
            aukcije.Marka = markae;
            aukcije.Model = modelae;
            aukcije.Motor = motorae;
            aukcije.lokacija_vozila = entity.lokacija_vozila;
            aukcije.godina = entity.godina;
            aukcije.cijena = entity.cijena;
            aukcije.kilometraza = entity.kilometraza;
            aukcije.datum_aukcije = entity.datum_aukcije;


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
