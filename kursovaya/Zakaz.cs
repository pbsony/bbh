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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "dd.MM.yyyy";
            TimePicker.MaxDate = DateTime.Now;
            DateTime now = DateTime.Now;
            TimePicker.Value = now;


         
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.издательствоDataSet.Книга);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.СоставЗаказа". При необходимости она может быть перемещена или удалена.
            this.составЗаказаTableAdapter.Fill(this.издательствоDataSet.СоставЗаказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.издательствоDataSet.Заказ);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == String.Empty) | (ComboBox.Text == String.Empty))
                textBox4.Text = "введите значения";
            else
            {
                myCommand6.Parameters["@fio"].Value = textBox1.Text;
                myCommand6.Parameters["@data"].Value = Convert.ToDateTime(TimePicker.Value);
                myCommand6.Parameters["@tip"].Value = ComboBox.Text;


                mySqlConnection.Open();
                myCommand6.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand6.Parameters["@x"].Value;

                if (result == 0)
                    textBox4.Text = "заказ добавлен";
                if (result == 1)
                    textBox4.Text = "клиента нет в базе данных";
                //this.Hide();
                //Form frm = new Zakaz();
                //frm.Show();
                
               
                mySqlConnection.Open();
                myCommand1.ExecuteNonQuery();
                var table1 = new DataTable();
                table1.Load(myCommand1.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == String.Empty)
                textBox5.Text = "введите номер";
            else
            {
                myCommand7.Parameters["@id"].Value = Convert.ToInt32(textBox3.Text);
                mySqlConnection.Open();
                myCommand7.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand7.Parameters["@x"].Value;

                if (result == 0)
                    textBox5.Text = "заказ удалён";
                if (result == 1)
                    textBox5.Text = "заказа не найден";

                mySqlConnection.Open();
                myCommand1.ExecuteNonQuery();
                var table1 = new DataTable();
                table1.Load(myCommand1.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table1;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox8.Text == String.Empty) | (textBox9.Text == String.Empty))
                textBox7.Text = "введите значения";
            else
            {
                try
                {
                    myCommand9.Parameters["@id"].Value = Convert.ToInt32(GridView.SelectedCells[0].Value.ToString());
                }
                catch
                { textBox7.Text = "некорректный выбор заказа"; }
                myCommand9.Parameters["@idk"].Value = Convert.ToInt32(textBox8.Text);
                    myCommand9.Parameters["@kol"].Value = Convert.ToInt32(textBox9.Text);
                try
                {
                    myCommand2.Parameters["@id"].Value = Convert.ToInt32(GridView.SelectedCells[0].Value.ToString());

                }
                catch
                { textBox7.Text = "некорректный выбор заказа"; }

                try
                {
                    myCommand3.Parameters["@ID"].Value = Convert.ToInt32(GridView.SelectedCells[0].Value.ToString());
                }
                catch
                { textBox7.Text = "некорректный выбор заказа"; }
                mySqlConnection.Open();
                try
                {
                    myCommand9.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand9.Parameters["@x"].Value;
                    // string sum = (string)myCommand9.Parameters["@obsum"].Value;

                    if ((result == 0) | (result == 4))
                    {
                        textBox7.Text = "добавлено";
                        mySqlConnection.Open();
                        textBox2.Text = myCommand3.ExecuteScalar().ToString();
                        mySqlConnection.Close();
                    }
                    if (result == 1)
                        textBox7.Text = "указанный заказ не найден";
                    if (result == 2)
                        textBox7.Text = "книга не найдена";

                }
                catch
                { textBox7.Text = "некорректный выбор заказа";
                    mySqlConnection.Close();
                }

                try
                {
                    mySqlConnection.Open();
                    myCommand2.ExecuteNonQuery();
                    var table = new DataTable();
                    table.Load(myCommand2.ExecuteReader());

                    mySqlConnection.Close();
                    GridView1.DataSource = table;
                }
                catch
                {
                    textBox7.Text = "некорректный выбор заказа";
                    mySqlConnection.Close();
                }



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Menu();
            frm.Show();
            this.Hide();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
