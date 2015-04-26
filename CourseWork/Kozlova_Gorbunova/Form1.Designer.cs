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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Главная = new System.Windows.Forms.TabPage();
            this.Отчет = new System.Windows.Forms.TabPage();
            this.Продажа = new System.Windows.Forms.TabPage();
            this.Подбор_Товара = new System.Windows.Forms.TabPage();
            this.Товар = new System.Windows.Forms.TabPage();
            this.Клиент = new System.Windows.Forms.TabPage();
            this.Характеристика = new System.Windows.Forms.TabPage();
            this.Визитка = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Главная.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Главная);
            this.tabControl1.Controls.Add(this.Отчет);
            this.tabControl1.Controls.Add(this.Продажа);
            this.tabControl1.Controls.Add(this.Подбор_Товара);
            this.tabControl1.Controls.Add(this.Товар);
            this.tabControl1.Controls.Add(this.Клиент);
            this.tabControl1.Controls.Add(this.Характеристика);
            this.tabControl1.Controls.Add(this.Визитка);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 358);
            this.tabControl1.TabIndex = 0;
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
            // Продажа
            // 
            this.Продажа.Location = new System.Drawing.Point(4, 24);
            this.Продажа.Name = "Продажа";
            this.Продажа.Size = new System.Drawing.Size(670, 330);
            this.Продажа.TabIndex = 2;
            this.Продажа.Text = "Продажа";
            this.Продажа.UseVisualStyleBackColor = true;
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
            // Товар
            // 
            this.Товар.Location = new System.Drawing.Point(4, 24);
            this.Товар.Name = "Товар";
            this.Товар.Size = new System.Drawing.Size(670, 330);
            this.Товар.TabIndex = 4;
            this.Товар.Text = "Товар";
            this.Товар.UseVisualStyleBackColor = true;
            // 
            // Клиент
            // 
            this.Клиент.Location = new System.Drawing.Point(4, 24);
            this.Клиент.Name = "Клиент";
            this.Клиент.Size = new System.Drawing.Size(670, 330);
            this.Клиент.TabIndex = 5;
            this.Клиент.Text = "Клиент";
            this.Клиент.UseVisualStyleBackColor = true;
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
            // Визитка
            // 
            this.Визитка.Location = new System.Drawing.Point(4, 24);
            this.Визитка.Name = "Визитка";
            this.Визитка.Size = new System.Drawing.Size(670, 330);
            this.Визитка.TabIndex = 7;
            this.Визитка.Text = "Визитка";
            this.Визитка.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заканчивающейся товар";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Истекающий срок годности";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 137);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(639, 142);
            this.dataGridView2.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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


    }
}

