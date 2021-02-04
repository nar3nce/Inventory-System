using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nars_cp3
{
    public partial class form_logs : Form
    {
        public form_logs(string username, string usertype)
        {
            

            InitializeComponent();
            this.username = username;
            this.usertype = usertype;
        }
        string username, usertype;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");
      

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.SelectedIndex == 0)
            {
                cmb_module.Visible = true;
                b_date.Visible = false;
            }

            else if (gunaComboBox1.SelectedIndex == 1)
            {
                cmb_module.Visible = false;
                b_date.Visible = true;
            }

            else
            {
                cmb_module.Visible = false;
                b_date.Visible = false;
            }
        }


        private void b_date_onValueChanged(object sender, EventArgs e)
        {
           


          

            string dateee = this.b_date.Value.ToString("M/dd/yyyy");

            try
            {

                if (usertype == "admin")
                {
                    DataTable dt = Account.GetData("select * from tbllogs where date like '%" + dateee + "%'  order by date desc");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].Width = 280;
                    dataGridView1.Columns[2].Width = 120;

                }
                else
                {
                    DataTable dt = Account.GetData("select * from tbllogs where username like '%" + username + "%' and date like '%" + dateee + "%'  order by date");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].Width = 280;
                    dataGridView1.Columns[2].Width = 120;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void b_date_Click(object sender, EventArgs e)
        {
           
        }

        private void cmb_module_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               string am = "Account Management";
               string em = "Equipments Management";

                if (usertype == "admin")
                { 

                    if (cmb_module.SelectedIndex == 0)
                    {
                        DataTable dt = Account.GetData("select * from tbllogs where info like '%" + am + "%'  order by date desc");
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[1].Width = 280;
                        dataGridView1.Columns[2].Width = 120;

                    }
                    else
                    {

                        DataTable dt = Account.GetData("select * from tbllogs where info like '%" + em + "%'  order by date desc");
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[1].Width = 280;
                        dataGridView1.Columns[2].Width = 120;
                    }

                }
                else
                {
                    if (cmb_module.SelectedIndex == 0)
                    {
                        DataTable dt = Account.GetData("select * from tbllogs where username like '%" + username + "%' and info like '%" + am + "%'  order by date desc");
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[1].Width = 280;
                        dataGridView1.Columns[2].Width = 120;

                    }
                    else
                    {

                        DataTable dt = Account.GetData("select * from tbllogs where username like '%" + username + "%' and info like '%" + em + "%'  order by date desc");
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns[1].Width = 280;
                        dataGridView1.Columns[2].Width = 120;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void form_logs_Load(object sender, EventArgs e)
        {
            

            try
            {
               

                if (usertype == "admin")
                {
                    DataTable dt = Account.GetData("select * from tbllogs order by date desc");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].Width = 280;
                    dataGridView1.Columns[2].Width = 120;

                }
                else
                {
                    DataTable dt = Account.GetData("select * from tbllogs where username like '%" + username + "%'  order by date desc");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[1].Width = 280;
                    dataGridView1.Columns[2].Width = 120;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
