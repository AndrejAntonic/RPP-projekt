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
