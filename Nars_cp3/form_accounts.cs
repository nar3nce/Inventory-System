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
    public partial class form_accounts : Form
    {
        public form_accounts(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        string username;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void form_accounts_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.SelectedIndex == 0)
            {
                t_username.Visible = true;
                t_user_types.Visible = false;
                t_status.Visible = false;
                t_username.Focus();
            }

            else if (gunaComboBox1.SelectedIndex == 1)
            {
                t_username.Visible = false;
                t_user_types.Visible = true;
                t_status.Visible = false;
                t_user_types.Focus();
            }

            else if (gunaComboBox1.SelectedIndex == 2)
            {
                t_username.Visible = false;
                t_user_types.Visible = false;
                t_status.Visible = true;
                t_status.Focus();
            }
            else
            {
                t_username.Visible = false;
                t_user_types.Visible = false;
                t_status.Visible = false;
            }
        }

        private void t_username_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') and username like '%" + t_username.Text + "%' order by username");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void t_user_types_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (t_user_types.SelectedIndex == 0)
                {
                    DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') and user_type = 'administrator' order by username");
                    dataGridView1.DataSource = dt;

                }
                else if (t_user_types.SelectedIndex == 1)
                {
                    DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') and user_type = 'technical' order by username");
                    dataGridView1.DataSource = dt;

                }

                else
                {

                    DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') and user_type = 'user' order by username");
                    dataGridView1.DataSource = dt;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (t_status.SelectedIndex == 0)
                {
                    DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') and status = 'active' order by username");
                    dataGridView1.DataSource = dt;

                }
                else
                {

                    DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') and status = 'inactive' order by username");
                    dataGridView1.DataSource = dt;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string selected_user; //del, act, deac, 
        int selected_row; // update

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected_row = e.RowIndex;
                selected_user = dataGridView1.Rows[selected_row].Cells[0].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


        }
        private void button1_Click_1(object sender, EventArgs e)
        {


      
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            Form_add_Account addaccount = new Form_add_Account("", "", "", "", username, "add");
            addaccount.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string edited_user, edited_usertype, edited_branch, edited_dept;
            edited_user = dataGridView1.Rows[selected_row].Cells[0].Value.ToString();
            edited_usertype = dataGridView1.Rows[selected_row].Cells[2].Value.ToString();
            edited_branch = dataGridView1.Rows[selected_row].Cells[3].Value.ToString();
            edited_dept = dataGridView1.Rows[selected_row].Cells[4].Value.ToString();

            Form_add_Account edit = new Form_add_Account(edited_user, edited_usertype, edited_branch, edited_dept, username, "update");
            edit.Show();

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Account.executeSQL("update tblaccounts set status = 'active' where username = '" + selected_user + "'");
                if (Account.rowAffected > 0)
                {
                    MessageBox.Show("account activated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'activated  a user with username of " + selected_user + "' , 'Account Management' , '" +
                                username + "')");

                    DataTable dt = Account.GetData("select * from tblaccounts order by username");
                    dataGridView1.DataSource = dt;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Account.executeSQL("update tblaccounts set status = 'inactive' where username = '" + selected_user + "'");
                if (Account.rowAffected > 0)
                {
                    MessageBox.Show("account deactivated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'deactivated a user with username of " + selected_user + "' , 'Account Management' , '" +
                                username + "')");

                    DataTable dt = Account.GetData("select * from tblaccounts order by username");
                    dataGridView1.DataSource = dt;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Account.executeSQL("delete from tblaccounts where username = '" + selected_user + "'");
                if (Account.rowAffected > 0)
                {
                    MessageBox.Show("account Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'deleted a user with username of " + selected_user + "' , 'Account Management' , '" +
                                username + "')");

                    DataTable dt = Account.GetData("select * from tblaccounts order by username");
                    dataGridView1.DataSource = dt;


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            refresh();
        }

        
      
        

        //refresh
        public void refresh()
        {
            try
            {
                DataTable dt = Account.GetData("select * from tblaccounts where not (username ='" + username + "') order by username");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["password"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

    }
}
