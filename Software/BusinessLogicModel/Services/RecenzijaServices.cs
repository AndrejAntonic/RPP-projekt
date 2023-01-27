using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class RecenzijaServices
    {
        public List<Recenzija> GetRecenzijas()
        {
            using (var repo = new RecenzijaRepository())
            {
                List<Recenzija> recenzije = repo.GetAll().ToList();

                return recenzije;
            }
        }

        public List<Recenzija> GetRecenzijasForUser(Korisnik korisnik)
        {
            using(var repo = new RecenzijaRepository())
            {
                List<Recenzija> recenzije = repo.GetAllForUser(korisnik).ToList();

                return recenzije;
            }
        }

        public List<Recenzija> GetCertainRecenzijas(string phrase)
        {
            using (var repo = new RecenzijaRepository())
            {
                List<Recenzija> recenzije = repo.GetCertainRecenzija(phrase).ToList();

                return recenzije;
            }
        }

        public bool AddRecenzija(Recenzija recenzija)
        {
            bool isSuccesful = false;
            using (var repo = new RecenzijaRepository())
            {
                int affectedRow = repo.Add(recenzija);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateRecenzija(Recenzija recenzija)
        {
            bool isSuccesful = false;
            using (var repo = new RecenzijaRepository())
            {
                int affectedRow = repo.Update(recenzija);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveRecenzija(Recenzija recenzija)
        {
            bool isSuccesful = false;
            using (var repo = new RecenzijaRepository())
            {
                int affectedRow = repo.Remove(recenzija);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
