﻿using DataAccessLayer.Repositories;
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

        public Korisnik GetKorisnikById(int id)
        {
            using(var repo = new KorisnikRepository())
            {
                Korisnik korisnik = repo.GetKorisnikById(id).FirstOrDefault();

                return korisnik;
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


        //Danijel Žebčević
        public Korisnik Login(string ime, string loz)
        {
            using (var repo = new KorisnikRepository())
            {
                //dohvaćanje prvog(ujedno i posljednjeg) korisnika sa pripadajućim imenom i lozinkom
                Korisnik korisnici = repo.PrijaviKorisnika(ime, loz).FirstOrDefault();

                return korisnici;
            }
        }

        //Danijel Žebčević
        public Korisnik ChangePassword(string korime, string telefon, string ime, string prezime)
        {
            using (var repo = new KorisnikRepository())
            {
                //poziv repozitorija za mijenjanje lozinke
                List<Korisnik> korisnici = repo.MijenjajLozinku(korime, telefon, ime, prezime).ToList();

                //vraćanje rezultata ovisno o uspjehu
                if (korisnici.Count > 0)
                {
                    return korisnici[0];
                }
                return null;
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
