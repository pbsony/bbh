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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void книгаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Книга". При необходимости она может быть перемещена или удалена.
            this.книгаTableAdapter.Fill(this.издательствоDataSet.Книга);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand8.Parameters["@par"].Value = textBox2.Text;
            mySqlConnection.Open();
            myCommand8.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand8.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        }

        private void книгаBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new MenuClient();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "   ";
            if (textBox1.Text == String.Empty)
            {
                myCommand10.Parameters["@price1"].Value = 0;
                myCommand11.Parameters["@price1"].Value = 0;
                myCommand12.Parameters["@price1"].Value = 0;
                myCommand13.Parameters["@price1"].Value = 0;
                myCommand14.Parameters["@price1"].Value = 0;
            }
            else
            {
                myCommand10.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                myCommand11.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                myCommand12.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                myCommand13.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                myCommand14.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
            }
            if (textBox3.Text == String.Empty)
            {
                myCommand10.Parameters["@price2"].Value = 99999;
                myCommand12.Parameters["@price2"].Value = 99999;
                myCommand13.Parameters["@price2"].Value = 99999;
                myCommand14.Parameters["@price2"].Value = 99999;
                myCommand11.Parameters["@price2"].Value = 99999;

            }
            else
            {
                myCommand10.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                myCommand11.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                myCommand12.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                myCommand13.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                myCommand14.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
            }




            if (textBox4.Text == String.Empty)
            {
                myCommand10.Parameters["@page1"].Value = 0;
                myCommand11.Parameters["@page1"].Value = 0;
                myCommand12.Parameters["@page1"].Value = 0;
                myCommand13.Parameters["@page1"].Value = 0;
                myCommand14.Parameters["@page1"].Value = 0;
            }
            else
            {
                myCommand10.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                myCommand11.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                myCommand12.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                myCommand13.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                myCommand14.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
            }
            if (textBox5.Text == String.Empty)
            {
                myCommand10.Parameters["@page2"].Value = 99999;
                myCommand11.Parameters["@page2"].Value = 99999;
                myCommand12.Parameters["@page2"].Value = 99999;
                myCommand13.Parameters["@page2"].Value = 99999;
                myCommand14.Parameters["@page2"].Value = 99999;

            }
            else
            {
                myCommand10.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                myCommand11.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                myCommand12.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                myCommand13.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                myCommand14.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
            }



            if (ComboBox.Text == String.Empty)
            {
                myCommand10.Parameters["@obl"].Value = 'а';
                myCommand11.Parameters["@obl"].Value = 'а';
                myCommand12.Parameters["@obl"].Value = 'а';
                myCommand13.Parameters["@obl"].Value = 'а';
                myCommand14.Parameters["@obl"].Value = 'а';
                
            }
            else
            {
                myCommand10.Parameters["@obl"].Value = ComboBox.Text;
                myCommand11.Parameters["@obl"].Value = ComboBox.Text;
                myCommand12.Parameters["@obl"].Value = ComboBox.Text;
                myCommand13.Parameters["@obl"].Value = ComboBox.Text;
                myCommand14.Parameters["@obl"].Value = ComboBox.Text;
            }



            if (radioButton1.Checked)
            {

                mySqlConnection.Open();
                myCommand11.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand11.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
            if (radioButton2.Checked)
            {

                mySqlConnection.Open();
                myCommand12.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand12.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
            if (radioButton3.Checked)
            {

                mySqlConnection.Open();
                myCommand13.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand13.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }
            if (radioButton4.Checked)
            {

                mySqlConnection.Open();
                myCommand14.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand14.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;

            }


            if (radioButton1.Checked != true & radioButton2.Checked != true & radioButton3.Checked != true & radioButton4.Checked != true )
            {


                mySqlConnection.Open();
                myCommand10.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(myCommand10.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table;


            }
            if (GridView[0,0].Value == null)
               textBox6.Text = "Результат не найден";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand11.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand11.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand12.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand12.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand13.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand13.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mySqlConnection.Open();
            myCommand14.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(myCommand14.ExecuteReader());
            mySqlConnection.Close();
            GridView.DataSource = table;
        }
    }
}
