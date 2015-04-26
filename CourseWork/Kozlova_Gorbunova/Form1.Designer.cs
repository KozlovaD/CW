namespace Koz_Gor_kurs
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Главная = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Клиент = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Список = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.client_fio = new System.Windows.Forms.TextBox();
            this.client_add = new System.Windows.Forms.Button();
            this.Товар = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Каталог = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Добавить = new System.Windows.Forms.TabPage();
            this.kosmetika_date = new System.Windows.Forms.DateTimePicker();
            this.kosmetika_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.kosmetika_count = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kosmetika_stoimost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kosmetika_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kosmetika_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Подбор_Товара = new System.Windows.Forms.TabPage();
            this.Продажа = new System.Windows.Forms.TabPage();
            this.Характеристика = new System.Windows.Forms.TabPage();
            this.Отчет = new System.Windows.Forms.TabPage();
            this.Визитка = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Главная.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Клиент.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.Список.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Add.SuspendLayout();
            this.Товар.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.Каталог.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Добавить.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Главная);
            this.tabControl1.Controls.Add(this.Клиент);
            this.tabControl1.Controls.Add(this.Товар);
            this.tabControl1.Controls.Add(this.Подбор_Товара);
            this.tabControl1.Controls.Add(this.Продажа);
            this.tabControl1.Controls.Add(this.Характеристика);
            this.tabControl1.Controls.Add(this.Отчет);
            this.tabControl1.Controls.Add(this.Визитка);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 358);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // Главная
            // 
            this.Главная.Controls.Add(this.dataGridView2);
            this.Главная.Controls.Add(this.dataGridView1);
            this.Главная.Controls.Add(this.label2);
            this.Главная.Controls.Add(this.label1);
            this.Главная.Location = new System.Drawing.Point(4, 24);
            this.Главная.Name = "Главная";
            this.Главная.Padding = new System.Windows.Forms.Padding(3);
            this.Главная.Size = new System.Drawing.Size(670, 330);
            this.Главная.TabIndex = 0;
            this.Главная.Text = "Главная";
            this.Главная.UseVisualStyleBackColor = true;
            this.Главная.Click += new System.EventHandler(this.Главная_Click);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.Location = new System.Drawing.Point(6, 182);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.Size = new System.Drawing.Size(656, 142);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Size = new System.Drawing.Size(656, 137);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Истекающий срок годности";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заканчивающейся товар";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Клиент
            // 
            this.Клиент.Controls.Add(this.tabControl2);
            this.Клиент.Location = new System.Drawing.Point(4, 24);
            this.Клиент.Name = "Клиент";
            this.Клиент.Size = new System.Drawing.Size(670, 330);
            this.Клиент.TabIndex = 5;
            this.Клиент.Text = "Клиент";
            this.Клиент.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Список);
            this.tabControl2.Controls.Add(this.Add);
            this.tabControl2.Location = new System.Drawing.Point(1, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(672, 327);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl2_Selected);
            // 
            // Список
            // 
            this.Список.Controls.Add(this.dataGridView3);
            this.Список.Location = new System.Drawing.Point(4, 22);
            this.Список.Name = "Список";
            this.Список.Padding = new System.Windows.Forms.Padding(3);
            this.Список.Size = new System.Drawing.Size(664, 301);
            this.Список.TabIndex = 0;
            this.Список.Text = "Список";
            this.Список.UseVisualStyleBackColor = true;
            this.Список.Click += new System.EventHandler(this.Список_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(661, 297);
            this.dataGridView3.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.label3);
            this.Add.Controls.Add(this.client_fio);
            this.Add.Controls.Add(this.client_add);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(664, 301);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // client_fio
            // 
            this.client_fio.Location = new System.Drawing.Point(77, 16);
            this.client_fio.Name = "client_fio";
            this.client_fio.Size = new System.Drawing.Size(161, 20);
            this.client_fio.TabIndex = 1;
            // 
            // client_add
            // 
            this.client_add.Location = new System.Drawing.Point(137, 64);
            this.client_add.Name = "client_add";
            this.client_add.Size = new System.Drawing.Size(101, 24);
            this.client_add.TabIndex = 0;
            this.client_add.Text = "Добавить";
            this.client_add.UseVisualStyleBackColor = true;
            this.client_add.Click += new System.EventHandler(this.client_add_Click);
            // 
            // Товар
            // 
            this.Товар.Controls.Add(this.tabControl3);
            this.Товар.Location = new System.Drawing.Point(4, 24);
            this.Товар.Name = "Товар";
            this.Товар.Size = new System.Drawing.Size(670, 330);
            this.Товар.TabIndex = 4;
            this.Товар.Text = "Товар";
            this.Товар.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.Каталог);
            this.tabControl3.Controls.Add(this.Добавить);
            this.tabControl3.Location = new System.Drawing.Point(0, 1);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(669, 328);
            this.tabControl3.TabIndex = 0;
            this.tabControl3.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl3_Selected);
            // 
            // Каталог
            // 
            this.Каталог.Controls.Add(this.dataGridView4);
            this.Каталог.Location = new System.Drawing.Point(4, 22);
            this.Каталог.Name = "Каталог";
            this.Каталог.Padding = new System.Windows.Forms.Padding(3);
            this.Каталог.Size = new System.Drawing.Size(661, 302);
            this.Каталог.TabIndex = 0;
            this.Каталог.Text = "Каталог";
            this.Каталог.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 1);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(657, 304);
            this.dataGridView4.TabIndex = 0;
            // 
            // Добавить
            // 
            this.Добавить.Controls.Add(this.kosmetika_date);
            this.Добавить.Controls.Add(this.kosmetika_add);
            this.Добавить.Controls.Add(this.label8);
            this.Добавить.Controls.Add(this.kosmetika_count);
            this.Добавить.Controls.Add(this.label7);
            this.Добавить.Controls.Add(this.kosmetika_stoimost);
            this.Добавить.Controls.Add(this.label6);
            this.Добавить.Controls.Add(this.kosmetika_name);
            this.Добавить.Controls.Add(this.label5);
            this.Добавить.Controls.Add(this.kosmetika_type);
            this.Добавить.Controls.Add(this.label4);
            this.Добавить.Location = new System.Drawing.Point(4, 22);
            this.Добавить.Name = "Добавить";
            this.Добавить.Padding = new System.Windows.Forms.Padding(3);
            this.Добавить.Size = new System.Drawing.Size(661, 302);
            this.Добавить.TabIndex = 1;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = true;
            // 
            // kosmetika_date
            // 
            this.kosmetika_date.CustomFormat = "yyyy-MM-dd";
            this.kosmetika_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kosmetika_date.Location = new System.Drawing.Point(106, 120);
            this.kosmetika_date.Name = "kosmetika_date";
            this.kosmetika_date.Size = new System.Drawing.Size(100, 20);
            this.kosmetika_date.TabIndex = 11;
            this.kosmetika_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // kosmetika_add
            // 
            this.kosmetika_add.Location = new System.Drawing.Point(125, 146);
            this.kosmetika_add.Name = "kosmetika_add";
            this.kosmetika_add.Size = new System.Drawing.Size(81, 20);
            this.kosmetika_add.TabIndex = 10;
            this.kosmetika_add.Text = "Добавить";
            this.kosmetika_add.UseVisualStyleBackColor = true;
            this.kosmetika_add.Click += new System.EventHandler(this.kosmetika_add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Срок годности";
            // 
            // kosmetika_count
            // 
            this.kosmetika_count.Location = new System.Drawing.Point(106, 94);
            this.kosmetika_count.Name = "kosmetika_count";
            this.kosmetika_count.Size = new System.Drawing.Size(100, 20);
            this.kosmetika_count.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество";
            // 
            // kosmetika_stoimost
            // 
            this.kosmetika_stoimost.Location = new System.Drawing.Point(106, 68);
            this.kosmetika_stoimost.Name = "kosmetika_stoimost";
            this.kosmetika_stoimost.Size = new System.Drawing.Size(100, 20);
            this.kosmetika_stoimost.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Стоимость";
            // 
            // kosmetika_name
            // 
            this.kosmetika_name.Location = new System.Drawing.Point(106, 42);
            this.kosmetika_name.Name = "kosmetika_name";
            this.kosmetika_name.Size = new System.Drawing.Size(100, 20);
            this.kosmetika_name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Имя";
            // 
            // kosmetika_type
            // 
            this.kosmetika_type.Location = new System.Drawing.Point(106, 16);
            this.kosmetika_type.Name = "kosmetika_type";
            this.kosmetika_type.Size = new System.Drawing.Size(100, 20);
            this.kosmetika_type.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Тип";
            // 
            // Подбор_Товара
            // 
            this.Подбор_Товара.Location = new System.Drawing.Point(4, 24);
            this.Подбор_Товара.Name = "Подбор_Товара";
            this.Подбор_Товара.Size = new System.Drawing.Size(670, 330);
            this.Подбор_Товара.TabIndex = 3;
            this.Подбор_Товара.Text = "Подбор Товара";
            this.Подбор_Товара.UseVisualStyleBackColor = true;
            // 
            // Продажа
            // 
            this.Продажа.Location = new System.Drawing.Point(4, 24);
            this.Продажа.Name = "Продажа";
            this.Продажа.Size = new System.Drawing.Size(670, 330);
            this.Продажа.TabIndex = 2;
            this.Продажа.Text = "Продажа";
            this.Продажа.UseVisualStyleBackColor = true;
            // 
            // Характеристика
            // 
            this.Характеристика.Location = new System.Drawing.Point(4, 24);
            this.Характеристика.Name = "Характеристика";
            this.Характеристика.Size = new System.Drawing.Size(670, 330);
            this.Характеристика.TabIndex = 6;
            this.Характеристика.Text = "Характеристика";
            this.Характеристика.UseVisualStyleBackColor = true;
            // 
            // Отчет
            // 
            this.Отчет.Location = new System.Drawing.Point(4, 24);
            this.Отчет.Name = "Отчет";
            this.Отчет.Padding = new System.Windows.Forms.Padding(3);
            this.Отчет.Size = new System.Drawing.Size(670, 330);
            this.Отчет.TabIndex = 1;
            this.Отчет.Text = "Отчет";
            this.Отчет.UseVisualStyleBackColor = true;
            // 
            // Визитка
            // 
            this.Визитка.Location = new System.Drawing.Point(4, 24);
            this.Визитка.Name = "Визитка";
            this.Визитка.Size = new System.Drawing.Size(670, 330);
            this.Визитка.TabIndex = 7;
            this.Визитка.Text = "Визитка";
            this.Визитка.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 364);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CourseWorks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Главная.ResumeLayout(false);
            this.Главная.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Клиент.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.Список.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Товар.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.Каталог.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Добавить.ResumeLayout(false);
            this.Добавить.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Главная;
        private System.Windows.Forms.TabPage Отчет;
        private System.Windows.Forms.TabPage Продажа;
        private System.Windows.Forms.TabPage Подбор_Товара;
        private System.Windows.Forms.TabPage Товар;
        private System.Windows.Forms.TabPage Клиент;
        private System.Windows.Forms.TabPage Характеристика;
        private System.Windows.Forms.TabPage Визитка;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Список;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox client_fio;
        private System.Windows.Forms.Button client_add;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage Каталог;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage Добавить;
        private System.Windows.Forms.DateTimePicker kosmetika_date;
        private System.Windows.Forms.Button kosmetika_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kosmetika_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kosmetika_stoimost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kosmetika_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kosmetika_type;
        private System.Windows.Forms.Label label4;


    }
}

