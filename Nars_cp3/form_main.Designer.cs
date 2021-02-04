namespace Nars_cp3
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.big_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usertype_label = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.Returning = new Guna.UI.WinForms.GunaButton();
            this.change_pass = new Guna.UI.WinForms.GunaButton();
            this.accounts = new Guna.UI.WinForms.GunaButton();
            this.logs = new Guna.UI.WinForms.GunaButton();
            this.equipment = new Guna.UI.WinForms.GunaButton();
            this.home = new Guna.UI.WinForms.GunaButton();
            this.logo = new System.Windows.Forms.Panel();
            this.borrow = new Guna.UI.WinForms.GunaButton();
            this.header.SuspendLayout();
            this.sidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.WhiteSmoke;
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.welcome);
            this.header.Controls.Add(this.label4);
            this.header.Controls.Add(this.panel4);
            this.header.Controls.Add(this.big_label);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(183, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(755, 50);
            this.header.TabIndex = 14;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.BackgroundImage = global::Nars_cp3.Properties.Resources.logout2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(702, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 43);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Blue;
            this.welcome.Location = new System.Drawing.Point(585, 16);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(81, 16);
            this.welcome.TabIndex = 11;
            this.welcome.Text = "Technical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(502, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Welcome :";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Nars_cp3.Properties.Resources.texhnical_top_icon;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(34, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(44, 43);
            this.panel4.TabIndex = 4;
            // 
            // big_label
            // 
            this.big_label.AutoSize = true;
            this.big_label.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big_label.Location = new System.Drawing.Point(79, 13);
            this.big_label.Name = "big_label";
            this.big_label.Size = new System.Drawing.Size(175, 20);
            this.big_label.TabIndex = 2;
            this.big_label.Text = "Technical Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "AU";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "User type :";
            // 
            // usertype_label
            // 
            this.usertype_label.AutoSize = true;
            this.usertype_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.usertype_label.Location = new System.Drawing.Point(76, 146);
            this.usertype_label.Name = "usertype_label";
            this.usertype_label.Size = new System.Drawing.Size(59, 15);
            this.usertype_label.TabIndex = 9;
            this.usertype_label.Text = "Technical";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sidepanel.Controls.Add(this.Returning);
            this.sidepanel.Controls.Add(this.change_pass);
            this.sidepanel.Controls.Add(this.accounts);
            this.sidepanel.Controls.Add(this.logs);
            this.sidepanel.Controls.Add(this.equipment);
            this.sidepanel.Controls.Add(this.home);
            this.sidepanel.Controls.Add(this.usertype_label);
            this.sidepanel.Controls.Add(this.label3);
            this.sidepanel.Controls.Add(this.label2);
            this.sidepanel.Controls.Add(this.logo);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(183, 553);
            this.sidepanel.TabIndex = 13;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidepanel_Paint);
            // 
            // Returning
            // 
            this.Returning.Animated = true;
            this.Returning.AnimationHoverSpeed = 0.07F;
            this.Returning.AnimationSpeed = 0.03F;
            this.Returning.BackColor = System.Drawing.Color.Transparent;
            this.Returning.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.Returning.BorderColor = System.Drawing.Color.Black;
            this.Returning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Returning.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Returning.FocusedColor = System.Drawing.Color.Empty;
            this.Returning.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.Returning.Image = global::Nars_cp3.Properties.Resources.borrow;
            this.Returning.ImageSize = new System.Drawing.Size(30, 30);
            this.Returning.Location = new System.Drawing.Point(-1, 327);
            this.Returning.Name = "Returning";
            this.Returning.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.Returning.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Returning.OnHoverForeColor = System.Drawing.Color.White;
            this.Returning.OnHoverImage = null;
            this.Returning.OnPressedColor = System.Drawing.Color.Black;
            this.Returning.Size = new System.Drawing.Size(184, 74);
            this.Returning.TabIndex = 20;
            this.Returning.Text = "Return";
            this.Returning.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.Returning.Click += new System.EventHandler(this.Returning_Click);
            // 
            // change_pass
            // 
            this.change_pass.Animated = true;
            this.change_pass.AnimationHoverSpeed = 0.07F;
            this.change_pass.AnimationSpeed = 0.03F;
            this.change_pass.BackColor = System.Drawing.Color.Transparent;
            this.change_pass.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.change_pass.BorderColor = System.Drawing.Color.Black;
            this.change_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_pass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.change_pass.FocusedColor = System.Drawing.Color.Empty;
            this.change_pass.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.change_pass.Image = global::Nars_cp3.Properties.Resources.usertype;
            this.change_pass.ImageSize = new System.Drawing.Size(40, 40);
            this.change_pass.Location = new System.Drawing.Point(0, 466);
            this.change_pass.Name = "change_pass";
            this.change_pass.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.change_pass.OnHoverBorderColor = System.Drawing.Color.Black;
            this.change_pass.OnHoverForeColor = System.Drawing.Color.White;
            this.change_pass.OnHoverImage = null;
            this.change_pass.OnPressedColor = System.Drawing.Color.Black;
            this.change_pass.Size = new System.Drawing.Size(184, 74);
            this.change_pass.TabIndex = 18;
            this.change_pass.Text = "Change pass";
            this.change_pass.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.change_pass.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // accounts
            // 
            this.accounts.Animated = true;
            this.accounts.AnimationHoverSpeed = 0.07F;
            this.accounts.AnimationSpeed = 0.03F;
            this.accounts.BackColor = System.Drawing.Color.Transparent;
            this.accounts.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.accounts.BorderColor = System.Drawing.Color.Black;
            this.accounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accounts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.accounts.FocusedColor = System.Drawing.Color.Empty;
            this.accounts.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.accounts.Image = global::Nars_cp3.Properties.Resources.myacc_ic_light1;
            this.accounts.ImageSize = new System.Drawing.Size(30, 30);
            this.accounts.Location = new System.Drawing.Point(-1, 327);
            this.accounts.Name = "accounts";
            this.accounts.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.accounts.OnHoverBorderColor = System.Drawing.Color.Black;
            this.accounts.OnHoverForeColor = System.Drawing.Color.White;
            this.accounts.OnHoverImage = null;
            this.accounts.OnPressedColor = System.Drawing.Color.Black;
            this.accounts.Size = new System.Drawing.Size(184, 74);
            this.accounts.TabIndex = 18;
            this.accounts.Text = "Accounts";
            this.accounts.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.accounts.Click += new System.EventHandler(this.accounts_Click);
            // 
            // logs
            // 
            this.logs.Animated = true;
            this.logs.AnimationHoverSpeed = 0.07F;
            this.logs.AnimationSpeed = 0.03F;
            this.logs.BackColor = System.Drawing.Color.Transparent;
            this.logs.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.logs.BorderColor = System.Drawing.Color.Black;
            this.logs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logs.FocusedColor = System.Drawing.Color.Empty;
            this.logs.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.logs.Image = global::Nars_cp3.Properties.Resources.lgos;
            this.logs.ImageSize = new System.Drawing.Size(40, 40);
            this.logs.Location = new System.Drawing.Point(0, 396);
            this.logs.Name = "logs";
            this.logs.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.logs.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logs.OnHoverForeColor = System.Drawing.Color.White;
            this.logs.OnHoverImage = null;
            this.logs.OnPressedColor = System.Drawing.Color.Black;
            this.logs.Size = new System.Drawing.Size(184, 74);
            this.logs.TabIndex = 17;
            this.logs.Text = "Logs";
            this.logs.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.logs.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // equipment
            // 
            this.equipment.Animated = true;
            this.equipment.AnimationHoverSpeed = 0.07F;
            this.equipment.AnimationSpeed = 0.03F;
            this.equipment.BackColor = System.Drawing.Color.Transparent;
            this.equipment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.equipment.BorderColor = System.Drawing.Color.Black;
            this.equipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equipment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.equipment.FocusedColor = System.Drawing.Color.Empty;
            this.equipment.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.equipment.Image = global::Nars_cp3.Properties.Resources.box;
            this.equipment.ImageSize = new System.Drawing.Size(30, 30);
            this.equipment.Location = new System.Drawing.Point(0, 327);
            this.equipment.Name = "equipment";
            this.equipment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.equipment.OnHoverBorderColor = System.Drawing.Color.Black;
            this.equipment.OnHoverForeColor = System.Drawing.Color.White;
            this.equipment.OnHoverImage = null;
            this.equipment.OnPressedColor = System.Drawing.Color.Black;
            this.equipment.Size = new System.Drawing.Size(184, 74);
            this.equipment.TabIndex = 16;
            this.equipment.Text = "Equipments";
            this.equipment.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.equipment.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // home
            // 
            this.home.Animated = true;
            this.home.AnimationHoverSpeed = 0.07F;
            this.home.AnimationSpeed = 0.03F;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home.BorderColor = System.Drawing.Color.Black;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.home.FocusedColor = System.Drawing.Color.Empty;
            this.home.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.home.Image = global::Nars_cp3.Properties.Resources.home_ic_light;
            this.home.ImageSize = new System.Drawing.Size(30, 30);
            this.home.Location = new System.Drawing.Point(0, 260);
            this.home.Name = "home";
            this.home.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.home.OnHoverBorderColor = System.Drawing.Color.Black;
            this.home.OnHoverForeColor = System.Drawing.Color.White;
            this.home.OnHoverImage = null;
            this.home.OnPressedColor = System.Drawing.Color.Black;
            this.home.Size = new System.Drawing.Size(184, 74);
            this.home.TabIndex = 15;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.Home_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Nars_cp3.Properties.Resources.technical_icon;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(40, 42);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(108, 93);
            this.logo.TabIndex = 3;
            // 
            // borrow
            // 
            this.borrow.Animated = true;
            this.borrow.AnimationHoverSpeed = 0.07F;
            this.borrow.AnimationSpeed = 0.03F;
            this.borrow.BackColor = System.Drawing.Color.Transparent;
            this.borrow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.borrow.BorderColor = System.Drawing.Color.Black;
            this.borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.borrow.FocusedColor = System.Drawing.Color.Empty;
            this.borrow.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.borrow.Image = global::Nars_cp3.Properties.Resources.borrow;
            this.borrow.ImageSize = new System.Drawing.Size(30, 30);
            this.borrow.Location = new System.Drawing.Point(-1, 327);
            this.borrow.Name = "borrow";
            this.borrow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(47)))), ((int)(((byte)(46)))));
            this.borrow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.borrow.OnHoverForeColor = System.Drawing.Color.White;
            this.borrow.OnHoverImage = null;
            this.borrow.OnPressedColor = System.Drawing.Color.Black;
            this.borrow.Size = new System.Drawing.Size(184, 74);
            this.borrow.TabIndex = 19;
            this.borrow.Text = "Borrow";
            this.borrow.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 553);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_main";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label big_label;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usertype_label;
        private Guna.UI.WinForms.GunaButton home;
        private System.Windows.Forms.Panel sidepanel;
        private Guna.UI.WinForms.GunaButton logs;
        private Guna.UI.WinForms.GunaButton equipment;
        private Guna.UI.WinForms.GunaButton accounts;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton change_pass;
        private Guna.UI.WinForms.GunaButton borrow;
        private Guna.UI.WinForms.GunaButton Returning;
    }
}