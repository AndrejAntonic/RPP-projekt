using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class MarkaServices
    {
        public List<Marka> GetMarkas()
        {
            using (var repo = new MarkaRepository())
            {
                List<Marka> marke = repo.GetAll().ToList();

                return marke;
            }
        }

        public List<Marka> GetCertainMarkas(string phrase)
        {
            using (var repo = new MarkaRepository())
            {
                List<Marka> marke = repo.GetCertainMarka(phrase).ToList();

                return marke;
            }
        }

        public bool AddMarku(Marka marka)
        {
            bool isSuccesful = false;
            using (var repo = new MarkaRepository())
            {
                int affectedRow = repo.Add(marka);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateMarku(Marka marka)
        {
            bool isSuccesful = false;
            using (var repo = new MarkaRepository())
            {
                int affectedRow = repo.Update(marka);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveMarku(Marka marka)
        {
            bool isSuccesful = false;
            using (var repo = new MarkaRepository())
            {
                int affectedRow = repo.Remove(marka);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
