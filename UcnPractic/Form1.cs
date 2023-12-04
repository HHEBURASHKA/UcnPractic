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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelAnswer.Text = "?";
            if (radioButton1.Checked)
            {
                // Показать поля для ввода и вывода, если выбран первый RadioButton
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                labelM.Visible = true;
                labelN.Visible = true;
                labelС.Visible = true;
                labelEquals.Visible = true;
                labelAnswer.Visible = true;
                // Скрыть поля для ввода и вывода, если выбран другой RadioButton
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                labelA.Visible = false;
                labelP.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelAnswer.Text = "?";
            if (radioButton2.Checked)
            {
                // Показать поля для ввода и вывода, если выбран первый RadioButton
                textBox3.Visible = true;
                textBox4.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                labelM.Visible = true;
                labelN.Visible = true;
                labelEquals.Visible = true;
                labelAnswer.Visible = true;
                labelA.Visible = true;
                // Скрыть поля для ввода и вывода, если выбран другой RadioButton
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox5.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                labelС.Visible = false;
                labelP.Visible = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            labelAnswer.Text = "?";
            if (radioButton3.Checked)
            {
                // Показать поля для ввода и вывода, если выбран первый RadioButton
                textBox5.Visible = true;
                label5.Visible = true;
                labelN.Visible = true;
                labelEquals.Visible = true;
                labelAnswer.Visible = true;
                labelP.Visible = true;
                // Скрыть поля для ввода и вывода, если выбран другой RadioButton
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                labelM.Visible = false;
                labelС.Visible = false;
                labelA.Visible = false;
            }
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Расчет C при выборе первого RadioButton
                if (int.TryParse(textBox1.Text, out int n) && int.TryParse(textBox2.Text, out int m))
                {
                    double result = CalculateC(n, m);
                    labelAnswer.Text = $"{result}";
                }
                else
                {
                    MessageBox.Show("Решение невозможно, неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearFields();
            }
            else if (radioButton2.Checked)
            {
                // Расчет A при выборе второго RadioButton
                if (int.TryParse(textBox3.Text, out int n) && int.TryParse(textBox4.Text, out int m))
                {
                    double result = CalculateA(n, m);
                    labelAnswer.Text = $"{result}";
                }
                else
                {
                    MessageBox.Show("Решение невозможно, неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearFields();
            }
            else if (radioButton3.Checked)
            {
                if (int.TryParse(textBox5.Text, out int n))
                {
                    double result = CalculateP(n);
                    labelAnswer.Text = $"{result}";
                }
                else
                {
                    MessageBox.Show("Решение невозможно, неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearFields();
            }
        }

        // Метод для вычисления C
        private double CalculateC(int n, int m)
        {
            return Factorial(n) / (Factorial(m) * Factorial(n - m));
        }

        // Метод для вычисления A
        private double CalculateA(int n, int m)
        {
            return Factorial(n) / Factorial(n - m);
        }

        // Метод для вычисления факториала числа
        private double Factorial(int num)
        {
            double factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Метод для вычисления P
        private double CalculateP(int num)
        {
            double factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;   
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox5.Text, out int number))
            {
                textBox5.Text = "";
            }
            else if (number > 10 || number < 0)
            {
                MessageBox.Show("Число должно быть от 0 до 10.");
                textBox5.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int number))
            {
                textBox1.Text = "";
            }
            else if (number > 10 || number < 0)
            {
                MessageBox.Show("Число должно быть от 0 до 10.");
                textBox1.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox4.Text, out int number))
            {
                textBox4.Text = "";
            }
            else if (number > 10 || number < 0)
            {
                MessageBox.Show("Число должно быть от 0 до 10.");
                textBox4.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int number))
            {
                textBox3.Text = "";
            }
            else if (number > 10 || number < 0)
            {
                MessageBox.Show("Число должно быть от 0 до 10.");
                textBox3.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int number))
            {
                textBox2.Text = "";
            }
            else if (number > 10 || number < 0)
            {
                MessageBox.Show("Число должно быть от 0 до 10.");
                textBox2.Text = "";
            }
        }
    }
}
