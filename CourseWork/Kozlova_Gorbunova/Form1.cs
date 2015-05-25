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

using iTextSharp.text;
using iTextSharp.text.pdf;

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
                    cmd = new SQLiteCommand("SELECT * FROM kosmetika", cnn);
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
                    cmd = new SQLiteCommand("SELECT * FROM kosmetika", cnn);
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
            cmd = new SQLiteCommand("INSERT INTO client (fio, sym) VALUES (\'" + client_fio.Text + "\', 0)", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлен!");
        }


        private void kosmetika_add_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("INSERT INTO kosmetika (type, name, stoimost, count, end_date) VALUES (\'" + kosmetika_type.Text + "\', \'" + kosmetika_name.Text + "\', " + kosmetika_stoimost.Text + ", " + kosmetika_count.Text + ", \'" + kosmetika_date.Text.Replace('.', '-') + "\');", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно добавлена");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_client.Text != "")
            {
                try
                {
                    cmd = new SQLiteCommand("SELECT * FROM client  WHERE id = '" + id_client.Text + "'", cnn);
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
                Bitmap image1 = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName, true);
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
            gui.DrawString(textBox15.Text.ToString(), new System.Drawing.Font("Arial", 30), Brushes.Pink, new PointF(10, 10));
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
            cmd = new SQLiteCommand("INSERT INTO harakteristika_client(id_client, id_harakteristika) VALUES ('" + textBox18.Text + "', '" + textBox14.Text + "');", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно обновлено!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("INSERT INTO harakteristika_kosmetika(id_kosmetika, id_harakteristika) VALUES ('" + textBox19.Text + "', '" + textBox14.Text + "');", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно обновлено!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("SELECT * FROM kosmetika WHERE id = '" + textBox1.Text + "'", cnn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.FieldCount > 0)
            {
                foreach (DbDataRecord record in reader)
                {
                    textBox20.Text = record["id"].ToString();
                    textBox2.Text = record["type"].ToString();
                    textBox3.Text = record["name"].ToString();
                    textBox4.Text = record["stoimost"].ToString();
                    textBox5.Text = record["count"].ToString();
                    dateTimePicker1.Text = record["end_date"].ToString();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("DELETE FROM kosmetika WHERE id = '" + textBox20.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            textBox20.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";
            MessageBox.Show("Товар удален!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("UPDATE kosmetika SET type = '" + textBox2.Text + "', name = '" + textBox3.Text + "', stoimost = '" + textBox4.Text + "', count = '" + textBox5.Text + "', end_date = '" + dateTimePicker1.Text + "' WHERE id = '" + textBox20.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Успешно обновлено!");
        }

        private void podbor_tovara_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("SELECT harakteristika.name FROM harakteristika, harakteristika_client WHERE  harakteristika.id = harakteristika_client.id_harakteristika AND harakteristika_client.id_client = '" + id_client.Text + "' ", cnn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            listBox2.Items.Clear();

            foreach (DbDataRecord record in reader)
            {
                listBox2.Items.Add(record["name"].ToString());
            }
        }

        private void podobratt_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd = new SQLiteCommand("SELECT kosmetika.id, kosmetika.type, kosmetika.name, kosmetika.stoimost, kosmetika.count, kosmetika.end_date FROM kosmetika, harakteristika, harakteristika_kosmetika WHERE kosmetika.id = harakteristika_kosmetika.id_kosmetika AND  harakteristika_kosmetika.id_harakteristika = harakteristika.id AND harakteristika.name = '" + listBox2.SelectedItem.ToString() + "'  ", cnn);
            dt.Load(cmd.ExecuteReader());
            dataGridView5.DataSource = dt;
        }

        private void pr_zapros_Click(object sender, EventArgs e)
        {

            cmd = new SQLiteCommand("SELECT * FROM kosmetika WHERE id = '" + pr_id_kosmetika.Text + "'", cnn);
            SQLiteDataReader rd = cmd.ExecuteReader();

            rd.Read();
            pr_id_kosmetika_1.Text = rd["id"].ToString();
            pr_kosmetika_name.Text = rd["name"].ToString();
            pr_kosmetika_stoimost.Text = rd["stoimost"].ToString();
            pr_kosmetika_count.Text = pr_count.Text;
            dateTimePicker1.Text = rd["end_date"].ToString();

            cmd = new SQLiteCommand("SELECT * FROM client WHERE id = '" + pr_id_client.Text + "'", cnn);
            SQLiteDataReader rd1 = cmd.ExecuteReader();

            rd1.Read();
            
            pr_id_client_1.Text = rd1["id"].ToString();
            pr_client_fio.Text = rd1["fio"].ToString();
            double skidka = Double.Parse(rd1["sym"].ToString());
            pr_skidka.Text = ((skidka > 10000) ? 10 : (skidka > 5000) ? 5 : 3).ToString();

            pr_stoimost_skidka.Text = ((Double.Parse(pr_kosmetika_stoimost.Text) - ((Double.Parse(pr_kosmetika_stoimost.Text) / 100) * Double.Parse(pr_skidka.Text))) * Int32.Parse(pr_kosmetika_count.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SQLiteCommand("SELECT count FROM kosmetika WHERE kosmetika.id = '" + pr_id_kosmetika_1.Text + "'", cnn);
            SQLiteDataReader rd = cmd.ExecuteReader();
            rd.Read();

            if (Int32.Parse(rd["count"].ToString()) < Int32.Parse(pr_kosmetika_count.Text)) {
                MessageBox.Show("Сделка не может быть совершена из-за отсутствия товара в нужном количестве.");
                return;
            }

            cmd = new SQLiteCommand("INSERT INTO prodaja(id_client, data, sym) VALUES ('" + pr_id_client_1.Text + "', date('now'), '" + pr_stoimost_skidka.Text + "');", cnn);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("SELECT id, data FROM prodaja WHERE id_client = '" + pr_id_client_1.Text + "' ORDER BY id DESC LIMIT 1", cnn);
            SQLiteDataReader rd1 = cmd.ExecuteReader();
            rd1.Read();

            cmd = new SQLiteCommand("INSERT INTO list_prodaja(id_prodaja, id_kosmetika, count, sym) VALUES ('" + rd1["id"].ToString() + "', '" + pr_id_kosmetika_1.Text + "', '" + pr_count.Text + "', '" + pr_stoimost_skidka.Text + "');", cnn);
            cmd.ExecuteNonQuery();

            cmd = new SQLiteCommand("UPDATE client SET sym = sym + '" + pr_stoimost_skidka.Text + "' WHERE id = '" + pr_id_client_1.Text + "'", cnn);
            cmd.ExecuteNonQuery();

            
            cmd = new SQLiteCommand("UPDATE kosmetika SET count = count - '" + pr_count.Text + "' WHERE id = '" + pr_id_kosmetika_1.Text + "'", cnn);
            cmd.ExecuteNonQuery();

            blank_zakaza(rd1["id"].ToString(), 
                         pr_client_fio.Text,
                         pr_id_kosmetika_1.Text,
                         pr_kosmetika_name.Text,
                         pr_kosmetika_count.Text,
                         pr_kosmetika_stoimost.Text,
                         pr_skidka.Text,
                         pr_stoimost_skidka.Text, 
                         rd1["data"].ToString());

            MessageBox.Show("Сделка успешно завершена.");
        }

        private void blank_zakaza(string id_prodaja, string fio, string id_kosmetika, string name_kosmetika, string count, string stoimost, string skidka, string stoimost_so_skidka, string date)
        {
            var doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(@"" + id_prodaja + ".blank_zakaza.pdf", FileMode.Create));
            doc.Open();
            var baseFont = BaseFont.CreateFont("ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var bc = BaseColor.BLACK;
 
            iTextSharp.text.Image k = iTextSharp.text.Image.GetInstance(@"logo.jpg");
            k.Alignment = Element.ALIGN_CENTER;
            doc.Add(k);

            var j = new Phrase("Бланк Заказа\nСетевая косметическая фирма «Бьюти». ", new iTextSharp.text.Font(baseFont, 12, 0, bc));
            var a1 = new Paragraph(j)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 5
            };
            doc.Add(a1);

            doc.Add(new Paragraph("ФИО: " + fio, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            doc.Add(new Paragraph("Номер товара: " + id_kosmetika, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            doc.Add(new Paragraph("Название товара: " + name_kosmetika, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            doc.Add(new Paragraph("Количество: " + count, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            doc.Add(new Paragraph("Цена за единицу: " + stoimost, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            doc.Add(new Paragraph("Скидка: " + skidka, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            doc.Add(new Paragraph("Итоговая стоимость: " + stoimost_so_skidka, new iTextSharp.text.Font(baseFont, 12, 0, bc)));
            var k1 = new Paragraph("\n\nДата заказа: " + date, new iTextSharp.text.Font(baseFont, 12, 0, bc));
            k1.Alignment = Element.ALIGN_RIGHT;
            doc.Add(k1);

            doc.Close();
            //MessageBox.Show("Готово!");
        }

    }
}
