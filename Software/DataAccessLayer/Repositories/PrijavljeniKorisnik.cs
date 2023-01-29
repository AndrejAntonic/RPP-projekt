using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PrijavljeniKorisnik
    {
        public static Korisnik prijavljeniKorisnik = new Korisnik();

        public void NamjestiKorisnika(Korisnik novi)
        {
            prijavljeniKorisnik = novi;
        }

        public Korisnik VratiPrijavljenog()
        {
            return prijavljeniKorisnik;
        }

        public int VratiPrijavljeniId()
        {
            return prijavljeniKorisnik.Id_korisnika;
        }

    }
}
