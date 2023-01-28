using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class Kreirao_aukcije_korisnikServices
    {
        public List<Kreirao_aukcije_korisnik> GetKreirao_Aukcije_Korisniks()
        {
            using (var repo = new Kreirao_aukcije_korisnikRepository())
            {
                List<Kreirao_aukcije_korisnik> kreirao_Aukcije_Korisniks = repo.GetAll().ToList();

                return kreirao_Aukcije_Korisniks;
            }
        }

        public Korisnik GetKorisnikFromAukcija(int aukcija_id)
        {
            using (var repo = new Kreirao_aukcije_korisnikRepository())
            {
                Korisnik korisniks = repo.GetKorisnikFromAukcija(aukcija_id).FirstOrDefault();
                return korisniks;
            }
        }

        public bool AddKreiraoAukcijeKorisnik(Kreirao_aukcije_korisnik kreiraoAukcijeKorisnik)
        {
            bool isSuccesful = false;
            using (var repo = new Kreirao_aukcije_korisnikRepository())
            {
                int affectedRow = repo.Add(kreiraoAukcijeKorisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateKreiraoAukcijeKorisnik(Kreirao_aukcije_korisnik kreiraoAukcijeKorisnik)
        {
            bool isSuccesful = false;
            using (var repo = new Kreirao_aukcije_korisnikRepository())
            {
                int affectedRow = repo.Update(kreiraoAukcijeKorisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveKreiraoAukcijeKorisnik(Kreirao_aukcije_korisnik kreiraoAukcijeKorisnik)
        {
            bool isSuccesful = false;
            using (var repo = new Kreirao_aukcije_korisnikRepository())
            {
                int affectedRow = repo.Remove(kreiraoAukcijeKorisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
