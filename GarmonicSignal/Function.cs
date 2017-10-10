using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GarmonicSignal
{
    public class Function
    {
        // Changable values
        public double Amplitude { get; set; }
        public double Frequency { get; set; }
        public double Phase { get; set; }
        public int N { get; set; }

        public Function(int a, int f, double phase, int N)
        {
            Amplitude = a;
            Frequency = f;
            Phase = phase;
            this.N = N;
        }

        /// <summary>
        /// A method that returns function value
        /// </summary>
        /// <param name="n"></param>
        /// <returns>The value of function</returns>
        public double GetValue(int n) => Amplitude * Math.Sin((2 * Math.PI * Frequency * n) / N + Phase);

        public List<double> GetListOfValues()
        {
            var list = new List<double>();

            for (int n = 0; n < N; n++)
            {
                double x = Amplitude * Math.Sin((2 * Math.PI * Frequency * n) / N + Phase);

                list.Add(x);
            }

            return list;
        }
    }
}
