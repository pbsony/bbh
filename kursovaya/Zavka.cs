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
    public partial class Zavka : Form
    {
        public Zavka()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new MenuClient();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty))
            { textBox4.Text = "введите обязательные значения"; }
            else
            if (radioButton1.Checked)
            {
                myCommand1.Parameters["@fio"].Value = textBox1.Text;
                myCommand1.Parameters["@nomer"].Value = textBox2.Text;
                myCommand1.Parameters["@ssilka"].Value = textBox3.Text;
                mySqlConnection.Open();
                myCommand1.ExecuteNonQuery();
                mySqlConnection.Close();

                textBox4.Text = "заявка принята.ожидайте ответа в течение 10-ти дней";
                this.Hide();
                Form frm = new App();
                frm.Show();
                
            }
            else
                textBox4.Text = "примите условия";
        }
    }
}
