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
    public partial class ZZ : Form
    {
        private ИздательствоDataSet1 издательствоDataSet1;
        private BindingSource заявкаBindingSource;
        private IContainer components;
        private ИздательствоDataSet1TableAdapters.ЗаявкаTableAdapter заявкаTableAdapter;
        private DataGridView GridView;
        private Button button2;
        private TextBox textBox9;
        private Label label2;
        private Button button4;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand myCommand8;
        private System.Data.SqlClient.SqlCommand myCommand7;
        private System.Data.SqlClient.SqlCommand myCommand2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ИздательствоDataSet1TableAdapters.TableAdapterManager tableAdapterManager;

        public ZZ()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.издательствоDataSet1 = new kursovaya.ИздательствоDataSet1();
            this.заявкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкаTableAdapter = new kursovaya.ИздательствоDataSet1TableAdapters.ЗаявкаTableAdapter();
            this.tableAdapterManager = new kursovaya.ИздательствоDataSet1TableAdapters.TableAdapterManager();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.myCommand8 = new System.Data.SqlClient.SqlCommand();
            this.myCommand7 = new System.Data.SqlClient.SqlCommand();
            this.myCommand2 = new System.Data.SqlClient.SqlCommand();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.издательствоDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // издательствоDataSet1
            // 
            this.издательствоDataSet1.DataSetName = "ИздательствоDataSet1";
            this.издательствоDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкаBindingSource
            // 
            this.заявкаBindingSource.DataMember = "Заявка";
            this.заявкаBindingSource.DataSource = this.издательствоDataSet1;
            // 
            // заявкаTableAdapter
            // 
            this.заявкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = kursovaya.ИздательствоDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаявкаTableAdapter = this.заявкаTableAdapter;
            // 
            // GridView
            // 
            this.GridView.AutoGenerateColumns = false;
            this.GridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.GridView.DataSource = this.заявкаBindingSource;
            this.GridView.GridColor = System.Drawing.Color.Sienna;
            this.GridView.Location = new System.Drawing.Point(0, 58);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(911, 220);
            this.GridView.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(713, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 33);
            this.button2.TabIndex = 64;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(91, 29);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(593, 22);
            this.textBox9.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 65;
            this.label2.Text = "ФИО:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(800, 283);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 33);
            this.button4.TabIndex = 85;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=DESKTOP-N4QJMFI\\SQLEXPRESS;Initial Catalog=Издательство;Integrated Se" +
    "curity=True";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // myCommand8
            // 
            this.myCommand8.CommandText = "select * from searchzz(@par)";
            this.myCommand8.Connection = this.mySqlConnection;
            this.myCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@par", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // myCommand7
            // 
            this.myCommand7.CommandText = "delzz";
            this.myCommand7.CommandType = System.Data.CommandType.StoredProcedure;
            this.myCommand7.Connection = this.mySqlConnection;
            this.myCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@x", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // myCommand2
            // 
            this.myCommand2.CommandText = "select * from Заявка";
            this.myCommand2.Connection = this.mySqlConnection;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НомерЗаявки";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер заявки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ссылка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ZZ
            // 
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(911, 327);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.GridView);
            this.Name = "ZZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр заявок";
            this.Load += new System.EventHandler(this.ZZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.издательствоDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void заявкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet1);

        }

        private void ZZ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet1.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.издательствоDataSet1.Заявка);

        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
