using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class SlikaServices
    {
        public List<Slika> GetSlikas()
        {
            using (var repo = new SlikaRepository())
            {
                List<Slika> slike = repo.GetAll().ToList();

                return slike;
            }
        }

        public List<Slika> GetCertainSlikas(int idOglasa)
        {
            using (var repo = new SlikaRepository())
            {
                List<Slika> slike = repo.GetCertainSlika(idOglasa).ToList();

                return slike;
            }
        }

        public bool AddSlika(Slika slika)
        {
            bool isSuccesful = false;
            using (var repo = new SlikaRepository())
            {
                int affectedRow = repo.Add(slika);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateSlika(Slika slika)
        {
            bool isSuccesful = false;
            using (var repo = new SlikaRepository())
            {
                int affectedRow = repo.Update(slika);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveSlika(Slika slika)
        {
            bool isSuccesful = false;
            using (var repo = new SlikaRepository())
            {
                int affectedRow = repo.Remove(slika);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
