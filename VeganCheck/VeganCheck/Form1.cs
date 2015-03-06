using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try{
            int version = Version.version;
            string newversion = POST.set("http://lumeria.ru/vscaner/PCVERSION.php", "");
            if (version < Convert.ToInt16(newversion))
            {
                DialogResult dialogResult = MessageBox.Show("На сервере обнаруженны обновления, начать загрузку?", "Внимание! Вы используете устаревшую версию программы", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("VeganCheckUpdate.exe");

                }


                else if (dialogResult == DialogResult.No)
                {

                }

            }
            }
            catch (InvalidCastException e) { }
            InitializeComponent();
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;  
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////ВОЗВРАТ 731
          string respone_from_server = POST.set("http://lumeria.ru/vscaner/index.php", "bcod=" + textBox1.Text);
            if(respone_from_server == "731")
            {
          DialogResult dialogResult = MessageBox.Show("К соажлению в БД нет данных о этом продукте, однако вы  можете помочь проекту и добавить запись, хотите это сделать?", "Запись с данным ШК не обноруженна в базе", MessageBoxButtons.YesNo);
          if (dialogResult == DialogResult.Yes)
          {
              Form3 form3 = new Form3(textBox1.Text);
              form3.Show();
            
          }


          else if (dialogResult == DialogResult.No)
          {

          }
            }
          ///////////
          else
          {
                        
                        string vegetstatus = "Да";
                        if (respone_from_server.Split('§')[2] == "1") { vegetstatus = "Нет"; }
                        string veganstatus = "Да";
                        if (respone_from_server.Split('§')[1] == "1") { veganstatus = "Нет"; }
                        string testinanimals = "Нет";
                        if (respone_from_server.Split('§')[3] == "1") { testinanimals = "Да"; }
                        label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                        label1.Text = "Продукт: " + respone_from_server.Split('§')[0];
                        label2.Text = "Производитель: " + respone_from_server.Split('§')[5];
                        if (testinanimals == "Да")
                        {

                            label4.ForeColor = Color.Red;
                            label4.Text = "НЕ ЭТИЧНЫЙ(ТЕСТЫ НА ЖИВОТНЫХ)";

                        }
                        else
                        {
                            if (veganstatus == "Да")
                            {

                                label4.ForeColor = Color.Green;
                                label4.Text = "ВЕГАНСКИЙ";

                            }
                            else
                            {
                                if (vegetstatus == "Да")
                                {

                                    label4.ForeColor = Color.YellowGreen;
                                    label4.Text = "ВЕГЕТАРИАНСКИЙ";
                                }
                                else
                                {
                                    label4.ForeColor = Color.Red;
                                    label4.Text = "НЕ ЭТИЧНЫЙ(ЖИВОТЫЙ КОМПОНЕНТ)";
                                }
                            }
                        }
                        
          
        }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void модерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openmoders = new Form2();
            try
            {
                openmoders.Show();
            }
            catch
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тестовая версия для VeganCheck Team. По всем вопросам - samokhin@tdelit.ru");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("В это поле необходимо ввести штрих-код.");
               
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("В это поле необходимо ввести штрих-код.");
                textBox1.Text = "";

            }


            if (textBox1.Text.Length < 5)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        

        
    }
}
