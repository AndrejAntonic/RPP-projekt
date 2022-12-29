using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class PonudaServices
    {
        public List<Ponuda> GetPonudas()
        {
            using (var repo = new PonudaRepository())
            {
                List<Ponuda> ponude = repo.GetAll().ToList();

                return ponude;
            }
        }

        public List<Ponuda> GetCertainPonudas(string phrase)
        {
            using (var repo = new PonudaRepository())
            {
                List<Ponuda> ponude = repo.GetCertainPonuda(phrase).ToList();

                return ponude;
            }
        }

        public bool AddPonuda(Ponuda ponuda)
        {
            bool isSuccesful = false;
            using (var repo = new PonudaRepository())
            {
                int affectedRow = repo.Add(ponuda);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdatePonuda(Ponuda ponuda)
        {
            bool isSuccesful = false;
            using (var repo = new PonudaRepository())
            {
                int affectedRow = repo.Update(ponuda);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemovePonuda(Ponuda ponuda)
        {
            bool isSuccesful = false;
            using (var repo = new PonudaRepository())
            {
                int affectedRow = repo.Remove(ponuda);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
