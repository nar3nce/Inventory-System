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
    public partial class form_borrow : Form
    {
        public form_borrow(string activity_id, string date, string username, string dept, string actv_name, string actv_date, string actv_purpose,string action)
        {
            InitializeComponent();
            this.activity_id = activity_id;
            this.date = date;
            this.username = username;
            this.dept = dept;
            this.actv_name = actv_name;
            this.actv_date = actv_date;
            this.actv_purpose = actv_purpose;
            this.action = action;

        }

        string activity_id, date, username, dept, actv_name, actv_date, actv_purpose, action;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void form_borrow_Load(object sender, EventArgs e)
        {
            if (action == "add")
            {
                button5.Visible = false;
            }
            if (action == "view")
            {
                button2.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
                button1.Visible = false;
                refresh();
            }
            
                refresh();

           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

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


        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected_row = e.RowIndex;
                selected_user = dataGridView2.Rows[selected_row].Cells[1].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           

           
        }

       //refresh
       public void refresh()
        {

            try
            {

                DataTable dt = Account.GetData("SELECT asset_number, branch, model FROM `tblequipments` where available = 'YES' order by num");
                dataGridView1.DataSource = dt;

                DataTable dt2 = Account.GetData("SELECT activity_id, equipment_id, model,  date_released, date_returned FROM `equipment_borrowed` INNER JOIN tblequipments on equipment_id = tblequipments.asset_number where activity_id = '" + activity_id + "' order by activity_id");
                dataGridView2.DataSource = dt2;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Account.executeSQL("delete from tblborrower where id = '" + selected_user + "'");
                if (Account.rowAffected > 0)
                {
                    MessageBox.Show("Borrowing Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                               "' , 'Deleted Borrow with an id of : " + selected_user + "' , 'Borrowing Management' , '" +
                               username + "')");
                  

                    refresh();


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
             MessageBox.Show("activity Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'updated an activity with an id of " + selected_user + "' , 'Borrowing Management' , '" +
                                username + "')");
            //refresh datagrid
            form_activity add = (form_activity)Application.OpenForms["form_activity"];
            add.Validate();
            add.Refresh();
            add.refresh();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (action == "add")
            {


                try
                {
                    Account.executeSQL("INSERT INTO tblactivity VALUES ('" + activity_id + "' , '" + date + "' , '" + username + "' , '" + dept + "' , '" + actv_name + "' , '" + actv_date + "' , '" + actv_purpose + "' , '  ' , ' ' , ' ' , '')");

                    if (Account.rowAffected > 0)
                    {
                        MessageBox.Show("Activity  Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                            "' , 'Added an Activity with an id of : " + activity_id + "' , 'Borrowing Management' , '" +
                            username + "')");
                        this.Hide();

                        //refresh datagrid
                        form_activity add = (form_activity)Application.OpenForms["form_activity"];
                        add.Validate();
                        add.Refresh();
                        add.refresh();

                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selected_user == null)
            {
                MessageBox.Show("please select an Activity");
            }
            else
            {
                try
                {
                    Account.executeSQL("UPDATE tblequipments SET available = 'YES' WHERE asset_number = '" + selected_user + "'");
                    Account.executeSQL("DELETE FROM equipment_borrowed WHERE equipment_id = '" + selected_user + "'");


                    if (Account.rowAffected > 0)
                    {




                        refresh();


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selected_user == null)
            {
                MessageBox.Show("please select An Equipment");
            }
            else
            {
                try
                {
                    Account.executeSQL("UPDATE tblequipments SET available = 'NO' WHERE asset_number = '" + selected_user + "'");
                    Account.executeSQL("INSERT INTO equipment_borrowed  VALUES ('" + activity_id + "', '" + selected_user + "', ' ', ' ')");


                    if (Account.rowAffected > 0)
                    {



                        refresh();
                        this.Refresh();
                        this.Invalidate();


                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = Account.GetData("SELECT asset_number, branch, model FROM tblequipments WHERE model = '" + gunaComboBox1.SelectedItem.ToString() + "' and available = 'YES' ");
            dataGridView1.DataSource = dt;
        }
    }
}
