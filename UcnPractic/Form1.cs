using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double z = double.Parse(textBoxZ.Text);
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text); 
            //количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;
            //массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double[] t1 = new double[count];
            double[] t2 = new double[count];
            //расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                //вычисляем значение
                X[i] = Xmin + Step * i;
                //вычисляем значение функций в точке X
                t1[i] = (a * Math.Pow(x, 2)) + (b * x) + c;
                t2[i] = (2 * Math.Cos(x - (Math.PI / 6))) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + (Math.Pow(z, 2) / ((3 - Math.Pow(z, 2)) / 5)));
            }
            //настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            //определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            //добавляем вычисление значения в графики
            chart1.Series[0].Points.DataBindXY(X, t1);
            chart1.Series[1].Points.DataBindXY(X, t2);
        }
    }
}
