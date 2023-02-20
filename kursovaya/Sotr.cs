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
    public partial class Sotr : Form
    {
        public Sotr()
        {
            InitializeComponent();
        }

        private void сотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.издательствоDataSet.Сотрудник);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty))
                textBox3.Text = "введите значения";
            else
            {
                myCommand6.Parameters["@fio"].Value = textBox1.Text;
                myCommand6.Parameters["@dol"].Value = textBox2.Text;

                mySqlConnection.Open();
                myCommand6.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand6.Parameters["@x"].Value;

                if (result == 0)
                    textBox3.Text = "сотрудник добавлен";
                if (result == 1)
                    textBox3.Text = "сотрудник уже добавлен";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty)
                textBox5.Text = "введите ФИО";
            else
            {
                myCommand7.Parameters["@fio"].Value = textBox4.Text;
                mySqlConnection.Open();
                myCommand7.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand7.Parameters["@x"].Value;

                if (result == 0)
                    textBox5.Text = "сотрудник удалён";
                if (result == 1)
                    textBox5.Text = "сотрудника нет в базе";
                if (result == 2)
                    textBox5.Text = "сотррудник не может быть удалён";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Menu();
            frm.Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text == String.Empty) | (textBox7.Text == String.Empty))
                textBox8.Text = "введите все данные";
            else
            {
                myCommand9.Parameters["@fio"].Value = textBox6.Text;
                myCommand9.Parameters["@newdol"].Value = textBox7.Text;
                mySqlConnection.Open();
                myCommand9.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand9.Parameters["@x"].Value;

                if (result == 0)
                    textBox8.Text = "должность изменена";
                if (result == 1)
                    textBox8.Text = "соттрудник не найден";
            }
        }
    }
}
