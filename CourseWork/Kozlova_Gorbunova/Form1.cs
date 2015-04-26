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
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Hello");
             FillData();
        }

        void FillData()
        {
            //SQLiteConnection.CreateFile("base.db");

            SQLiteConnection cnn = new SQLiteConnection("Data Source = base.db");
            DataTable dt = new DataTable();
            SQLiteCommand cmd;
            cnn.Open();

            //cmd = new SQLiteCommand("CREATE TABLE kosmetika(id int PRIMARY KEY, type TEXT, name TEXT, stoimost DOUBLE, count INTEGER, end_date DATE)", cnn);
            //cmd = new SQLiteCommand("UPDATE kosmetika SET count = 3 WHERE id = 1", cnn);
            //cmd = new SQLiteCommand( "CREATE TABLE client(id int PRIMARY KEY, fio TEXT, sym DOUBLE)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE harakteristika(id int PRIMARY KEY, name TEXT)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE harakteristika_kosmetika(id_kosmetika int, id_harakteristika int)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE harakteristika_client(id_client int, id_harakteristika int)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE prodaja(id int PRIMARY KEY, data DATE, sym DOUBLE, skidka DOUBLE)", cnn);
            //cmd = new SQLiteCommand("CREATE TABLE list_prodaja(id_prodaja int, id_client int, id_kosmetika int, count int, sym DOUBLE)", cnn);
            //cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("SELECT * FROM kosmetika ORDER BY end_date", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dt;

            dt = new DataTable();

            cmd = new SQLiteCommand("SELECT * FROM kosmetika WHERE count < 5 ORDER BY count", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

            cnn.Close();

/*
            var sql_con = new SQLiteConnection("Data Source = base.db");
            var txtQuery = "SELECT * FROM kosmetika ORDER BY time_end_kosmetika";
            //var txtQuery = "INSERT INTO `kosmetika` (`id`, `type`, `name`, `stoimost`, `count`, `end_date`) VALUES (2, 'pomada', 'pomada_2', 140, 10, '2016-04-01');";
            sql_con.Open();

            var sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;

            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
*/            
            /*
            using (SqlCeConnection c = new SqlCeConnection(
Properties.Settings.Default.DatabaseConnectionString))
            {
                c.Open();
                // 2
                // Create new DataAdapter
                using (SqlCeDataAdapter a = new SqlCeDataAdapter(
                    "SELECT * FROM kosmetika ORDER BY time_end_kosmetika", c))
                {
                    // 3
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);
                    // 4
                    // Render data onto the screen
                    dataGridView2.DataSource = t;
                }
            }*/

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
    }
}
