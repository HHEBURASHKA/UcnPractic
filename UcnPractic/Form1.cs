using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UcnPractic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculation_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text); 
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);
            double y = double.Parse(textBoxY.Text);
            double z = double.Parse(textBoxZ.Text);
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text); 
            //количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;
            //массив значений X - общий для обоих графиков
            double[] x = new double[count];
            double[] t1 = new double[count];
            double[] t2 = new double[count];
            //расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                //вычисляем значение
                 x[i] = Xmin + Step * i;
                //вычисляем значение функций в точке X
                t1[i] = (a * Math.Pow(x[i], 2)) + (b * x[i]) + c;
                t2[i] = (2 * Math.Cos(x[i] - (Math.PI / 6))) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + (Math.Pow(z, 2) / ((3 - Math.Pow(z, 2)) / 5)));
            }
            //настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            //определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            //добавляем вычисление значения в графики
            chart1.Series[0].Points.DataBindXY(x, t1);
            chart1.Series[1].Points.DataBindXY(x, t2);
        }

        private void textBoxStep_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxStep.Text, out int number))
            {
                textBoxStep.Text = "";
            }
            else if (number < 0.1)
            {
                MessageBox.Show("Шаг должен быть  не меньше 0.1");
                textBoxStep.Text = "";
            }
        }
    }
}
