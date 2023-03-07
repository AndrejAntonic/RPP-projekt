using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class OstecenjaServices
    {
        public List<Oštećenja> GetOstecenjas()
        {
            using (var repo = new OstecenjaRepository())
            {
                List<Oštećenja> ostecenjas = repo.GetAll().ToList();

                return ostecenjas;
            }
        }

        public List<Oštećenja> GetCertainOstecenjas(string phrase)
        {
            using (var repo = new OstecenjaRepository())
            {
                List<Oštećenja> ostecenjas = repo.GetCertainOstecenja(phrase).ToList();

                return ostecenjas;
            }
        }

        public int GetLastOstecenje()
        {
            using (var repo = new OstecenjaRepository())
            {
                int ostecenjas = repo.GetAllLast().ToList().LastOrDefault();

                return ostecenjas;
            }
        }

        public bool AddOstecenja(Oštećenja ostecenjas)
        {
            bool isSuccesful = false;
            using (var repo = new OstecenjaRepository())
            {
                int affectedRow = repo.Add(ostecenjas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateOstecenja(Oštećenja ostecenjas)
        {
            bool isSuccesful = false;
            using (var repo = new OstecenjaRepository())
            {
                int affectedRow = repo.Update(ostecenjas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveOstecenja(Oštećenja ostecenjas)
        {
            bool isSuccesful = false;
            using (var repo = new OstecenjaRepository())
            {
                int affectedRow = repo.Remove(ostecenjas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
