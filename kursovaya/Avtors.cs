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
    public partial class Avtors : Form
    {
        public Avtors()
        {
            InitializeComponent();
        }

        private void авторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.авторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Avtors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Автор". При необходимости она может быть перемещена или удалена.
            this.авторTableAdapter.Fill(this.издательствоDataSet.Автор);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox6.Text == String.Empty) | (textBox7.Text == String.Empty))
                textBox8.Text = "введите все данные";
            else
            {
                myCommand9.Parameters["@fio"].Value =textBox6.Text;
                myCommand9.Parameters["@newnomer"].Value = textBox7.Text;
                mySqlConnection.Open();
                myCommand9.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand9.Parameters["@x"].Value;

                if (result == 0)
                    textBox8.Text = "номер изменен";
                if (result == 1)
                    textBox8.Text = "автора нет в системе";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == String.Empty)
                textBox5.Text = "введите ФИО";
            else
            {
                try
                {
                    myCommand7.Parameters["@fio"].Value = textBox4.Text;
                    mySqlConnection.Open();
                    myCommand7.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand7.Parameters["@x"].Value;

                    if (result == 0)
                        textBox5.Text = "автор удалён";
                    if (result == 1)
                        textBox5.Text = "автора нет в системе";
                }
                catch { textBox5.Text = "автор не может быть удалён";
                    mySqlConnection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty))
                textBox3.Text = "введите значения";
            else
            {
                myCommand6.Parameters["@fio"].Value = textBox1.Text;
                myCommand6.Parameters["@nomer"].Value = textBox2.Text;
                myCommand6.Parameters["@pol"].Value = comboBox1.Text;
                try
                {
                    mySqlConnection.Open();
                    myCommand6.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand6.Parameters["@x"].Value;

                    if (result == 0)
                        textBox3.Text = "запись добавлена";
                    if (result == 1)
                        textBox3.Text = "автор уже есть в системе";
                    if (result == 2)
                        textBox3.Text = "неверный гендер";
                }
                catch {
                    textBox3.Text = "ошибка при добавлении";
                        mySqlConnection.Close();
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox10.Text == String.Empty) | (comboBox1.Text == String.Empty))
                textBox11.Text = "введите все данные";
            else
            {
                try
                {
                    myCommand10.Parameters["@fio"].Value = textBox10.Text;
                    myCommand10.Parameters["@pol"].Value = comboBox1.Text;
                    mySqlConnection.Open();
                    myCommand10.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand10.Parameters["@x"].Value;

                    if (result == 0)
                     textBox11.Text = "успешно";
                     if (result == 1)
                     textBox11.Text = "автора нет в системе";
                }
                catch { mySqlConnection.Close();
                    textBox11.Text = "ошибка при выполнении";
                }
            }
        }
    }
}
