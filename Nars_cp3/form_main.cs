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
    public partial class form_main : Form
    {
        public form_main(string username, string usertype)
        {
            InitializeComponent();

            this.username = username;
            this.usertype = usertype;
        }
        string username, usertype;

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_main_Load(object sender, EventArgs e)
        {
            if (usertype == "admin")
            {

                //change design

                welcome.Text = username;
                usertype_label.Text = "administrator";
                big_label.Text = "administrator";
                logo.BackgroundImage = Properties.Resources.admin_icon;
                sidepanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#100c28");

               

                equipment.BackColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                equipment.BaseColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                equipment.OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#363351");

                home.BackColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                home.BaseColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                home.OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#363351");

                change_pass.Visible = false;

                home.Location = new Point(0, 191);
                accounts.Location = new Point(0, 259);
                equipment.Location = new Point(0, 327);
                Returning.Location = new Point(0, 396);
                logs.Location = new Point(0, 466);


                Returning.OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#363351");
                Returning.BackColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                Returning.BaseColor = System.Drawing.ColorTranslator.FromHtml("#100c28");

                accounts.OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#363351");
                accounts.BackColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                accounts.BaseColor = System.Drawing.ColorTranslator.FromHtml("#100c28");

                logs.OnHoverBaseColor = System.Drawing.ColorTranslator.FromHtml("#363351");
                logs.BackColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                logs.BaseColor = System.Drawing.ColorTranslator.FromHtml("#100c28");
                borrow.Visible = false;

            }
            if (usertype == "technical")
            {

                //change design
                usertype_label.Text = "technical";
                big_label.Text = "technical";
                logo.BackgroundImage = Properties.Resources.technical_icon;
                sidepanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#230000");
                welcome.Text = username;
                accounts.Visible = false;
                borrow.Visible = false;
               

                home.Location = new Point(0, 191);
                equipment.Location = new Point(0, 259);
                Returning.Location = new Point(0, 327);
                change_pass.Location = new Point(0, 396);
                logs.Location = new Point(0, 466);
            }

            if (usertype == "user")
            {

                //change design
                usertype_label.Text = "user";
                big_label.Text = "user";
                logo.BackgroundImage = Properties.Resources.user_icon;
                sidepanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#230000");
                welcome.Text = username;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_accounts form_accounts = new form_accounts(username);
            form_accounts.MdiParent = this;
            form_accounts.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_equipments form_equipments = new form_equipments(username);
            form_equipments.MdiParent = this;
            form_equipments.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            home home = new home();
            home.MdiParent = this;
            home.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_logs form_logs = new form_logs(username, usertype);
            form_logs.MdiParent = this;
            form_logs.Show();
        }

        private void accounts_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_accounts form_accounts = new form_accounts(username);
            form_accounts.MdiParent = this;
            form_accounts.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            change_password change_password = new change_password(username);
            change_password.MdiParent = this;
            change_password.Show();
        }

        private void header_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void borrow_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_activity form_activity = new form_activity(username);
            form_activity.MdiParent = this;
            form_activity.Show();


        }

        private void Returning_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_return form_return = new form_return(username);
            form_return.MdiParent = this;
            form_return.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }








    }
}
