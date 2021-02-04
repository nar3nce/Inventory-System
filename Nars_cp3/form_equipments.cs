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
    public partial class form_equipments : Form
    {
        public form_equipments(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        string username;

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");

        private void form_equipments_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Account.GetData("SELECT * FROM `tblequipments` order by num");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["num"].Visible = false;
                dataGridView1.Columns[0].Width = 140;
                dataGridView1.Columns[1].Width = 140;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            form_add_equipment form_add_equipment = new form_add_equipment("","","","","","","",username, "add");
            form_add_equipment.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //refresh
        public void refresh()
        {
            try
            {
                DataTable dt = Account.GetData("SELECT * FROM `tblequipments` order by num");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["num"].Visible = false;
                dataGridView1.Columns[0].Width = 140;
                dataGridView1.Columns[1].Width = 140;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string assset_number, serial_number, branch, model, desc, status, available;
            assset_number = dataGridView1.Rows[selected_row].Cells[0].Value.ToString();
            serial_number = dataGridView1.Rows[selected_row].Cells[2].Value.ToString();
            branch = dataGridView1.Rows[selected_row].Cells[3].Value.ToString();
            model = dataGridView1.Rows[selected_row].Cells[4].Value.ToString();
            desc = dataGridView1.Rows[selected_row].Cells[5].Value.ToString();
            status = dataGridView1.Rows[selected_row].Cells[6].Value.ToString();
            available = dataGridView1.Rows[selected_row].Cells[7].Value.ToString();


            form_add_equipment edit = new form_add_equipment(assset_number, serial_number, branch, model, desc, status, available, username, "update");
            edit.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Account.executeSQL("delete from tblequipments where asset_number = '" + selected_user + "'");
                if (Account.rowAffected > 0)
                {
                    MessageBox.Show("equipment Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'deleted an equipement, asset number : "+ selected_user+"' , 'Equipment Management' , '" +
                                username + "')");

                    refresh();


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

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.SelectedIndex == 0)
            {
                t_assetnumber.Visible = true;
                t_available.Visible = false;
                t_status.Visible = false;
            }

            else if (gunaComboBox1.SelectedIndex == 1)
            {
                t_status.Visible = true;
                t_assetnumber.Visible = false;
                t_available.Visible = false;
            }

            else if (gunaComboBox1.SelectedIndex == 2)
            {
                t_available.Visible = true;
                t_assetnumber.Visible = false;
                t_status.Visible = false;
            }
          
        }

        private void t_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (t_status.SelectedIndex == 0)
                {
                    DataTable dt = Account.GetData("select * from tblequipments where status = 'WORKING' order by asset_number");
                    dataGridView1.DataSource = dt;

                }
                else if(t_status.SelectedIndex == 1)
                {

                    DataTable dt = Account.GetData("select * from tblequipments where status = 'REPAIR' order by asset_number");
                    dataGridView1.DataSource = dt;


                }
              else
                {

                    DataTable dt = Account.GetData("select * from tblequipments where status = 'RETIRE' order by asset_number");
                    dataGridView1.DataSource = dt;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t_available_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (t_available.SelectedIndex == 0)
                {
                    DataTable dt = Account.GetData("select * from tblequipments where available = 'YES' order by asset_number");
                    dataGridView1.DataSource = dt;

                }
             
                else
                {

                    DataTable dt = Account.GetData("select * from tblequipments where available = 'NO' order by asset_number");
                    dataGridView1.DataSource = dt;


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void t_model_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void t_assetnumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Account.GetData("select * from tblequipments where asset_number like '%" + t_assetnumber.Text + "%' order by num");
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
