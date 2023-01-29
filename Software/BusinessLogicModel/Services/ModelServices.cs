using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class ModelServices
    {
        public List<Model> GetModels()
        {
            using (var repo = new ModelRepository())
            {
                List<Model> modeli = repo.GetAll().ToList();

                return modeli;
            }
        }

        public List<Model> GetCertainModelsByName(string phrase)
        { 
            using (var repo = new ModelRepository())
            {
                List<Model> modeli = repo.GetCertainModelsByName(phrase).ToList();

                return modeli;
            }
        }

        public List<Model> GetCertainModels(int phrase)
        { 
            using (var repo = new ModelRepository())
            {
                List<Model> modeli = repo.GetCertainModel(phrase).ToList();

                return modeli;
            }
        }


        public List<double> GetModelPrice(int id)
        {
            using (var repo = new ModelRepository())
            {
                List<double> price =  repo.GetModelPrice(id).ToList();

                return price;
            }
        }

        public bool AddModel(Model model)
        {
            bool isSuccesful = false;
            using (var repo = new ModelRepository())
            {
                int affectedRow = repo.Add(model);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateModel(Model model)
        {
            bool isSuccesful = false;
            using (var repo = new ModelRepository())
            {
                int affectedRow = repo.Update(model);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveModel(Model model)
        {
            bool isSuccesful = false;
            using (var repo = new ModelRepository())
            {
                int affectedRow = repo.Remove(model);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
