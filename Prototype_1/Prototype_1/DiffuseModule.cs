using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    class DiffuseModule
    {
        MeasuresData dataset;
        double Qmn;
        double Qnl;
        double Qlm;
        double Ql;
        double Qm;
        double Qn;
        double Qul;
        double Qum;
        double Qun;
        //double Qnsubm;
        //double Qnsubl;
        //double Qmsubl;
        public double l;
        public double m;
        public double n;
        public double rho;
        public double sig_l;
        public double sig_m;
        public double sig_n;
        public double sig_rho;

        public DiffuseModule( MeasuresData input)
        {
            dataset = input;
        }

        public DiffuseModule()
        {
            InitFields();
        }

        private void InitFields()
        {
            Qmn = 0;
            Qnl = 0;
            Qlm = 0;
            Ql = 0;
            Qm = 0;
            Qn = 0;
            Qul = 0;
            Qum = 0;
            Qun = 0;
            //Qnsubm
            //Qnsubl
            //Qmsubl
            l=0;
            m = 0;
            n = 0;
            rho = 0;
            sig_l = 0;
            sig_m = 0;
            sig_n = 0;
            sig_rho = 0;
        }

        internal void SetData(MeasuresData data)
        {
            dataset = data;
        }

        private void CalculateIntermediateValues()
        {

            int W = dataset.Length;
            for (int i = 0; i< W; i++)
            {
                Ql += dataset.L[i] * dataset.L[i];
                Qm += dataset.M[i] * dataset.M[i];
                Qn += dataset.N[i] * dataset.N[i];
                //Qmsubl += (dataset.M[i] - dataset.L[i]) * (dataset.M[i] - dataset.L[i]);
                //Qnsubl += (dataset.N[i] - dataset.L[i]) * (dataset.M[i] - dataset.L[i]);
                //Qnsubm += (dataset.N[i] - dataset.N[i]) * (dataset.M[i] - dataset.L[i]);
                Qmn += dataset.M[i] * dataset.N[i];
                Qnl += dataset.N[i] * dataset.L[i];
                Qlm += dataset.L[i] * dataset.M[i];
                Qul += dataset.U[i] * dataset.L[i];
                Qun += dataset.U[i] * dataset.N[i];
                Qum += dataset.U[i] * dataset.M[i];

            }
            Ql = Ql / W;
            Qm = Qm / W;
            Qn = Qn / W;
            Qmn = Qmn / W;
            Qnl = Qnl / W;
            Qlm = Qlm / W;
            Qul = Qul / W;
            Qun = Qun / W;
            Qum = Qum / W;
        }

        public void CalculateParameters()
        {
            CalculateIntermediateValues();

            int W = dataset.Length;
            double D = Math.Pow(W, 3) * (Ql * Qn * Qm + 2 * Qlm * Qmn * Qnl - Qnl * Qnl * Qm - Qlm * Qlm * Qn - Qmn * Qmn * Ql);

            double Dp = Math.Pow(W, 3) * (Qul * (Qn * Qm - Qmn * Qmn) + Qum * (Qnl * Qmn - Qlm * Qn) + Qun * (Qlm * Qmn - Qnl * Qm));

            double Dq = Math.Pow(W,3) * (Qul * (Qmn * Qnl - Qlm * Qn) + Qum * (Ql * Qn - Qnl * Qnl) + Qun * (Qlm * Qnl - Qmn * Ql));

            double Dh = Math.Pow(W, 3) * (Qul * (Qmn * Qlm - Qnl * Qm) + Qum * (Qlm * Qnl - Qmn * Ql) + Qun * (Ql * Qm - Qlm *Qlm));

            double p = Dp / D;
            double q = Dq / D;
            double h = Dh / D;

            rho = Math.Sqrt(p * p + q * q + h * h);
            l = p / rho;
            m = q / rho;
            n = h / rho;

            double D11 = Math.Pow(W, 2) * (Qm * Qn - Qmn * Qmn);
            double D22 = Math.Pow(W, 2) * (Ql * Qn - Qnl * Qnl);
            double D33 = Math.Pow(W, 2) * (Qm * Ql - Qlm * Qlm);

            double discrep = this.CalculateDiscrepancy(p, q, h);

            double sig_p = (D11 / D) * discrep / (dataset.Length - 3);
            double sig_q = (D22 / D) * discrep / (dataset.Length - 3);
            double sig_h = (D33 / D) * discrep / (dataset.Length - 3);

            sig_rho = (p * p * sig_p * sig_p + q * q * sig_q * sig_q + h * h * sig_h * sig_h) / (p * p + q * q + h * h);
            sig_l = (Math.Pow((q * q + h * h) * sig_p, 2) + Math.Pow((h * q * sig_q), 2) + Math.Pow((h * p * sig_h), 2))
                / Math.Pow((p * p + q * q + h * h), 3);
            sig_m = (Math.Pow((q * p * sig_p), 2) + Math.Pow((p * p + h * h) * sig_q, 2) + Math.Pow((h * q * sig_h), 2))
                / Math.Pow((p * p + q * q + h * h), 3);
            sig_n = (Math.Pow((q * p * sig_p), 2) + Math.Pow((h * q * sig_q) + Math.Pow((q * q +p * p) * sig_h, 2), 2))
                / Math.Pow((p * p + q * q + h * h), 3);
        }

        private double CalculateDiscrepancy(double p, double q, double h)
        {
            double discrep = 0;
            for(int i = 0; i < dataset.Length; i++)
            {
                double temp = dataset.U[i] - dataset.L[i] * p - dataset.M[i] * q - dataset.N[i] * h;
                discrep += Math.Pow(temp, 2);
            }
            return discrep;
        }


    }
}
