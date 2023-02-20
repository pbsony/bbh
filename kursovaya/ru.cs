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
    public partial class ru : Form
    {
        public ru()
        {
            InitializeComponent();
        }

        private void рукописьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рукописьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void ru_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet2.Рукопись". При необходимости она может быть перемещена или удалена.
            this.рукописьTableAdapter1.Fill(this.издательствоDataSet2.Рукопись);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Рукопись". При необходимости она может быть перемещена или удалена.
            this.рукописьTableAdapter.Fill(this.издательствоDataSet.Рукопись);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new Menu();
            frm.Show();
            this.Hide();
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
            if ((textBox6.Text == String.Empty) | (comboBox1.Text == String.Empty))
                textBox8.Text = "введите все данные";
            else
            {
                myCommand9.Parameters["@num"].Value = Convert.ToInt32(textBox6.Text);
                myCommand9.Parameters["@st"].Value = comboBox1.Text;
                try
                {
                    mySqlConnection.Open();
                    myCommand9.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand9.Parameters["@x"].Value;

                    if (result == 0)
                        textBox8.Text = "статус изменен";
                    if (result == 1)
                        textBox8.Text = "нет рукописи с указанным номером";
                }
                catch { textBox8.Text = "ошибка при выполнении";
                    mySqlConnection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty) 
                textBox3.Text = "введите номер заявки";
            else
            {
                myCommand6.Parameters["@id"].Value = Convert.ToInt32(textBox1.Text);
               

                mySqlConnection.Open();
                myCommand6.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand6.Parameters["@x"].Value;

                if (result == 0)
                    textBox3.Text = "запись добавлена";
                if (result == 1)
                    textBox3.Text = "заявка с таким номером не найдена";
                if (result == 2)
                    textBox3.Text = "по данной заявке уже создана рукопись";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
