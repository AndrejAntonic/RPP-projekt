using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class IznajmljenoServices
    {
        public List<Iznajmljeno> GetAukcije()
        {
            using (var repo = new IznajmljenoRepository())
            {
                List<Iznajmljeno> iznajmljenoo = repo.GetAll().ToList();

                return iznajmljenoo;
            }
        }

        public bool AddIznajmljeno(Iznajmljeno iznajmljeno)
        {
            bool isSuccesful = false;
            using (var repo = new IznajmljenoRepository())
            {
                int affectedRow = repo.Add(iznajmljeno);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateIznajmljeno(Iznajmljeno iznajmljeno)
        {
            bool isSuccesful = false;
            using (var repo = new IznajmljenoRepository())
            {
                int affectedRow = repo.Update(iznajmljeno);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveIznajmljeno(Iznajmljeno iznajmljeno)
        {
            bool isSuccesful = false;
            using (var repo = new IznajmljenoRepository())
            {
                int affectedRow = repo.Remove(iznajmljeno);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
