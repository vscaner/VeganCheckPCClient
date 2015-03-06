using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string bcodtogoogle = "";
        string login = "";
        string password = "";
        public Form2()
        {
            
            InitializeComponent();
            string[] logpass = ShowDialog();
            login = logpass[0];
            password = logpass[1];
            label4.Text = login;
            start();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string bcod_to_edit = dataGridView1.Rows[e.RowIndex].Cells["bcod"].Value.ToString();
            string name_to_edit = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
            string companyname_to_edit = dataGridView1.Rows[e.RowIndex].Cells["companyname"].Value.ToString();
            string vegetstatus_to_edit_RAW = dataGridView1.Rows[e.RowIndex].Cells["vegetstatus"].Value.ToString();
            string vegetstatus_to_edit = "0";
            if (vegetstatus_to_edit_RAW == "Нет")
            {
                vegetstatus_to_edit = "1";
            }
             string veganstatus_to_edit_RAW = dataGridView1.Rows[e.RowIndex].Cells["veganstatus"].Value.ToString();
             string veganstatus_to_edit = "0";
            if (veganstatus_to_edit_RAW == "Нет")
            {
                veganstatus_to_edit = "1";
            }
            string testinanimals_to_edit_RAW = dataGridView1.Rows[e.RowIndex].Cells["testinanimals"].Value.ToString();
             string testinanimals_to_edit = "1";
            if (testinanimals_to_edit_RAW == "Нет")
            {
                testinanimals_to_edit = "0";
            }
         

            if (e.ColumnIndex == dataGridView1.Columns["ok"].Index)
            {
                
                POST.set("http://lumeria.ru/vscaner/up.php", "log=" + login + "&pas=" + password + "&bcod=" + bcod_to_edit + "&name=" + name_to_edit
                + "&user_client_app_version=" + "15" + "&user_client_app_identificator=" + "15" + "&user_client_platform_type_index=" + "15"
                + "&companyname=" + companyname_to_edit + "&veganstatus=" + veganstatus_to_edit + "&vegetstatus=" + vegetstatus_to_edit
                + "&animals=" + testinanimals_to_edit + "&moderator_name=" + login + "&moderate=" + "1"
                    );
                start(); 
            }
            if (e.ColumnIndex == dataGridView1.Columns["del"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Вы пытаетесь удалить запись из БД, эта процедура необратима, Вы точно хотите продолжить?", "Удаление записи", MessageBoxButtons.YesNo);
    if(dialogResult == DialogResult.Yes)
    {
        POST.set("http://lumeria.ru/vscaner/drop.php", "log=" + login + "&pas=" + password + "&bcod=" + bcod_to_edit);
        start();

}
    else if (dialogResult == DialogResult.No)
    {
    
    }
            }
            if (e.ColumnIndex == dataGridView1.Columns["google"].Index)
            {
                Process.Start("http://google.com/search?q=" + bcod_to_edit);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            start();  
            
        }
    
        public static string[] ShowDialog()
        {
            FileInfo loginfile = new FileInfo("settings.dat");
            if (loginfile.Exists == false)
            {
                
                using (FileStream sw = File.Create("settings.dat"))
                {
                    sw.Close();
                }
               
                using (StreamWriter sw = new  StreamWriter("settings.dat"))
                {
                    sw.WriteLine(" ");
                    sw.Close();
                   
                }
            }
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = "Авторизация";
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 400, Text = "Ведите логин/пароль" };
            string[] logintext = File.ReadAllLines("settings.dat");
            TextBox inputBoxLoging = new TextBox() { Left = 50, Top = 50, Width = 400 };
            TextBox inputBoxPassword = new TextBox() { Left = 50, Top = 70, Width = 400 };
            inputBoxPassword.UseSystemPasswordChar = true;
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 90 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBoxLoging);
            inputBoxLoging.Text = logintext[0];
            prompt.Controls.Add(inputBoxPassword);
            prompt.ShowDialog();
            string[] lp = {"",""};
            lp[0] = inputBoxLoging.Text;
            lp[1] = inputBoxPassword.Text;
            return lp;
        }



        public void start()
        {
            dataGridView1.Rows.Clear();
            using (StreamWriter sw = new StreamWriter("settings.dat"))
            {
                sw.WriteLine(login);
                sw.Close();

            }
            string data = POST.set("http://lumeria.ru/vscaner/getnomoders.php", "log=" + login + "&pas=" + password);
            var s = data;
            var p = "|";
            int i1 = 0;
            int count = 0;
            while ((i1 = s.IndexOf(p, i1)) != -1) { ++count; i1 += p.Length; }
            //Проверка ну пустые значения
            if (login == " ")
            {
                this.Close();
            }
            else
            {
                //ПРОВЕРКА НА НЕКОНЕКТ
                var pn = "999ua11";
                int i1n = 0;
                int countn = 0;
                while ((i1n = s.IndexOf(pn, i1n)) != -1) { ++countn; i1n += pn.Length; }
                if (countn > 0)
                {
                    MessageBox.Show("Не верно введены логин/пароль");
                    this.Close();
                }
                //
                else
                    for (int i = 1; i <= count; i++)
                    {
                        string row = data.Split('|')[i];
                        string vegetstatus = "Да";
                        if (row.Split('§')[3] == "1") { vegetstatus = "Нет"; }
                        string veganstatus = "Да";
                        if (row.Split('§')[2] == "1") { veganstatus = "Нет"; }
                        string testinanimals = "Нет";
                        if (row.Split('§')[4] == "1") { testinanimals = "Да"; }
                        string[] row0 = { row.Split('§')[0], row.Split('§')[1], row.Split('§')[6]
          , vegetstatus, veganstatus, testinanimals,"Искать по ШК","Одобряю","Удалить"};

                        dataGridView1.Rows.Add(row0);
                    }
                label2.Text = count.ToString();

            }
        }
    }
}
