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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.издательствоDataSet.Клиент);

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Form frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty))
                textBox3.Text = "введите значения";
            else
            {
                myCommand6.Parameters["@fio"].Value = textBox1.Text;
                myCommand6.Parameters["@nomer"].Value = textBox2.Text;
                
                mySqlConnection.Open();
                myCommand6.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand6.Parameters["@x"].Value;

                if (result == 0)
                    textBox3.Text = "запись добавлена";
                if (result == 1)
                    textBox3.Text = "клиент уже существует";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand1.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand1.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCommand8.Parameters["@par"].Value = textBox9.Text;
            mySqlConnection.Open();
            myCommand8.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand8.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == String.Empty)
                textBox5.Text = "введите ID";
            else
            {
                try
                {
                    myCommand7.Parameters["@id"].Value = Convert.ToInt32(textBox4.Text);
                    mySqlConnection.Open();
                    myCommand7.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand7.Parameters["@x"].Value;

                    if (result == 0)
                        textBox5.Text = "клиент удалён";
                    if (result == 1)
                        textBox5.Text = "несуществующий ID";
                }
                catch { textBox5.Text = "клиент не может быть удалён";
                    mySqlConnection.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text == String.Empty) | (textBox7.Text == String.Empty))
                textBox8.Text = "введите все данные";
            else
            {
                myCommand9.Parameters["@id"].Value = Convert.ToInt32(textBox6.Text);
                myCommand9.Parameters["@newnomer"].Value = textBox7.Text;
                mySqlConnection.Open();
                myCommand9.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand9.Parameters["@x"].Value;

                if (result == 0)
                    textBox8.Text = "номер изменен";
                if (result == 1)
                    textBox8.Text = "несуществующий ID";
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
