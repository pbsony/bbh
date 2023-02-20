namespace kursovaya
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.издательствоDataSet = new kursovaya.ИздательствоDataSet();
            this.книгаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.книгаTableAdapter = new kursovaya.ИздательствоDataSetTableAdapters.КнигаTableAdapter();
            this.tableAdapterManager = new kursovaya.ИздательствоDataSetTableAdapters.TableAdapterManager();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mySqlConnection = new System.Data.SqlClient.SqlConnection();
            this.myCommand8 = new System.Data.SqlClient.SqlCommand();
            this.myCommand2 = new System.Data.SqlClient.SqlCommand();
            this.myCommand3 = new System.Data.SqlClient.SqlCommand();
            this.myCommand4 = new System.Data.SqlClient.SqlCommand();
            this.myCommand5 = new System.Data.SqlClient.SqlCommand();
            this.button3 = new System.Windows.Forms.Button();
            this.myCommand1 = new System.Data.SqlClient.SqlCommand();
            this.myCommand6 = new System.Data.SqlClient.SqlCommand();
            this.label4 = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.myCommand10 = new System.Data.SqlClient.SqlCommand();
            this.myCommand11 = new System.Data.SqlClient.SqlCommand();
            this.myCommand12 = new System.Data.SqlClient.SqlCommand();
            this.myCommand13 = new System.Data.SqlClient.SqlCommand();
            this.myCommand14 = new System.Data.SqlClient.SqlCommand();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.издательствоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // издательствоDataSet
            // 
            this.издательствоDataSet.DataSetName = "ИздательствоDataSet";
            this.издательствоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгаBindingSource
            // 
            this.книгаBindingSource.DataMember = "Книга";
            this.книгаBindingSource.DataSource = this.издательствоDataSet;
            // 
            // книгаTableAdapter
            // 
            this.книгаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = kursovaya.ИздательствоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторTableAdapter = null;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.КнигаTableAdapter = this.книгаTableAdapter;
            this.tableAdapterManager.РаботаTableAdapter = null;
            this.tableAdapterManager.РукописьTableAdapter = null;
            this.tableAdapterManager.СоставЗаказаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(478, 22);
            this.textBox2.TabIndex = 52;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SeaShell;
            this.button9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Sienna;
            this.button9.Location = new System.Drawing.Point(952, -345);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(204, 42);
            this.button9.TabIndex = 53;
            this.button9.Text = "Искать";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Sienna;
            this.groupBox1.Location = new System.Drawing.Point(1172, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(320, 261);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 153);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(179, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "По страницам";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 117);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(180, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "По стоимости";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 82);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По автору";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 48);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По названию";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(735, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 55;
            this.label1.Text = "Цена:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 161);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 56;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1023, 161);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.MaxLength = 8;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 22);
            this.textBox3.TabIndex = 57;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(958, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "− ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(496, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 31);
            this.button1.TabIndex = 60;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(1002, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 61;
            this.button2.Text = "Искать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mySqlConnection
            // 
            this.mySqlConnection.ConnectionString = "Data Source=DESKTOP-N4QJMFI\\SQLEXPRESS;Initial Catalog=Издательство;Integrated Se" +
    "curity=True";
            this.mySqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // myCommand8
            // 
            this.myCommand8.CommandText = "select * from search1(@par)";
            this.myCommand8.Connection = this.mySqlConnection;
            this.myCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@par", System.Data.SqlDbType.VarChar, 1024)});
            // 
            // myCommand2
            // 
            this.myCommand2.CommandText = "Select Название, Автор, Переплёт, Обложка, КолвоСтраниц, Стоимость from Книга ORD" +
    "ER BY Название";
            this.myCommand2.Connection = this.mySqlConnection;
            // 
            // myCommand3
            // 
            this.myCommand3.CommandText = "Select Название, Автор, Переплёт, Обложка, КолвоСтраниц, Стоимость from Книга ORD" +
    "ER BY Автор";
            this.myCommand3.Connection = this.mySqlConnection;
            // 
            // myCommand4
            // 
            this.myCommand4.CommandText = "Select Название, Автор, Переплёт, Обложка, КолвоСтраниц, Стоимость from Книга ORD" +
    "ER BY Стоимость";
            this.myCommand4.Connection = this.mySqlConnection;
            // 
            // myCommand5
            // 
            this.myCommand5.CommandText = "Select Название, Автор, Переплёт, Обложка, КолвоСтраниц, Стоимость from Книга ORD" +
    "ER BY КолвоСтраниц";
            this.myCommand5.Connection = this.mySqlConnection;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1306, 544);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 33);
            this.button3.TabIndex = 62;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // myCommand1
            // 
            this.myCommand1.CommandText = "Select Название, Автор, Переплёт, Обложка, КолвоСтраниц, Стоимость From Книга";
            this.myCommand1.Connection = this.mySqlConnection;
            // 
            // myCommand6
            // 
            this.myCommand6.CommandText = "select * from ckolkostoim(@min,@max)";
            this.myCommand6.Connection = this.mySqlConnection;
            this.myCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@min", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@max", System.Data.SqlDbType.Int)});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Поиск по названию книги или ФИО автора:";
            // 
            // GridView
            // 
            this.GridView.AutoGenerateColumns = false;
            this.GridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.GridView.DataSource = this.книгаBindingSource;
            this.GridView.GridColor = System.Drawing.Color.Sienna;
            this.GridView.Location = new System.Drawing.Point(12, 97);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(647, 480);
            this.GridView.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(674, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 28);
            this.label5.TabIndex = 67;
            this.label5.Text = "Страницы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(687, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 68;
            this.label6.Text = "Обложка:";
            // 
            // ComboBox
            // 
            this.ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.книгаBindingSource, "Обложка", true));
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Твёрдая",
            "Цельнокрытая",
            "Мягкая"});
            this.ComboBox.Location = new System.Drawing.Point(841, 246);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(277, 24);
            this.ComboBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(958, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 70;
            this.label2.Text = "− ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(869, 203);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.MaxLength = 8;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 22);
            this.textBox4.TabIndex = 71;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1023, 203);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.MaxLength = 8;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 22);
            this.textBox5.TabIndex = 72;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // myCommand10
            // 
            this.myCommand10.CommandText = "select * from filtr0(@price1,@price2,@page1,@page2,@obl)";
            this.myCommand10.Connection = this.mySqlConnection;
            this.myCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@price1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@price2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@obl", System.Data.SqlDbType.VarChar, 50)});
            // 
            // myCommand11
            // 
            this.myCommand11.CommandText = "select * from filtr1(@price1,@price2,@page1,@page2,@obl)";
            this.myCommand11.Connection = this.mySqlConnection;
            this.myCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@price1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@price2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@obl", System.Data.SqlDbType.VarChar, 50)});
            // 
            // myCommand12
            // 
            this.myCommand12.CommandText = "select * from filtr2(@price1,@price2,@page1,@page2,@obl)";
            this.myCommand12.Connection = this.mySqlConnection;
            this.myCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@price1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@price2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@obl", System.Data.SqlDbType.VarChar, 50)});
            // 
            // myCommand13
            // 
            this.myCommand13.CommandText = "select * from filtr3(@price1,@price2,@page1,@page2,@obl)";
            this.myCommand13.Connection = this.mySqlConnection;
            this.myCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@price1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@price2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@obl", System.Data.SqlDbType.VarChar, 50)});
            // 
            // myCommand14
            // 
            this.myCommand14.CommandText = "select * from filtr4(@price1,@price2,@page1,@page2,@obl)";
            this.myCommand14.Connection = this.mySqlConnection;
            this.myCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@price1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@price2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page1", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@page2", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@obl", System.Data.SqlDbType.VarChar, 50)});
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(963, 412);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 22);
            this.textBox6.TabIndex = 73;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Автор";
            this.dataGridViewTextBoxColumn3.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "КолвоСтраниц";
            this.dataGridViewTextBoxColumn5.HeaderText = "Кол-во страниц";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Переплёт";
            this.dataGridViewTextBoxColumn6.HeaderText = "Переплёт";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Обложка";
            this.dataGridViewTextBoxColumn7.HeaderText = "Обложка";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn8.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1439, 588);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ассортимент";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.издательствоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ИздательствоDataSet издательствоDataSet;
        private System.Windows.Forms.BindingSource книгаBindingSource;
        private ИздательствоDataSetTableAdapters.КнигаTableAdapter книгаTableAdapter;
        private ИздательствоDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlConnection mySqlConnection;
        private System.Data.SqlClient.SqlCommand myCommand8;
        private System.Data.SqlClient.SqlCommand myCommand2;
        private System.Data.SqlClient.SqlCommand myCommand3;
        private System.Data.SqlClient.SqlCommand myCommand4;
        private System.Data.SqlClient.SqlCommand myCommand5;
        private System.Windows.Forms.Button button3;
        private System.Data.SqlClient.SqlCommand myCommand1;
        private System.Data.SqlClient.SqlCommand myCommand6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Data.SqlClient.SqlCommand myCommand10;
        private System.Data.SqlClient.SqlCommand myCommand11;
        private System.Data.SqlClient.SqlCommand myCommand12;
        private System.Data.SqlClient.SqlCommand myCommand13;
        private System.Data.SqlClient.SqlCommand myCommand14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}