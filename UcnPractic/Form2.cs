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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int btnChildrenBilClicks = 0;
        private void btnChildrenBil_Click(object sender, EventArgs e)
        {
            // Проверка заполненности полей
            if (!string.IsNullOrEmpty(txtFamChildren.Text) &&
                !string.IsNullOrEmpty(txtNameChildren.Text) &&
                !string.IsNullOrEmpty(txtOthChildren.Text) &&
                !string.IsNullOrEmpty(txtChildrenLet.Text))
            {
                btnChildrenBilClicks++; // Увеличиваем счетчик нажатий кнопки

                // Обновление текста в полях и в lblBil
                txtFamChildren.Text = $" ";
                txtNameChildren.Text = $" ";
                txtOthChildren.Text = $" ";
                txtChildrenLet.Text = $" ";
                lblBil.Text = $"{btnChildrenBilClicks}";
            }
            else
            {
                MessageBox.Show("Заполните все поля перед добавлением билета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
