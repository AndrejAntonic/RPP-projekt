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

        public List<Zanimljivi_oglasi> GetZanimljiviOglasiById(int id)
        {
            using (var repo = new ZanimljiviOglasiRepository())
            {
                List<Zanimljivi_oglasi> oglasi = repo.GetForUser(id).ToList();

                return oglasi;
            }
        }
    }
}
