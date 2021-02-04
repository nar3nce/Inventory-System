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
    public partial class form_add_equipment : Form
    {
        public form_add_equipment(string assset_number, string serial_number, string branch, string model, string desc, string status, string available, string username, string action)
        {
            InitializeComponent();

            this.assset_number = assset_number;
            this.serial_number = serial_number;
            this.branch = branch;
            this.model = model;
            this.desc = desc;
            this.status = status;
            this.available = available;
            this.username = username;
            this.action = action;
        }
        string assset_number, serial_number, branch, model, desc, status, available, username, action, asset_format;

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.SelectedIndex == 0)
            {

                cmb_available.SelectedIndex = 0;
            }
            else
            {

                cmb_available.SelectedIndex = 1;

            }
        }

        Class1 Account = new Class1("127.0.0.1", "cp3_db", "root", "");


        int error = 0;

        void validate()
        {
            errorProvider1.Clear();
            error = 0;
            if (string.IsNullOrEmpty(txtb_serial.Text))
            {
                errorProvider1.SetError(txtb_serial, "serial is empty");
                error++;
            }
            if (string.IsNullOrEmpty(txtb_desc.Text))
            {
                errorProvider1.SetError(txtb_desc, "description is empty");
                error++;
            }
            if (cmb_branch.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmb_branch, "Select branch");
                error++;
            }
            if (cmb_model.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmb_model, "Select model");
                error++;
            }
            if (cmb_status.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmb_status, "Select status");
                error++;
            }
            if (cmb_available.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmb_available, "Select availabilty");
                error++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asset_format = "AU-" + cmb_branch.Text + DateTime.Now.ToString("-yyyy-MM-");

            try
            {
                if (action == "add")
                {
                    validate();
                    if (error == 0)
                    {
                        Account.executeSQL("INSERT INTO tblequipments VALUES ('" + asset_format + "' , ' ' ,'" + txtb_serial.Text +
                            "' , '" + cmb_branch.Text + "' , '" + cmb_model.Text + "' , '" + txtb_desc.Text + "' , '" + cmb_status.Text + "' , '" + cmb_available.Text + "')");
                        if (Account.rowAffected > 0)
                        {

                            //select inserted item
                            DataTable dt = Account.GetData("select concat(asset_number,num) as asset  from tblequipments where asset_number = '" + asset_format + "' ");
                            string result = dt.Rows[0].Field<string>("asset");

                            //update asset number
                            Account.executeSQL(" update tblequipments set asset_number = '" + result + "' where asset_number = '" + asset_format + "' ");

                            MessageBox.Show("New equipment Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                                "' , 'added new equipment, asset number : "+ result +"' , 'Equipments Management' , '" + username + "')");
                            this.Hide();

                            //refresh datagrid
                            form_equipments add = (form_equipments)Application.OpenForms["form_equipments"];
                            add.refresh();

                        }
                    }
                }

                else if (action == "update")
                {
                    Account.executeSQL(" update tblequipments set serial_number = '" + txtb_serial.Text + "' , branch = '" + cmb_branch.Text + "' , model = '" + cmb_model.Text + "' , description = '" + txtb_desc.Text + "'  , status = '" + cmb_status.Text + "' , available = '" + cmb_available.Text + "' where asset_number = '" + assset_number + "' ");
                    if (Account.rowAffected > 0)
                    {
                        MessageBox.Show(" equipment updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() +
                            "' , 'updated equipment, asset number : " + asset_format + "' , 'Equipments Management' , '" +
                            username + "')");
                        this.Hide();

                        //refresh datagrid
                        form_equipments update = (form_equipments)Application.OpenForms["form_equipments"];
                        update.refresh();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void form_add_equipment_Load(object sender, EventArgs e)
        {
            if (action == "update")
            {

                asset_label.Visible = true;
                asset_label1.Visible = true;
                asset_label.Text = assset_number;
                txtb_serial.Text = serial_number;
                cmb_branch.Enabled = false;
                cmb_branch.Text = branch;
                cmb_model.Text = model;
                txtb_desc.Text = desc;
                cmb_status.Text = status;
                cmb_available.Enabled = false;

             
                


            }

            if (action == "add")
            {


                cmb_status.SelectedIndex = 0;
                cmb_available.SelectedIndex = 0;
                cmb_status.Enabled = false;
                cmb_available.Enabled = false;

            }
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
