using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;
using System.Drawing.Imaging;
using System.Data.Common;

namespace Koz_Gor_kurs
{
    public partial class Form1 : Form
    {
        private SQLiteConnection cnn;
        private DataTable dt = new DataTable();
        private SQLiteCommand cmd;

        public Form1()
        {
            InitializeComponent();
           

            if (File.Exists("base.db")) 
            {
                cnn = new SQLiteConnection("Data Source = base.db");
                cnn.Open();
            }
            else 
            {
                SQLiteConnection.CreateFile("base.db");                
                cnn = new SQLiteConnection("Data Source = base.db");
                cnn.Open();
                
                cmd = new SQLiteCommand("CREATE TABLE client(id INTEGER PRIMARY KEY  AUTOINCREMENT, fio TEXT, sym DOUBLE)", cnn);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE kosmetika(id INTEGER PRIMARY KEY AUTOINCREMENT, type TEXT, name TEXT, stoimost DOUBLE, count INTEGER, end_date DATE)"; 
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE harakteristika(id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE harakteristika_kosmetika(id_kosmetika int, id_harakteristika int)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE harakteristika_client(id_client int, id_harakteristika int)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE prodaja(id int PRIMARY KEY, data DATE, sym DOUBLE, skidka DOUBLE)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "CREATE TABLE list_prodaja(id_prodaja int, id_client int, id_kosmetika int, count int, sym DOUBLE)";
                cmd.ExecuteNonQuery();

            }

            dt = new DataTable();
            cmd = new SQLiteCommand("SELECT * FROM kosmetika ORDER BY end_date", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView2.DataSource = dt;

            dt = new DataTable();
            cmd = new SQLiteCommand("SELECT * FROM kosmetika WHERE count < 5 ORDER BY count", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;

        }


        private void TabControl1_Selected(Object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: //главная
                    dt = new DataTable();
                    cmd = new SQLiteCommand("SELECT * FROM kosmetika ORDER BY end_date", cnn);
                    dt.Load(cmd.ExecuteReader());
                    dataGridView2.DataSource = dt;

                    dt = new DataTable();
                    cmd = new SQLiteCommand("SELECT * FROM kosmetika WHERE count < 5 ORDER BY count", cnn);
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    break;
                case 1://клиент
                    cmd = new SQLiteCommand("SELECT * FROM client", cnn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView3.DataSource = dt;

                    break;
                case 2://товар
                    dt = new DataTable();
                    cmd.CommandText = "SELECT * FROM kosmetika";
                    dt.Load(cmd.ExecuteReader());
                    dataGridView4.DataSource = dt;
                    break;
                case 3://подбор товара
                    
                    break;
                case 4://продажа
                  //  MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 5://характеристика                  
                    dt = new DataTable();
                    cmd = new SQLiteCommand("SELECT * FROM harakteristika", cnn);
                    dt.Load(cmd.ExecuteReader());
                    dataGridView6.DataSource = dt;
                    break;
                case 6://отчет 
                   // MessageBox.Show("Выбрана первая вкладка");
                    break;
                case 7://визитка
                   // MessageBox.Show("Выбрана первая вкладка");
                    break;
            }
        }


        private void TabControl2_Selected(Object sender, TabControlEventArgs e) // меню клиент
        {
            switch (e.TabPageIndex)
            {
                case 0: //список
                    cmd = new SQLiteCommand("SELECT * FROM client", cnn);
                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView3.DataSource = dt;
                    break;
                case 1: //добавить
                    
                    break;
                case 2: // редактировать
                    break;
            }
        }

        private void TabControl3_Selected(Object sender, TabControlEventArgs e) // меню товар 
        {
            switch (e.TabPageIndex)
            {
                case 0: //список
                    dt = new DataTable();
                    cmd.CommandText = "SELECT * FROM kosmetika";
                    dt.Load(cmd.ExecuteReader());
                    dataGridView4.DataSource = dt;
                    break;
                case 1: //добавить
                    //MessageBox.Show("Add tovar");
                    break;
                case 2: // редактировать
                    break;
            }
        }

        private void client_add_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO client (fio, sym) VALUES (\'" + client_fio.Text + "\', 0)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлен!");
        }


        private void kosmetika_add_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO kosmetika (type, name, stoimost, count, end_date) VALUES (\'" + kosmetika_type.Text + "\', \'" + kosmetika_name.Text + "\', " + kosmetika_stoimost.Text + ", " + kosmetika_count.Text + ", \'" + kosmetika_date.Text.Replace('.', '-') + "\');";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлена");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_client.Text != "")
            {
                try
                {
                    cmd.CommandText = "SELECT * FROM client  WHERE id = '" + id_client.Text + "'";
                    MessageBox.Show("Введено число!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введено не число!");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("SELECT * FROM client WHERE id = '" + textBox6.Text + "'", cnn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.FieldCount > 0)
            {
                foreach (DbDataRecord record in reader)
                {
                    textBox17.Text = record["id"].ToString();
                    textBox7.Text = record["fio"].ToString();
                    textBox8.Text = record["sym"].ToString();
                }
            }
            else
            {
                textBox17.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var res = openFileDialog1.ShowDialog();
           if (res == DialogResult.OK)
            {
                Bitmap image1 = (Bitmap)Image.FromFile(openFileDialog1.FileName, true);
                //Graphics gui = Graphics.FromImage(image1);
                //gui.DrawString(textBox15.Text.ToString(), new Font("Arial", 16), Brushes.Pink, new PointF(10, 10));
                pictureBox1.Image = image1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(saveFileDialog1.FileName, format);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            EMailSender.SendMessage("smtp.mail.ru", "isebd@mail.ru", "qwe123rty456", textBox16.Text, "expirience", "Привет, меня зовут Дарья Козлова и я хочу отправить  тебе свой отчёт!!!");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Graphics gui = Graphics.FromImage(pictureBox1.Image);
            gui.DrawString(textBox15.Text.ToString(), new Font("Arial", 30), Brushes.Pink, new PointF(10, 10));
            pictureBox1.Image = pictureBox1.Image;    
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO harakteristika(name) VALUES ('" + textBox13.Text + "');";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлена");

            dt = new DataTable();
            cmd = new SQLiteCommand("SELECT * FROM harakteristika", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView6.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand( "DELETE FROM client WHERE id = '" + textBox17.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            textBox17.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            MessageBox.Show("Клиент удален!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("UPDATE client SET fio = '" + textBox7.Text + "', sym = '" + textBox8.Text + "' WHERE id = '" + textBox17.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно обновлено!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("INSERT INTO harakteristika_client(id_client, id_harakteristika) VALUES ('" + textBox18.Text + "', '" + textBox14 + "');", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно обновлено!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("INSERT INTO harakteristika_kosmetika(id_kosmetika, id_harakteristika) VALUES ('" + textBox19.Text + "', '" + textBox14 + "');", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно обновлено!");
        }

    }
}
