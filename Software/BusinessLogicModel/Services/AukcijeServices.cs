using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class AukcijeServices
    {
        public List<Aukcije> GetAukcije()
        {
            using(var repo = new AukcijeRepository())
            {
                List<Aukcije> aukcijee = repo.GetAll().ToList();

                return aukcijee;
            }
        }

        public List<Aukcije> GetCertainAukcije(string phrase)
        {
            using (var repo = new AukcijeRepository())
            {
                List<Aukcije> aukcijee = repo.GetCertainAuction(phrase).ToList();

                return aukcijee;
            }
        }

        public bool AddAuction(Aukcije aukcije)
        {
            bool isSuccesful = false;
            using (var repo = new AukcijeRepository())
            {
                int affectedRow = repo.Add(aukcije);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateAuction(Aukcije aukcije)
        {
            bool isSuccesful = false;
            using (var repo = new AukcijeRepository())
            {
                int affectedRow = repo.Update(aukcije);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveAuction(Aukcije aukcije)
        {
            bool isSuccesful = false;
            using (var repo = new AukcijeRepository())
            {
                int affectedRow = repo.Remove(aukcije);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
