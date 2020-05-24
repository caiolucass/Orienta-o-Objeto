using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{

    public class ConversorP
    {
        public double Fahrenheit(double temp)
        {
            return (temp * 1.8 + 32);
        }	
        
        public double Celsius(double temp)
        {
           return((temp - 32)/1.8);
		}
		
		public double Kelvin(double temp)
		{
			return(temp - 273.15);
		}
		   
    }
}
