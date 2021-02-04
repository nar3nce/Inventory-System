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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        Class1 Login = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Login.GetData("select * from tblaccounts where username = '" + txtusername.Text +
                 "' and password = '" + txtpassword.Text + "' and status = 'active'");
                if (dt.Rows.Count > 0)
                {
                    form_main main = new form_main(txtusername.Text, dt.Rows[0].Field<string>("user_type"));
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password or account is inactive", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
