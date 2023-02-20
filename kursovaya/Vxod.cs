using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Vxod : Form
    {
        public Vxod()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Администратор")
            {
                Form frm = new Menu();
                frm.Show();
                this.Hide();
            }

            if (comboBox1.Text == "Клиент")
            {
                Form frm = new MenuClient();
                frm.Show();
                this.Hide();
            }

            if ( (comboBox1.Text != "Администратор") | (comboBox1.Text != "Клиент"))
            {
                textBox1.Text="ошибка входа : выберите корректную роль";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
