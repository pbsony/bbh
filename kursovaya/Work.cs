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
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();
            mySqlConnection.Open();
            myCommand1.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand1.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "dd.MM.yyyy";
            TimePicker.MaxDate = DateTime.Now;
            DateTime now = DateTime.Now;
            TimePicker.Value = now;
        }

        private void работаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Work_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Работа". При необходимости она может быть перемещена или удалена.
           // this.работаTableAdapter.Fill(this.издательствоDataSet.Работа);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand1.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand1.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty))
                textBox4.Text = "введите значения";
            else
            {
                myCommand6.Parameters["@book"].Value = textBox1.Text;
                myCommand6.Parameters["@fio"].Value = textBox2.Text;
                myCommand6.Parameters["@tip"].Value = textBox3.Text;
                try
                {
                    mySqlConnection.Open();
                    myCommand6.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand6.Parameters["@x"].Value;

                    if (result == 0)
                        textBox4.Text = "запись добавлена";
                    if (result == 1)
                        textBox4.Text = "сотрудник не найден";
                    if (result == 2)
                        textBox4.Text = "книга не найдена";
                    if (result == 3)
                        textBox4.Text = "запись уже добавлена";

                    mySqlConnection.Open();
                    myCommand1.ExecuteNonQuery();
                    var table = new DataTable();
                    table.Load(myCommand1.ExecuteReader());
                    mySqlConnection.Close();
                    GridView.DataSource = table;
                }
                catch { textBox4.Text = "неизвестная книга";
                    mySqlConnection.Close();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox5.Text == String.Empty)
                textBox6.Text = "введите ID";
            else
            {
                myCommand7.Parameters["@id"].Value = Convert.ToInt32(textBox5.Text);
                myCommand7.Parameters["@data"].Value = Convert.ToDateTime(TimePicker.Value);
                mySqlConnection.Open();
                myCommand7.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand7.Parameters["@x"].Value;

                if (result == 0)
                    textBox6.Text = "дата установлена";
                if (result == 1)
                    textBox6.Text = "несуществующий ID";

                mySqlConnection.Open();
                myCommand1.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand1.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            myCommand8.Parameters["@book"].Value = textBox7.Text;


            mySqlConnection.Open();
            myCommand8.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand8.ExecuteReader());
            mySqlConnection.Close();
            GridView1.DataSource = table;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
