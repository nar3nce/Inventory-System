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
    public partial class form_add_borrow : Form
    {
        public form_add_borrow(string username, string dept, string action, string bform_id, string bform_date, string bform_user, string bform_dept, string bfrorm_actv_name, string bform_avtv_date, string bform_actv_purpose)
        {
            InitializeComponent();
            this.username = username;
            this.dept = dept;
            this.action = action;

            this.bform_id = bform_id;
            this.bform_date = bform_date;
            this.bform_user = bform_user;
            this.bform_dept = bform_dept;
            this.bfrorm_actv_name = bfrorm_actv_name;
            this.bform_avtv_date = bform_avtv_date;
            this.bform_actv_purpose = bform_actv_purpose;

        }

        string username, dept, action, bform_id, bform_date, bform_user, bform_dept, bfrorm_actv_name, bform_avtv_date, bform_actv_purpose;

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                if (error == 0)
                {
                    this.Hide();
                    Account.executeSQL(" UPDATE tblactivity SET activity_name = '"+ txtb_avtivity.Text +"', activity_date = '"+ txtb_date.Text + "', activity_purpose = '"+ txtb_purpose.Text +"' WHERE id = '"+ bform_id+"' ");
                    form_borrow form_borrow = new form_borrow(bform_id, "", username, "", "", "", "", "edit");
                    form_borrow.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void panel13_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string borrow_form_id_format = DateTime.Now.ToString("yyyyMMddHHmmss");
        string date_now = DateTime.Now.ToString("yyyy-MM-dd");
        private void form_add_borrow_Load(object sender, EventArgs e)
        {
            if (action == "edit")
            {
                borrow_form_id.Text = bform_id;
                borrow_date.Text = bform_date;
                username_label.Text = bform_user;
                dept_label.Text = bform_dept;
                txtb_avtivity.Text = bfrorm_actv_name;
                txtb_date.MinDate = DateTime.Parse(bform_avtv_date);


                txtb_purpose.Text = bform_actv_purpose;
            }

            else if(action == "add")
            {

                Edit.Visible = false;
                txtb_date.MinDate = DateTime.Now;
                borrow_form_id.Text = borrow_form_id_format;
                borrow_date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
                username_label.Text = username;
                dept_label.Text = dept;
            }
        }


        int error = 0;

        void validate()
        {
            errorProvider1.Clear();
            error = 0;
            if (string.IsNullOrEmpty(txtb_avtivity.Text))
            {
                errorProvider1.SetError(txtb_avtivity, "activity is empty");
                error++;
            }
            if (string.IsNullOrEmpty(txtb_date.Text))
            {
                errorProvider1.SetError(txtb_date, "date is empty");
                error++;
            }
            if (string.IsNullOrEmpty(txtb_purpose.Text))
            {
                errorProvider1.SetError(txtb_purpose, "purpose is empty");
                error++;
            }

        }

        private void txtb_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                if (error == 0)
                {
                    this.Hide();
                    form_borrow form_borrow = new form_borrow(borrow_form_id_format,date_now,username,dept, txtb_avtivity.Text, txtb_date.Text, txtb_purpose.Text,"add");
                    form_borrow.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
