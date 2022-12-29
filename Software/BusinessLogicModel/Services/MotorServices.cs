using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel.Services
{
    public class MotorServices
    {
        public List<Motor> GetMotors()
        {
            using (var repo = new MotorRepository())
            {
                List<Motor> motors = repo.GetAll().ToList();

                return motors;
            }
        }

        public List<Motor> GetCertainMotors(string phrase)
        {
            using (var repo = new MotorRepository())
            {
                List<Motor> motors = repo.GetCertainMotor(phrase).ToList();

                return motors;
            }
        }

        public bool AddMotor(Motor motor)
        {
            bool isSuccesful = false;
            using (var repo = new MotorRepository())
            {
                int affectedRow = repo.Add(motor);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateMotor(Motor motor)
        {
            bool isSuccesful = false;
            using (var repo = new MotorRepository())
            {
                int affectedRow = repo.Update(motor);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveMotor(Motor motor)
        {
            bool isSuccesful = false;
            using (var repo = new MotorRepository())
            {
                int affectedRow = repo.Remove(motor);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
