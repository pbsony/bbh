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
    public partial class DD : Form
    {
        public DD()
        {
            InitializeComponent();
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "dd.MM.yyyy";
            TimePicker.MaxDate = DateTime.Now;
            DateTime now = DateTime.Now;
            TimePicker.Value = now;


            TimePicker1.Format = DateTimePickerFormat.Custom;
            TimePicker1.CustomFormat = "dd.MM.yyyy";
            TimePicker1.MaxDate = DateTime.Now;
            TimePicker1.Value = now;


            TimePicker3.Format = DateTimePickerFormat.Custom;
            TimePicker3.CustomFormat = "dd.MM.yyyy";
            TimePicker3.MaxDate = DateTime.Now;
            TimePicker3.Value = now;
        }

        private void договорBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договорBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Договоры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.издательствоDataSet.Договор);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty))
                textBox4.Text = "введите значения";
            else
            {

                myCommand6.Parameters["@num"].Value = Convert.ToInt32(textBox1.Text);
                myCommand6.Parameters["@data"].Value = Convert.ToDateTime(TimePicker.Value);

                if (Convert.ToInt32(textBox2.Text) < 1)
                    textBox4.Text = "некорректное значение оплаты";
                else
                {
                    myCommand6.Parameters["@plata"].Value = Convert.ToInt32(textBox2.Text);

                    if (Convert.ToInt32(textBox2.Text) < 1)
                        textBox4.Text = "некорректное значение для размера тиража";
                    else
                    {
                         
                        myCommand6.Parameters["@t"].Value = Convert.ToInt32(textBox3.Text);



                        mySqlConnection.Open();
                        myCommand6.ExecuteNonQuery();
                        mySqlConnection.Close();
                        int result = (int)myCommand6.Parameters["@x"].Value;

                        if (result == 0)
                        {
                            textBox4.Text = "добавлено";

                            var helper = new WordHelper("standart.docx");
                           
                            var items = new Dictionary<string, string>
                            {
                                {"<NUM>", Convert.ToString(myCommand6.Parameters["@id"].Value)},
                                {"<NAME>", Convert.ToString(myCommand6.Parameters["@avtor"].Value)},                        
                                {"<N>", Convert.ToString(textBox1.Text)},
                                {"<TIR>", Convert.ToString(textBox3.Text)},
                                {"<RUB>",Convert.ToString(textBox2.Text)},
                                {"<DATA>", Convert.ToString(TimePicker.Value.ToString("dd.MM.yyyy"))}
                            };

                            helper.Process(items);
                        }
                        if (result == 1)
                            textBox4.Text = "мы не можем работать с данной рукописью";
                        if (result == 2)
                            textBox4.Text = "договор уже был создан";
                        mySqlConnection.Open();
                        myCommand1.ExecuteNonQuery();
                        var table = new DataTable();
                        table.Load(myCommand1.ExecuteReader());
                        mySqlConnection.Close();
                        GridView.DataSource = table;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(TimePicker.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCommand7.Parameters["@data1"].Value = Convert.ToDateTime(TimePicker3.Value);
            myCommand7.Parameters["@data2"].Value = Convert.ToDateTime(TimePicker1.Value);

         
            mySqlConnection.Open();
            myCommand7.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand7.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand1.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand1.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
