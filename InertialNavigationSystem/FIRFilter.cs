using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem
{
    class FIRFilter:Filter
    {

        private List<Sample> Memory { get; set; }

        private List<double> Coefficients { get; set; }

        public FIRFilter(List<double> FilterCoefficients)
        {
            double sum = 0;
            foreach(double Coefficient in FilterCoefficients)
                sum += FilterCoefficients[i];

            if (sum != 1)
                throw new Exception("Sum of coefficients must be 1.");

            Coefficients = FilterCoefficients;

            Memory = new List<Sample>(Coefficients.Count);
            
        }

        public double AddSample(Sample sample)
        {
            //tutaj ładnie oblicza wszystko i zwraca przefiltrowaną próbkę
            return 1;
        }

    }
}
