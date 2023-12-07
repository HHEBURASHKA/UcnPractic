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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxChildren.SelectedItem.ToString() == "С детьми")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtData.Text = Calendar.SelectionStart.ToShortDateString();
        }
    }
}
