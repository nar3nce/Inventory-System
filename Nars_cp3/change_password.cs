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
    public partial class change_password : Form
    {
        public change_password(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        string username;


        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_password_Load(object sender, EventArgs e)
        {
            txtb_username.Text = username;
            txtb_username.Enabled = false;
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
            else if (string.IsNullOrEmpty(p1.Text))
            {
                errorProvider1.SetError(p1, "Password is empty");
                error++;
            }
            else if (p1.TextLength < 6)
            {
                errorProvider1.SetError(p1, "Password length should be greater than 6");
                error++;
            }
            else if (string.IsNullOrEmpty(p2.Text))
            {
                errorProvider1.SetError(p2, "Password is empty");
                error++;
            }
            else if(p2.TextLength < 6)
            {
                errorProvider1.SetError(p2, "Password length should be greater than 6");
                error++;
            }
            else if(p1.Text != p2.Text)
            {
                errorProvider1.SetError(p2, "Password not Match");
                error++;
            }
            else
            {
                error = 0;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                if (error == 0)
                {
                    Account.executeSQL(" update tblaccounts set password = '" + p2.Text + "' where username = '" + username + "' ");
                    if (Account.rowAffected > 0)
                    {
                        MessageBox.Show(" Account updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                            "' , '"+ username +" Changed password ' , 'Account Management' , '" +
                            username + "')");
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                p1.PasswordChar = '\0';
                p2.PasswordChar = '\0';
            }
            else
            {
                p1.PasswordChar = '*';
                p2.PasswordChar = '*';
            }
        }
    }
}
