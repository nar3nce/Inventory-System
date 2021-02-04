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
    public partial class form_activity : Form
    {
        public form_activity(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        string username;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void form_activity_Load(object sender, EventArgs e)
        {
           
            b_date.Value = DateTime.Now;
            refresh();
        }

        //refresh
        public void refresh()
        {
            try
            {
                DataTable dt = Account.GetData("SELECT * FROM `tblactivity` where requestor = '"+username+"' order by id desc");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["date"].Visible = false;
                dataGridView1.Columns["dept"].Visible = false;
                dataGridView1.Columns["activity_name"].Visible = false;
                dataGridView1.Columns["requestor"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            DataTable dt = Account.GetData("select * from tblaccounts where username = '" + username + "' ");
            string dept = dt.Rows[0].Field<string>("department");

            form_add_borrow form_add_borrow = new form_add_borrow(username, dept, "add", "" ,"", "", "" ,"" ,"" ,"");
            form_add_borrow.Show();
        }


        string selected_user; //del, act, deac, 
        int selected_row; // update
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (selected_user == null)
            {
                MessageBox.Show("please select an Activity");
            }
            else
            {
                try
                {
                    DataTable s = Account.GetData("select returned_by, released_by FROM tblactivity WHERE id = '" + selected_user + "'");
                    string s1 = s.Rows[0].Field<string>("returned_by");
                    string s2 = s.Rows[0].Field<string>("released_by");


                    if (string.IsNullOrWhiteSpace(s1.ToString()) && string.IsNullOrWhiteSpace(s2.ToString()))
                    {

                        DataTable dt = Account.GetData("select * FROM equipment_borrowed WHERE activity_id = '" + selected_user + "'");

                        for (int x = 0; x < dt.Rows.Count; x++)
                        {
                            string a = dt.Rows[x].Field<string>("equipment_id");
                            Account.executeSQL("UPDATE tblequipments SET available = 'YES' WHERE asset_number = '" + a + "'");
                        }

                        Account.executeSQL("DELETE FROM tblactivity WHERE id = '" + selected_user + "'");
                        Account.executeSQL("DELETE FROM equipment_borrowed WHERE activity_id = '" + selected_user + "'");
                        MessageBox.Show("activity Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh();



                        Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                    "' , 'deleted an activity with an id of " + selected_user + "' , 'Borrowing Management' , '" +
                                    username + "')");




                    }
                    else
                    {
                        MessageBox.Show("Unable to delete because it has been released or returned");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (selected_user == null)
            {
                MessageBox.Show("please select an Activity");
            }
            else
            {

                //form_borrow form_borrow = new form_borrow(selected_user, "", username, "", "", "", "", "edit");
                //form_borrow.Show();
                //bform_id, bform_date, bform_user, bform_dept, bfrorm_actv_name, bform_avtv_date, bform_actv_purpose;

                DataTable s = Account.GetData("select returned_by, released_by FROM tblactivity WHERE id = '" + selected_user + "'");
                string s1 = s.Rows[0].Field<string>("returned_by");
                string s2 = s.Rows[0].Field<string>("released_by");


                if (string.IsNullOrWhiteSpace(s1.ToString()) && string.IsNullOrWhiteSpace(s2.ToString()))
                {

                    DataTable dt = Account.GetData("select * from tblactivity where id = '" + selected_user + "' ");
                    string bform_id = dt.Rows[0].Field<string>("id");
                    string bform_date = dt.Rows[0].Field<string>("date");
                    string bform_user = dt.Rows[0].Field<string>("requestor");
                    string bform_dept = dt.Rows[0].Field<string>("dept");
                    string bfrorm_actv_name = dt.Rows[0].Field<string>("activity_name");
                    string bform_avtv_date = dt.Rows[0].Field<string>("activity_date");
                    string bform_actv_purpose = dt.Rows[0].Field<string>("activity_purpose");


                    form_add_borrow form_add_borrow = new form_add_borrow(username, "", "edit", bform_id, bform_date, bform_user, bform_dept, bfrorm_actv_name, bform_avtv_date, bform_actv_purpose);
                    form_add_borrow.Show();
                }
            
                else
                {
                    MessageBox.Show("This activity is not able to edit because it has been released or returned");
                }
            }
        }

        private void Activty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Account.GetData("select * from tblactivity");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void b_date_onValueChanged(object sender, EventArgs e)
        {
            string dateee = this.b_date.Value.ToString("M/d/yyyy");

            try
            {
                

                DataTable dt = Account.GetData("select * from tblactivity where requestor like '%" + username + "%' and activity_date like '%" + dateee + "%'  order by id");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].Width = 280;
                dataGridView1.Columns[2].Width = 120;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtb_date_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
