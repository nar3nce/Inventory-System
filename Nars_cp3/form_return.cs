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
    public partial class form_return : Form
    {
        public form_return(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        string username;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

      

        private void form_return_Load(object sender, EventArgs e)
        {
            b_date.Value = DateTime.Now;
            refresh();
        }

        //refresh
        public void refresh()
        {
            try
            {
                DataTable dt = Account.GetData("SELECT * FROM `tblactivity` order by id desc");
                dataGridView2.DataSource = dt;
                dataGridView2.Columns["id"].Visible = false;
                dataGridView2.Columns["date"].Visible = false;

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        string selected_user; //del, act, deac, 
        int selected_row; // update

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected_row = e.RowIndex;
                selected_user = dataGridView2.Rows[selected_row].Cells[0].Value.ToString();
             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (selected_user == null)
            {
                MessageBox.Show("please select an Activity");
            }
            else
            {
                form_borrow form_borrow = new form_borrow(selected_user, "", "", "", "", "", "", "view");
                form_borrow.Show();
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
                try
                {
                    DataTable s = Account.GetData("select returned_by, released_by FROM tblactivity WHERE id = '" + selected_user + "'");
                    string s1 = s.Rows[0].Field<string>("returned_by");
                  

                    if (string.IsNullOrWhiteSpace(s1.ToString()))
                    {

                        string s2 = s.Rows[0].Field<string>("released_by");

                        if (string.IsNullOrWhiteSpace(s2.ToString()))
                        {


                            MessageBox.Show("Activity is Not yet Released!");
                        }
                        else
                        {
                            
                            DataTable dt = Account.GetData("select * FROM equipment_borrowed WHERE activity_id = '" + selected_user + "'");

                            for (int x = 0; x < dt.Rows.Count; x++)
                            {
                                string a = dt.Rows[x].Field<string>("equipment_id");

                                Account.executeSQL("UPDATE tblequipments SET available = 'YES' WHERE asset_number = '" + a + "'");
                                Account.executeSQL("UPDATE equipment_borrowed SET date_returned = '" + DateTime.Now.ToString() + " ' WHERE equipment_id = '" + a + "'");
                            }


                            Account.executeSQL("update tblactivity set date_returned = '" + DateTime.Now.ToString() + "' WHERE id = '" + selected_user + "' ");
                            Account.executeSQL("update tblactivity set returned_by = '" + username + "' WHERE id = '" + selected_user + "' ");
                            Account.executeSQL("DELETE FROM equipment_borrowed WHERE activity_id = '" + selected_user + "'");
                            if (Account.rowAffected > 0)
                            {

                                MessageBox.Show("Equipments Returned", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                            "' , 'Return an activity with an id of " + selected_user + "' , 'Return Management' , '" +
                                            username + "')");

                                refresh();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Activity is Already Returned!");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

                    DataTable s = Account.GetData("select released_by FROM tblactivity WHERE id = '" + selected_user + "'");

                    string s1 = s.Rows[0].Field<string>("released_by");

                  
                    if (string.IsNullOrWhiteSpace(s1.ToString()))
                    {
                        DataTable dt = Account.GetData("select * FROM equipment_borrowed WHERE activity_id = '" + selected_user + "'");

                        for (int x = 0; x < dt.Rows.Count; x++)
                        {
                            string a = dt.Rows[x].Field<string>("equipment_id");


                            Account.executeSQL("UPDATE equipment_borrowed SET date_released = '" + DateTime.Now.ToString() + " ' WHERE equipment_id = '" + a + "'");
                        }


                        Account.executeSQL("update tblactivity set date_released = '" + DateTime.Now.ToString() + "' WHERE id = '" + selected_user + "' ");
                        Account.executeSQL("update tblactivity set released_by = '" + username + "' WHERE id = '" + selected_user + "' ");
                        if (Account.rowAffected > 0)
                        {

                            MessageBox.Show("Equipments Released", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                        "' , 'Released an activity with an id of " + selected_user + "' , 'Return Management' , '" +
                                        username + "')");

                            refresh();


                        }
                        // MessageBox.Show("Activity is not Released!");
                    }
                    else
                    {
                        MessageBox.Show("Activity is Already Released!");
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void b_date_onValueChanged(object sender, EventArgs e)
        {
            string dateee = this.b_date.Value.ToString("M/d/yyyy");

            try
            {


                DataTable dt = Account.GetData("select * from tblactivity where activity_date like '%" + dateee + "%'  order by id");
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[1].Width = 280;
                dataGridView2.Columns[2].Width = 120;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (selected_user == null)
            {
                MessageBox.Show("please select an Activity");
            }
            else
            {
                try
                {
                    DataTable s = Account.GetData("select * FROM tblactivity WHERE id = '" + selected_user + "'");
                    string s1 = s.Rows[0].Field<string>("returned_by");


                    if (string.IsNullOrWhiteSpace(s1.ToString()))
                    {
                        MessageBox.Show("Activity is not yet returned!");

                    }
                    else
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
                                    "' , 'deleted an activity with an id of " + selected_user + "' , 'Returning Management' , '" +
                                    username + "')");

                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
