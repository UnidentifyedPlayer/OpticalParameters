using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Prototype_1
{
    class MainController
    {
        DiffuseModule data_module;
        
        public MainController()
        {
            data_module = new DiffuseModule();
        }

        public MeasuresData OpenNewFile()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                //FileInfo last_file = null;

                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileInfo new_file = new FileInfo(openFileDialog1.FileName);
                    return ReadMeasureData(new_file);
                }
                else
                { return new MeasuresData(); }
            }
        }
        public void SaveMeasureData(MeasuresData data)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileInfo new_file = new FileInfo(openFileDialog1.FileName);
                    WriteMeasureData(new_file, data);
                }
            }
        }

        private void WriteMeasureData(FileInfo new_file, MeasuresData data)
        {
            using (StreamWriter sw = new StreamWriter(new_file.FullName, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(data.Length);
                for(int i = 0; i< data.Length; i++)
                {
                    string measure = "";
                    measure +=
                          Convert.ToString(data.L[i]) +
                    " " + Convert.ToString(data.M[i]) +
                    " " + Convert.ToString(data.N[i]) +
                    " " + Convert.ToString(data.U[i]);
                    sw.WriteLine(measure);
                }
            }
        }

        private MeasuresData ReadMeasureData(FileInfo new_file)
        {
            MeasuresData data;
            using (StreamReader sr = new StreamReader(new_file.FullName))
            {
                string num = sr.ReadLine();
                int N = Convert.ToInt32(num);
                data = new MeasuresData(N);
                for(int i = 0; i< N; i++)
                {
                    string measure_str = sr.ReadLine();
                    string [] str_arr = measure_str.Split(' ');
                    data.L[i] = Convert.ToDouble(str_arr[0]);
                    data.M[i] = Convert.ToDouble(str_arr[1]);
                    data.N[i] = Convert.ToDouble(str_arr[2]);
                    data.U[i] = Convert.ToDouble(str_arr[3]);
                }
            }
            return data;
            //throw new NotImplementedException();
        }


        public void CalculateParameters(MeasuresData data)
        {
            data_module.SetData(data);
            data_module.CalculateParameters();
        }
        public string GetParams()
        {
            string parameters = "";
            parameters += "p = " + Convert.ToString(data_module.rho)               + '\n';
            parameters += "l = " + Convert.ToString(data_module.l)                 + '\n';
            parameters += "m = " + Convert.ToString(data_module.m)                 + '\n';
            parameters += "n = " + Convert.ToString(data_module.n)                 + '\n';
            parameters += "Дисперсия p = " + Convert.ToString(data_module.sig_rho) + '\n';
            parameters += "Дисперсия l = " + Convert.ToString(data_module.sig_l)   + '\n';
            parameters += "Дисперсия m = " + Convert.ToString(data_module.sig_m)   + '\n';
            parameters += "Дисперсия n = " + Convert.ToString(data_module.sig_n)   + '\n';
            return parameters;
        }
    }
}
