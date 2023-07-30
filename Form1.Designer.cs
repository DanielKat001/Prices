namespace WindowsFormsApp4
{
    partial class CarPrice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.Company_combo1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Type1_combo1 = new System.Windows.Forms.ComboBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.symbol1 = new System.Windows.Forms.PictureBox();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbol1)).BeginInit();
            this.SuspendLayout();
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(671, 57);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(100, 22);
            this.Price_textBox.TabIndex = 0;
            this.Price_textBox.Text = "1-100,000";
            this.Price_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price_textBox.TextChanged += new System.EventHandler(this.Price_textBox_TextChanged);
            this.Price_textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_textBox_MouseDown);
            // 
            // Year_textBox
            // 
            this.Year_textBox.Location = new System.Drawing.Point(492, 59);
            this.Year_textBox.Name = "Year_textBox";
            this.Year_textBox.Size = new System.Drawing.Size(100, 22);
            this.Year_textBox.TabIndex = 1;
            this.Year_textBox.Text = "2000-2022";
            this.Year_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Year_textBox.TextChanged += new System.EventHandler(this.Year_textBox_TextChanged);
            this.Year_textBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Year_textBox_MouseDown);
            // 
            // Company_combo1
            // 
            this.Company_combo1.Items.AddRange(new object[] {
            "Toyota",
            "Kia",
            "Honda",
            "Suzuki"});
            this.Company_combo1.Location = new System.Drawing.Point(308, 57);
            this.Company_combo1.Name = "Company_combo1";
            this.Company_combo1.Size = new System.Drawing.Size(121, 24);
            this.Company_combo1.TabIndex = 0;
            this.Company_combo1.SelectedIndexChanged += new System.EventHandler(this.Company_combo1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(24, 98);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1162, 369);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Year";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(1042, 473);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(140, 40);
            this.Add_button.TabIndex = 4;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // Type1_combo1
            // 
            this.Type1_combo1.FormattingEnabled = true;
            this.Type1_combo1.Items.AddRange(new object[] {
            "PrivateCar",
            "Motorcycle"});
            this.Type1_combo1.Location = new System.Drawing.Point(108, 59);
            this.Type1_combo1.Name = "Type1_combo1";
            this.Type1_combo1.Size = new System.Drawing.Size(121, 24);
            this.Type1_combo1.TabIndex = 10;
            this.Type1_combo1.SelectedIndexChanged += new System.EventHandler(this.Type1_combo1_SelectedIndexChanged);
            this.Type1_combo1.SelectionChangeCommitted += new System.EventHandler(this.Type1_combo1_SelectionChangeCommitted);
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(900, 473);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(136, 40);
            this.Remove_button.TabIndex = 11;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // symbol1
            // 
            this.symbol1.Location = new System.Drawing.Point(935, 33);
            this.symbol1.Name = "symbol1";
            this.symbol1.Size = new System.Drawing.Size(100, 50);
            this.symbol1.TabIndex = 13;
            this.symbol1.TabStop = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(753, 474);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(126, 39);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(619, 474);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(107, 39);
            this.load_button.TabIndex = 15;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // CarPrice
            // 
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1194, 725);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.symbol1);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Type1_combo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Company_combo1);
            this.Controls.Add(this.Year_textBox);
            this.Controls.Add(this.Price_textBox);
            this.Name = "CarPrice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbol1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Veichle_combo;
        private System.Windows.Forms.ComboBox Type_combo;
        private System.Windows.Forms.ComboBox Company_combo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Year_textBox;
        private System.Windows.Forms.ComboBox Company_combo1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Type1_combo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.PictureBox symbol1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
    }
}

