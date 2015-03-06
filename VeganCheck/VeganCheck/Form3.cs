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
    public partial class Form3 : Form
    {
        string version = Version.version.ToString();
        string bcod;
        public Form3(string bcod_from_form1)
        {
            bcod = bcod_from_form1;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Имя продукта")
            {
                textBox1.Text = "";
            }
        }


        

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Производитель")
            {
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vegan_cb.Checked == false && veget_cb.Checked == false && neveg_cb.Checked == false)
            {
             { MessageBox.Show("Не выбран статус продукта"); }
               
            }
            else
            {
                string veganstatus_to_edit = "0";
                string vegetstatus_to_edit = "0";
                string testinanimals_to_edit = "0";
                if (neveg_cb.Checked == true)
                {
                    vegetstatus_to_edit = "1";
                    veganstatus_to_edit = "1";
                }
                if (veget_cb.Checked == true)
                {
                    veganstatus_to_edit = "1";
                }
                if (test_in_animals_cb.Checked == true)
                {
                    testinanimals_to_edit = "1";
                }
                string tobase = POST.set(@"http://lumeria.ru/vscaner/tobasenew.php", "bcod=" + bcod + "&name=" + textBox1.Text
                    + "&user_client_app_version=" + "17" + "&user_client_app_identificator=" + "PC " + version + "&user_client_platform_type_index=" + "PC " + version
                    + "&companyname=" + textBox2.Text + "&veganstatus=" + veganstatus_to_edit + "&vegetstatus=" + vegetstatus_to_edit
                    + "&animals=" + testinanimals_to_edit + "&comment=" + "11");
                if (tobase == "0")
                {
                   MessageBox.Show("Принято!Огромное спасибо за вклад в проект");
                }
                else
                {
                    MessageBox.Show("Возникли неполадки с инернет-соединением, попрбуйте еще раз через некоторое время");
                }
                this.Close();
            }
        }
        private void neveg_cb_CheckedChanged(object sender, EventArgs e)
        {
            vegan_cb.Checked = false;
            veget_cb.Checked   = false;
        }

        private void veget_cb_CheckedChanged(object sender, EventArgs e)
        {
            neveg_cb.Checked = false;
            vegan_cb.Checked = false;
        }

        private void vegan_cb_CheckedChanged(object sender, EventArgs e)
        {
            neveg_cb.Checked = false;
            veget_cb.Checked = false;
        }
    }
}
