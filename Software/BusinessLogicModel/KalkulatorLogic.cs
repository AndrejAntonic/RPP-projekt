using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel
{
    public class KalkulatorLogic
    {
        public List<Double> CalculateBasedOnAge(double price, int year)
        {
            List<Double> listValues = new List<double>();

            for(int i = 1; i <= year; i++)
            {
                if(i == 1)
                {
                    price = price - (price * 0.24);
                }
                else
                {
                    price = price - (price * 0.15);
                }
                listValues.Add(price);
            }

            return listValues;
        }

        public Double CalculateBasedOnKilometers(double price, double mileage)
        {
            return price - (mileage * 0.33);
        }
    }
}
