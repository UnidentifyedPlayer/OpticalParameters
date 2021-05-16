using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_1
{
    public partial class Form1 : Form
    {
        MainController controller;
        MeasuresData cur_data;
        public Form1()
        {
            InitializeComponent();
            controller = new MainController();
            cur_data = new MeasuresData();
            label1.Text = "";
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {

            MeasuresData data = controller.OpenNewFile();
            DisplayData(data);
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            MeasuresData data = GetDataFromGrid();
            controller.CalculateParameters(data);
            label1.Text = controller.GetParams();
        }

        private void add_row_button_Click(object sender, EventArgs e)
        {
            data_view.Rows.Add();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            MeasuresData data = GetDataFromGrid();
            controller.SaveMeasureData(data);
        }

        private MeasuresData GetDataFromGrid()
        {
            MeasuresData data = new MeasuresData(data_view.RowCount);
            for (int i = 0; i < data_view.RowCount; i++)
            {
                //if(data_view[i, 0].)
                data.L[i] = Convert.ToDouble(data_view[0, i].Value);
                data.M[i] = Convert.ToDouble(data_view[1, i].Value);
                data.N[i] = Convert.ToDouble(data_view[2, i].Value);
                data.U[i] = Convert.ToDouble(data_view[3, i].Value);
            }
            return data;
        }

        private void DisplayData(MeasuresData data) {
            data_view.Rows.Clear();
            data_view.Rows.Add(data.Length);
            for(int i = 0; i< data.Length; i++)
            {
                data_view[0, i].Value = Convert.ToString(data.L[i]);
                data_view[1, i].Value = Convert.ToString(data.M[i]);
                data_view[2, i].Value = Convert.ToString(data.N[i]);
                data_view[3, i].Value = Convert.ToString(data.U[i]);
            }

        }
    }
}
