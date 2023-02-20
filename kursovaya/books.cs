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
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand1.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand1.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void книгаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void books_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.издательствоDataSet.Книга);

        }

        private void переплётComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                mySqlConnection.Open();
                myCommand2.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand2.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
            if (radioButton2.Checked)
            {

                mySqlConnection.Open();
                myCommand3.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand3.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
            if (radioButton3.Checked)
            {

                mySqlConnection.Open();
                myCommand4.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand4.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
            if (radioButton4.Checked)
            {

                mySqlConnection.Open();
                myCommand5.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand5.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myCommand8.Parameters["@par"].Value = textBox2.Text;
            mySqlConnection.Open();
            myCommand8.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand8.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            if ((textBox1.Text == String.Empty) | (textBox4.Text == String.Empty) | (textBox6.Text == String.Empty) | (textBox3.Text == String.Empty) )
                textBox11.Text = "введите обязательные значения";
            else
            {
                myCommand6.Parameters["@nazv"].Value = textBox1.Text;
               // myCommand6.Parameters["@avtor"].Value = textBox5.Text;
                myCommand6.Parameters["@nomer"].Value = Convert.ToInt32(textBox4.Text);
                myCommand6.Parameters["@stoim"].Value = Convert.ToInt32(textBox3.Text);
                myCommand6.Parameters["@str"].Value = Convert.ToInt32(textBox6.Text);
                myCommand6.Parameters["@perep"].Value = ComboBox.Text;
                myCommand6.Parameters["@obl"].Value = ComboBox1.Text;
                mySqlConnection.Open();
                myCommand6.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand6.Parameters["@x"].Value;

                if (result == 0)
                {
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox3.Text = "";
                   // textBox5.Text = "";
                    textBox6.Text = "";

                    textBox11.Text = "запись добавлена";
                }
                if (result == 3)
                    textBox11.Text = "мы не сотрудничаем с данным автором";
                if (result == 4)
                    textBox11.Text = "договор по рукописи не найден";
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox12.Text == String.Empty)
                textBox13.Text = "введите ID";
            else
            {
                try
                {
                    myCommand7.Parameters["@ID"].Value = Convert.ToInt32(textBox12.Text); mySqlConnection.Open();
                    myCommand7.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand7.Parameters["@x"].Value;

                    if (result == 0)
                        textBox13.Text = "запись удалена";
                    if (result == 1)
                        textBox13.Text = "несуществующий ID";
                }
                catch { textBox13.Text = "книга не может быть удалена";
                    mySqlConnection.Close();
                }
            }

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
