namespace lab9
{
    partial class Goods
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dgvrs = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.view4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delivery_OchirmaDataSet = new lab9.Delivery_OchirmaDataSet();
            this.комментарийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.договорыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryOchirmaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewDgvr = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.view4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.договорыTableAdapter = new lab9.Delivery_OchirmaDataSetTableAdapters.ДоговорыTableAdapter();
            this.view_4TableAdapter = new lab9.Delivery_OchirmaDataSetTableAdapters.View_4TableAdapter();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерДоговораDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKПоставленоЦена440B1D61BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.поставленоTableAdapter = new lab9.Delivery_OchirmaDataSetTableAdapters.ПоставленоTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Dgvrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_OchirmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOchirmaDataSetBindingSource)).BeginInit();
            this.NewDgvr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view4BindingSource)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПоставленоЦена440B1D61BindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dgvrs);
            this.tabControl1.Controls.Add(this.NewDgvr);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // Dgvrs
            // 
            this.Dgvrs.Controls.Add(this.button4);
            this.Dgvrs.Controls.Add(this.button1);
            this.Dgvrs.Controls.Add(this.dataGridView1);
            this.Dgvrs.Location = new System.Drawing.Point(4, 25);
            this.Dgvrs.Name = "Dgvrs";
            this.Dgvrs.Padding = new System.Windows.Forms.Padding(3);
            this.Dgvrs.Size = new System.Drawing.Size(660, 309);
            this.Dgvrs.TabIndex = 0;
            this.Dgvrs.Text = "Список договоров";
            this.Dgvrs.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Удалить договор";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДоговораDataGridViewTextBoxColumn,
            this.датаДоговораDataGridViewTextBoxColumn,
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.комментарийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.договорыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(654, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "НомерДоговора";
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            this.номерДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаДоговораDataGridViewTextBoxColumn
            // 
            this.датаДоговораDataGridViewTextBoxColumn.DataPropertyName = "ДатаДоговора";
            this.датаДоговораDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаДоговораDataGridViewTextBoxColumn.Name = "датаДоговораDataGridViewTextBoxColumn";
            this.датаДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.DataSource = this.view4BindingSource1;
            this.кодПоставщикаDataGridViewTextBoxColumn.DisplayMember = "Поставщик";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.кодПоставщикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            this.кодПоставщикаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПоставщикаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодПоставщикаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодПоставщикаDataGridViewTextBoxColumn.ValueMember = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // view4BindingSource1
            // 
            this.view4BindingSource1.DataMember = "View_4";
            this.view4BindingSource1.DataSource = this.delivery_OchirmaDataSet;
            // 
            // delivery_OchirmaDataSet
            // 
            this.delivery_OchirmaDataSet.DataSetName = "Delivery_OchirmaDataSet";
            this.delivery_OchirmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // комментарийDataGridViewTextBoxColumn
            // 
            this.комментарийDataGridViewTextBoxColumn.DataPropertyName = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.комментарийDataGridViewTextBoxColumn.Name = "комментарийDataGridViewTextBoxColumn";
            this.комментарийDataGridViewTextBoxColumn.ReadOnly = true;
            this.комментарийDataGridViewTextBoxColumn.Width = 125;
            // 
            // договорыBindingSource
            // 
            this.договорыBindingSource.DataMember = "Договоры";
            this.договорыBindingSource.DataSource = this.deliveryOchirmaDataSetBindingSource;
            // 
            // deliveryOchirmaDataSetBindingSource
            // 
            this.deliveryOchirmaDataSetBindingSource.DataSource = this.delivery_OchirmaDataSet;
            this.deliveryOchirmaDataSetBindingSource.Position = 0;
            // 
            // NewDgvr
            // 
            this.NewDgvr.Controls.Add(this.button3);
            this.NewDgvr.Controls.Add(this.button2);
            this.NewDgvr.Controls.Add(this.dateTimePicker1);
            this.NewDgvr.Controls.Add(this.textBox1);
            this.NewDgvr.Controls.Add(this.comboBox1);
            this.NewDgvr.Controls.Add(this.label3);
            this.NewDgvr.Controls.Add(this.label2);
            this.NewDgvr.Controls.Add(this.label1);
            this.NewDgvr.Location = new System.Drawing.Point(4, 25);
            this.NewDgvr.Name = "NewDgvr";
            this.NewDgvr.Padding = new System.Windows.Forms.Padding(3);
            this.NewDgvr.Size = new System.Drawing.Size(660, 309);
            this.NewDgvr.TabIndex = 1;
            this.NewDgvr.Text = "Новый договор";
            this.NewDgvr.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.view4BindingSource1;
            this.comboBox1.DisplayMember = "Поставщик";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "КодПоставщика";
            // 
            // view4BindingSource
            // 
            this.view4BindingSource.DataMember = "View_4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Комментарий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Поставщик";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заключения договора";
            // 
            // договорыTableAdapter
            // 
            this.договорыTableAdapter.ClearBeforeFill = true;
            // 
            // view_4TableAdapter
            // 
            this.view_4TableAdapter.ClearBeforeFill = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(16, 367);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(664, 277);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 248);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Список товаров";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(377, 205);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 206);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Сумма поставки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Всего единиц";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(514, 200);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 32);
            this.button7.TabIndex = 1;
            this.button7.Text = "Удалить товар";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДоговораDataGridViewTextBoxColumn1,
            this.товарDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKПоставленоЦена440B1D61BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(650, 187);
            this.dataGridView2.TabIndex = 0;
            // 
            // номерДоговораDataGridViewTextBoxColumn1
            // 
            this.номерДоговораDataGridViewTextBoxColumn1.DataPropertyName = "НомерДоговора";
            this.номерДоговораDataGridViewTextBoxColumn1.HeaderText = "НомерДоговора";
            this.номерДоговораDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.номерДоговораDataGridViewTextBoxColumn1.Name = "номерДоговораDataGridViewTextBoxColumn1";
            this.номерДоговораDataGridViewTextBoxColumn1.ReadOnly = true;
            this.номерДоговораDataGridViewTextBoxColumn1.Width = 125;
            // 
            // товарDataGridViewTextBoxColumn
            // 
            this.товарDataGridViewTextBoxColumn.DataPropertyName = "Товар";
            this.товарDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.товарDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.товарDataGridViewTextBoxColumn.Name = "товарDataGridViewTextBoxColumn";
            this.товарDataGridViewTextBoxColumn.ReadOnly = true;
            this.товарDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKПоставленоЦена440B1D61BindingSource
            // 
            this.fKПоставленоЦена440B1D61BindingSource.DataMember = "FK__Поставлено__Цена__440B1D61";
            this.fKПоставленоЦена440B1D61BindingSource.DataSource = this.договорыBindingSource;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(656, 248);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Добавить товар";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 36);
            this.button6.TabIndex = 3;
            this.button6.Text = "Отменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 36);
            this.button5.TabIndex = 2;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Цена за единицу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Товар";
            // 
            // поставленоTableAdapter
            // 
            this.поставленоTableAdapter.ClearBeforeFill = true;
            // 
            // Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 646);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Goods";
            this.Text = "Поставки товаров";
            this.Load += new System.EventHandler(this.Goods_Load);
            this.tabControl1.ResumeLayout(false);
            this.Dgvrs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_OchirmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOchirmaDataSetBindingSource)).EndInit();
            this.NewDgvr.ResumeLayout(false);
            this.NewDgvr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view4BindingSource)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПоставленоЦена440B1D61BindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dgvrs;
        private System.Windows.Forms.TabPage NewDgvr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deliveryOchirmaDataSetBindingSource;
        private Delivery_OchirmaDataSet delivery_OchirmaDataSet;
        private System.Windows.Forms.BindingSource договорыBindingSource;
        private Delivery_OchirmaDataSetTableAdapters.ДоговорыTableAdapter договорыTableAdapter;
        private System.Windows.Forms.BindingSource view4BindingSource;
        private Delivery_OchirmaDataSetTableAdapters.View_4TableAdapter view_4TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource view4BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментарийDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource fKПоставленоЦена440B1D61BindingSource;
        private Delivery_OchirmaDataSetTableAdapters.ПоставленоTableAdapter поставленоTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn товарDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
    }
}