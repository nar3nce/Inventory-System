namespace Nars_cp3
{
    partial class form_logs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_module = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.b_date = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(695, 343);
            this.dataGridView1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(454, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "Result :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(69, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "Search by :";
            // 
            // cmb_module
            // 
            this.cmb_module.BackColor = System.Drawing.Color.Transparent;
            this.cmb_module.BaseColor = System.Drawing.Color.White;
            this.cmb_module.BorderColor = System.Drawing.Color.Silver;
            this.cmb_module.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_module.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_module.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_module.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_module.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_module.ForeColor = System.Drawing.Color.Black;
            this.cmb_module.FormattingEnabled = true;
            this.cmb_module.Items.AddRange(new object[] {
            "Accounts",
            "Equipments"});
            this.cmb_module.Location = new System.Drawing.Point(538, 59);
            this.cmb_module.Name = "cmb_module";
            this.cmb_module.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmb_module.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_module.Size = new System.Drawing.Size(121, 26);
            this.cmb_module.TabIndex = 47;
            this.cmb_module.Visible = false;
            this.cmb_module.SelectedIndexChanged += new System.EventHandler(this.cmb_module_SelectedIndexChanged);
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
            "Module",
            "Date and Time"});
            this.gunaComboBox1.Location = new System.Drawing.Point(180, 57);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 44;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // b_date
            // 
            this.b_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.b_date.BorderRadius = 0;
            this.b_date.ForeColor = System.Drawing.Color.White;
            this.b_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.b_date.FormatCustom = "M/dd/yyyy";
            this.b_date.Location = new System.Drawing.Point(535, 54);
            this.b_date.Name = "b_date";
            this.b_date.Size = new System.Drawing.Size(167, 36);
            this.b_date.TabIndex = 50;
            this.b_date.Value = new System.DateTime(2020, 1, 28, 23, 48, 15, 318);
            this.b_date.Visible = false;
            this.b_date.onValueChanged += new System.EventHandler(this.b_date_onValueChanged);
            this.b_date.Click += new System.EventHandler(this.b_date_Click);
            // 
            // form_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.b_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_module);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_logs";
            this.Load += new System.EventHandler(this.form_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmb_module;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Bunifu.Framework.UI.BunifuDatepicker b_date;
    }
}