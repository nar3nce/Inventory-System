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
    public partial class Form_add_Account : Form
    {
        public Form_add_Account(string edited_user, string edited_usertype, string edited_branch, string edited_dept, string username, string action)
        {
            InitializeComponent();
            this.edited_user = edited_user;
            this.edited_usertype = edited_usertype;
            this.edited_branch = edited_branch;
            this.edited_dept = edited_dept;
            this.username = username;
            this.action = action;
        }
        string edited_user, edited_usertype, edited_branch, edited_dept, username, action;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");


        private void cmb_usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_usertype.SelectedIndex == 0 || cmb_usertype.SelectedIndex == 1)
            {

                cmb_branch.Enabled = false;
                cmb_dept.Enabled = false;
            }
            else
            {

                cmb_branch.Enabled = true;
                cmb_dept.Enabled = true;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txtb_password.PasswordChar = '\0';
            }
            else
            {
                txtb_password.PasswordChar = '*';
            }
        }

        int error = 0;

        void validate()
        {
            errorProvider1.Clear();
            error = 0;
            if (string.IsNullOrEmpty(txtb_username.Text))
            {
                errorProvider1.SetError(txtb_username, "Username is empty");
                error++;
            }
            if (string.IsNullOrEmpty(txtb_password.Text))
            {
                errorProvider1.SetError(txtb_password, "Password is empty");
                error++;
            }
            if (txtb_password.TextLength < 6)
            {
                errorProvider1.SetError(txtb_password, "Password length should be greater than 6");
                error++;
            }
            if (cmb_usertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmb_usertype, "Select usertype");
                error++;
            }
            if (action == "add")
            {
                DataTable dt = Account.GetData("select * from tblaccounts where username ='" + txtb_username.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtb_username, "Username already exists");
                    error++;
                }
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (action == "add")
                {
                    validate();
                    if (error == 0)
                    {
                        Account.executeSQL("INSERT INTO tblaccounts VALUES ('" + txtb_username.Text + "' , '" + txtb_password.Text +
                            "' , '" + cmb_usertype.Text + "' , '" + cmb_branch.Text + "' , '" + cmb_dept.Text + "' , 'active')");
                        if (Account.rowAffected > 0)
                        {
                            MessageBox.Show("New Account Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'added new user with username of " + txtb_username.Text + "' , 'Account Management' , '" +
                                username + "')");
                            this.Hide();
                            
                            //refresh datagrid
                            form_accounts add = (form_accounts)Application.OpenForms["form_accounts"];
                            add.refresh();
                      
                        }
                    }
                }

                else if (action == "update")
                {
                    Account.executeSQL(" update tblaccounts set user_type = '" + cmb_usertype.Text + "' , branch = '" + cmb_branch.Text + "' , department = '" + cmb_dept.Text + "' where username = '" + edited_user + "' ");
                    if (Account.rowAffected > 0)
                    {
                        MessageBox.Show(" Account updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                            "' , 'updated an account with username of " + txtb_username.Text + "' , 'Account Management' , '" +
                            username + "')");
                        this.Hide();

                        //refresh datagrid
                        form_accounts update = (form_accounts)Application.OpenForms["form_accounts"];
                        update.refresh();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form_add_Account_Load(object sender, EventArgs e)
        {
            if (action == "update")
            {

                txtb_username.Enabled = false;
                txtb_username.Text = edited_user;
                txtb_username.Enabled = false;
                txtb_password.Enabled = false;
                checkBox1.Visible = false;
                cmb_usertype.Text = edited_usertype;
                cmb_branch.Text = edited_branch;
                cmb_dept.Text = edited_dept;

            }
            

        }
            private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    

     

      
    }
}
