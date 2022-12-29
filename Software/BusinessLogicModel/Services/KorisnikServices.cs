using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class KorisnikServices
    {
        public List<Korisnik> GetKorisniks()
        {
            using(var repo = new KorisnikRepository())
            {
                List<Korisnik> korisnici = repo.GetAll().ToList();

                return korisnici;
            }
        }

        public List<Korisnik> GetCertainKorisniks(string phrase)
        {
            using (var repo = new KorisnikRepository())
            {
                List<Korisnik> korisnici = repo.GetCertainKorisnik(phrase).ToList();

                return korisnici;
            }
        }

        public bool AddKorisniks(Korisnik korisnik)
        {
            bool isSuccesful = false;
            using (var repo = new KorisnikRepository())
            {
                int affectedRow = repo.Add(korisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateKorisniks(Korisnik korisnik)
        {
            bool isSuccesful = false;
            using (var repo = new KorisnikRepository())
            {
                int affectedRow = repo.Update(korisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveKorisniks(Korisnik korisnik)
        {
            bool isSuccesful = false;
            using (var repo = new KorisnikRepository())
            {
                int affectedRow = repo.Remove(korisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
