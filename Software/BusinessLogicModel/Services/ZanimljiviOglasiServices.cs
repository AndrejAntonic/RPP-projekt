using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class ZanimljiviOglasiServices
    {
        public List<Zanimljivi_oglasi> GetZanimljiviOglasi()
        {
            using (var repo = new ZanimljiviOglasiRepository())
            {
                List<Zanimljivi_oglasi> oglasi = repo.GetAll().ToList();

                return oglasi;
            }
        }

        public List<Zanimljivi_oglasi> GetZanimljiviOglasiByUserId(int id)
        {
            using (var repo = new ZanimljiviOglasiRepository())
            {
                List<Zanimljivi_oglasi> oglasi = repo.GetForUser(id).ToList();

                return oglasi;
            }
        }

        public List<Zanimljivi_oglasi> GetZanimljiviOglasiByOglasId(int id)
        {
            using (var repo = new ZanimljiviOglasiRepository())
            {
                List<Zanimljivi_oglasi> oglasi = repo.GetForOglas(id).ToList();

                return oglasi;
            }
        }

        public Zanimljivi_oglasi GetZanimljiviOglasiByOglasUserId(int id_oglas, int id_user)
        {
            using (var repo = new ZanimljiviOglasiRepository())
            {
                Zanimljivi_oglasi oglasi = repo.GetForOglasUser(id_oglas, id_user).FirstOrDefault();

                return oglasi;
            }
        }

        public bool RemoveZanimljiviOglas(Zanimljivi_oglasi oglas)
        {
            bool isSuccesful = false;
            using (var repo = new ZanimljiviOglasiRepository())
            {
                int affectedRow = repo.Remove(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
