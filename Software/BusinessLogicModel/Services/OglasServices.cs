using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class OglasServices
    {
        public List<Ogla> GetOglas()
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> oglasi = repo.GetAll().ToList();

                return oglasi;
            }
        }

        public List<Ogla> GetCertainOglass(string phrase)
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> oglasi = repo.GetCertainOglas(phrase).ToList();

                return oglasi;
            }
        }

        public Ogla GetOneOglasById(int id)
        {
            using(var repo = new OglasRepository())
            {
                Ogla ogla = repo.GetOneOglasByOglasId(id).FirstOrDefault();

                return ogla;
            }
        }

        public List<Ogla> GetOglasByKorisnikId(int id)
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> oglasi = repo.GetOglasByKorisnikId(id).ToList();

                return oglasi;
            }
        }

        public List<Ogla> GetLeasingOglas()
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> oglasi = repo.GetAll().ToList();
                List<Ogla> result = new List<Ogla>();

                foreach (var item in oglasi)
                {
                    if (item.leasing == 1)
                    {
                        result.Add(item);
                    }
                }

                return result;
            }
        }

        public List<Ogla> GetSimilarOglas(Ogla trenutni)
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> sviOglasi = repo.GetAll().ToList();
                List<Ogla> result = new List<Ogla>();

                foreach (var item in sviOglasi)
                {
                    int slicnost = 0;

                    int cijena = int.Parse(item.cijena);
                    int cijena2 = int.Parse(trenutni.cijena);
                    if (item.leasing == trenutni.leasing)
                    {
                        slicnost++;
                    }
                    if (Math.Abs(cijena-cijena2) <= 5000 )
                    {
                        slicnost++;
                    }
                    if (item.godina == trenutni.godina)
                    {
                        slicnost++;
                    }
                    if (item.motor_id == trenutni.motor_id)
                    {
                        slicnost++;
                    }
                    if (item.Model == trenutni.Model)
                    {
                        slicnost++;
                    }
                    if (slicnost >= 2)
                    {
                        result.Add(item);
                    }
                }
               

                return result;
            }
        }

        public List<Ogla> FilterOglas(string marka, string model, string godina, string kilometraza,string cijena)
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> oglasi = repo.FilterOglas(marka,model,godina,kilometraza,cijena).ToList();

                return oglasi;
            }
        }

        public List<Ogla> GetMostWantedOglas()
        {
            using (var repo = new OglasRepository())
            {
                List<Ogla> oglasi = repo.GetMostWantedOglas().ToList();

                return oglasi;
            }
        }

        public bool AddOglas(Ogla oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.Add(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateOglas(Ogla oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.Update(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateOglasView(Ogla oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.UpdateViewCount(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveOglas(Ogla oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.Remove(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
