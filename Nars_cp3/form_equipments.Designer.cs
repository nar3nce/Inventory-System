namespace Nars_cp3
{
    partial class form_equipments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_status = new Guna.UI.WinForms.GunaComboBox();
            this.t_assetnumber = new System.Windows.Forms.TextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.t_available = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(383, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 60;
            this.label1.Text = "Result :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(42, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 59;
            this.label3.Text = "Search by :";
            // 
            // t_status
            // 
            this.t_status.BackColor = System.Drawing.Color.Transparent;
            this.t_status.BaseColor = System.Drawing.Color.White;
            this.t_status.BorderColor = System.Drawing.Color.Silver;
            this.t_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.t_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_status.FocusedColor = System.Drawing.Color.Empty;
            this.t_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.t_status.ForeColor = System.Drawing.Color.Black;
            this.t_status.FormattingEnabled = true;
            this.t_status.Items.AddRange(new object[] {
            "Working",
            "Repair",
            "Retire"});
            this.t_status.Location = new System.Drawing.Point(468, 70);
            this.t_status.Name = "t_status";
            this.t_status.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.t_status.OnHoverItemForeColor = System.Drawing.Color.White;
            this.t_status.Size = new System.Drawing.Size(121, 26);
            this.t_status.TabIndex = 58;
            this.t_status.Visible = false;
            this.t_status.SelectedIndexChanged += new System.EventHandler(this.t_status_SelectedIndexChanged);
            // 
            // t_assetnumber
            // 
            this.t_assetnumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_assetnumber.Location = new System.Drawing.Point(468, 73);
            this.t_assetnumber.Name = "t_assetnumber";
            this.t_assetnumber.Size = new System.Drawing.Size(100, 20);
            this.t_assetnumber.TabIndex = 56;
            this.t_assetnumber.Visible = false;
            this.t_assetnumber.TextChanged += new System.EventHandler(this.t_assetnumber_TextChanged);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Asset Number",
            "Status",
            "Availability"});
            this.gunaComboBox1.Location = new System.Drawing.Point(152, 68);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 55;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 252);
            this.dataGridView1.TabIndex = 200;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = global::Nars_cp3.Properties.Resources.refresh;
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Location = new System.Drawing.Point(483, 397);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Size = new System.Drawing.Size(97, 35);
            this.gunaButton6.TabIndex = 66;
            this.gunaButton6.Text = "Refresh";
            this.gunaButton6.Click += new System.EventHandler(this.gunaButton6_Click);
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = global::Nars_cp3.Properties.Resources.delete_oc;
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(367, 397);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(97, 35);
            this.gunaButton5.TabIndex = 65;
            this.gunaButton5.Text = "Delete";
            this.gunaButton5.Click += new System.EventHandler(this.gunaButton5_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::Nars_cp3.Properties.Resources.edit_ic;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(254, 397);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(97, 35);
            this.gunaButton2.TabIndex = 62;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Nars_cp3.Properties.Resources.add_ic;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(140, 397);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(97, 35);
            this.gunaButton1.TabIndex = 61;
            this.gunaButton1.Text = "Add";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // t_available
            // 
            this.t_available.BackColor = System.Drawing.Color.Transparent;
            this.t_available.BaseColor = System.Drawing.Color.White;
            this.t_available.BorderColor = System.Drawing.Color.Silver;
            this.t_available.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t_available.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.t_available.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_available.FocusedColor = System.Drawing.Color.Empty;
            this.t_available.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.t_available.ForeColor = System.Drawing.Color.Black;
            this.t_available.FormattingEnabled = true;
            this.t_available.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.t_available.Location = new System.Drawing.Point(468, 70);
            this.t_available.Name = "t_available";
            this.t_available.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.t_available.OnHoverItemForeColor = System.Drawing.Color.White;
            this.t_available.Size = new System.Drawing.Size(121, 26);
            this.t_available.TabIndex = 201;
            this.t_available.Visible = false;
            this.t_available.SelectedIndexChanged += new System.EventHandler(this.t_available_SelectedIndexChanged);
            // 
            // form_equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.t_available);
            this.Controls.Add(this.gunaButton6);
            this.Controls.Add(this.gunaButton5);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_status);
            this.Controls.Add(this.t_assetnumber);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(607, 189);
            this.Name = "form_equipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_equipments";
            this.Load += new System.EventHandler(this.form_equipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox t_status;
        private System.Windows.Forms.TextBox t_assetnumber;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaComboBox t_available;
    }
}