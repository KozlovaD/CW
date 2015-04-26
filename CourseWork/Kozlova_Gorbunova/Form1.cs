using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
//using System.Data.SqlServerCe;

namespace Koz_Gor_kurs
{
    public partial class Form1 : Form
    {
        private SQLiteConnection cnn = new SQLiteConnection("Data Source = base.db");
        private DataTable dt = new DataTable();
        private SQLiteCommand cmd;

        public Form1()
        {
            InitializeComponent();
            cnn.Open();
            m1_0();
            //SQLiteConnection.CreateFile("base.db");



            //cmd = new SQLiteCommand("CREATE TABLE kosmetika(id int PRIMARY KEY, type TEXT, name TEXT, stoimost DOUBLE, count INTEGER, end_date DATE)", cnn);
            //cmd = new SQLiteCommand("UPDATE kosmetika SET count = 3 WHERE id = 1", cnn);
            //cmd = new SQLiteCommand( "CREATE TABLE client(id INTEGER PRIMARY KEY  AUTOINCREMENT, fio TEXT, sym DOUBLE)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE harakteristika(id int PRIMARY KEY, name TEXT)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE harakteristika_kosmetika(id_kosmetika int, id_harakteristika int)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE harakteristika_client(id_client int, id_harakteristika int)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE prodaja(id int PRIMARY KEY, data DATE, sym DOUBLE, skidka DOUBLE)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE list_prodaja(id_prodaja int, id_client int, id_kosmetika int, count int, sym DOUBLE)", cnn);


            //cmd.CommandText = "DROP TABLE client";
            cmd.ExecuteNonQuery();


            //cnn.Close();

        }

        private void m1_0() {
            cmd = new SQLiteCommand("SELECT * FROM kosmetika ORDER BY end_date", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dt;

            dt = new DataTable();

            cmd = new SQLiteCommand("SELECT * FROM kosmetika WHERE count < 5 ORDER BY count", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;        
        }
        private void m1_1() {
            m2_0();
        }
        private void m2_0() {
            //cmd.CommandText = "DELETE FROM client";
            //cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM client";
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView3.DataSource = dt;
        }
        private void m2_1() {
            //вкладка добавление пользователя
        }

        private void TabControl1_Selected(Object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: //главная
                    m1_0();
                    break;
                case 1://клиент
                    m1_1(); 
                    break;
                case 2://товар
                    MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 3://подбор товара
                    MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 4://продажа
                    MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 5://характеристика
                    MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 6://отчет 
                    MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 7://визитка
                    MessageBox.Show("Выбрана первая вкладка");
                    break;
                default://
                    MessageBox.Show("Шойтан, как ты суда попал? " + e.TabPageIndex);
                    break;
            }
        }


        private void TabControl2_Selected(Object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: //список
                    m2_0();
                break;
                case 1: //добавить
                    m2_1();
                break;

                default://
                    MessageBox.Show("Шойтан, как ты суда попал? " + e.TabPageIndex);
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click  (object sender, EventArgs e)
        {
           
        }

        private void Главная_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Список_Click(object sender, EventArgs e)
        {

        }

        private void client_add_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO client (fio, sym) VALUES (\'" + client_fio.Text + "\', 0)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлен!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
