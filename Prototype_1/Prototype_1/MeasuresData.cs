using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    class MeasuresData
    {
        int sample_size;
        public double[] U;
        public double[] L;
        public double[] M;
        public double[] N;

        public MeasuresData()
        {
            U = new double[0];
            L = new double[0];
            M = new double[0];
            N = new double[0];
        }

        public MeasuresData(int rowCount)
        {
            this.sample_size = rowCount;
            U = new double[rowCount];
            L = new double[rowCount];
            M = new double[rowCount];
            N = new double[rowCount];
        }

        public int Length
        {
            get { return sample_size; }
        }
    }

}
