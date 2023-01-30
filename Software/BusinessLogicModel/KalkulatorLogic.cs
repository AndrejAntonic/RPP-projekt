using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicModel
{
    public class KalkulatorLogic
    {
        //Andrej Antonić
        public List<double> CalculateBasedOnAge(double price, int year) //Računanje vrijednosti automobila na prvi način
        {
            List<double> listValues = new List<double>();

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

        public double CalculateBasedOnKilometers(double price, double mileage) //Računanje vrijednosti automobila na drugi način
        {
            double calculatedPrice = price - (mileage * 0.33);
            if (calculatedPrice > 0)
                return calculatedPrice;
            else
                return 0;
        }
    }
}
