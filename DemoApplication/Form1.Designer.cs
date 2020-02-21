namespace DemoApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeKeepingDataSet = new DemoApplication.TimeKeepingDataSet();
            this.customerTableAdapter = new DemoApplication.TimeKeepingDataSetTableAdapters.CustomerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clockOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userActivityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timeKeepingDataSet1 = new DemoApplication.TimeKeepingDataSet1();
            this.timeKeepingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_ActivityTableAdapter = new DemoApplication.TimeKeepingDataSet1TableAdapters.User_ActivityTableAdapter();
            this.customerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new DemoApplication.TimeKeepingDataSet1TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(95, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clock In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(298, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clock Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(721, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Emp_Id", true));
            this.comboBox1.DataSource = this.customerBindingSource;
            this.comboBox1.DisplayMember = "Emp_Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Emp_Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.timeKeepingDataSet;
            // 
            // timeKeepingDataSet
            // 
            this.timeKeepingDataSet.DataSetName = "TimeKeepingDataSet";
            this.timeKeepingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "First_Name", true));
            this.comboBox2.DataSource = this.customerBindingSource;
            this.comboBox2.DisplayMember = "First_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(241, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "First_Name";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Last_Name", true));
            this.comboBox3.DataSource = this.customerBindingSource;
            this.comboBox3.DisplayMember = "Last_Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(241, 182);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(146, 24);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "Last_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 678);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1077, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.clockInDataGridViewTextBoxColumn,
            this.clockOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userActivityBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 653);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            // 
            // clockInDataGridViewTextBoxColumn
            // 
            this.clockInDataGridViewTextBoxColumn.DataPropertyName = "ClockIn";
            this.clockInDataGridViewTextBoxColumn.HeaderText = "ClockIn";
            this.clockInDataGridViewTextBoxColumn.Name = "clockInDataGridViewTextBoxColumn";
            // 
            // clockOutDataGridViewTextBoxColumn
            // 
            this.clockOutDataGridViewTextBoxColumn.DataPropertyName = "ClockOut";
            this.clockOutDataGridViewTextBoxColumn.HeaderText = "ClockOut";
            this.clockOutDataGridViewTextBoxColumn.Name = "clockOutDataGridViewTextBoxColumn";
            // 
            // userActivityBindingSource1
            // 
            this.userActivityBindingSource1.DataMember = "User_Activity";
            this.userActivityBindingSource1.DataSource = this.timeKeepingDataSet1;
            // 
            // timeKeepingDataSet1
            // 
            this.timeKeepingDataSet1.DataSetName = "TimeKeepingDataSet1";
            this.timeKeepingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeKeepingDataSetBindingSource
            // 
            this.timeKeepingDataSetBindingSource.DataSource = this.timeKeepingDataSet;
            this.timeKeepingDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.timeKeepingDataSetBindingSource;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.timeKeepingDataSet;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "Customer";
            this.customerBindingSource3.DataSource = this.timeKeepingDataSetBindingSource;
            // 
            // userActivityBindingSource
            // 
            this.userActivityBindingSource.DataMember = "User_Activity";
            this.userActivityBindingSource.DataSource = this.timeKeepingDataSet1;
            // 
            // user_ActivityTableAdapter
            // 
            this.user_ActivityTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource4
            // 
            this.customerBindingSource4.DataMember = "Customer";
            this.customerBindingSource4.DataSource = this.timeKeepingDataSet1;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 744);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeKeepingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private TimeKeepingDataSet timeKeepingDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private TimeKeepingDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource timeKeepingDataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private TimeKeepingDataSet1 timeKeepingDataSet1;
        private System.Windows.Forms.BindingSource userActivityBindingSource;
        private TimeKeepingDataSet1TableAdapters.User_ActivityTableAdapter user_ActivityTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource4;
        private TimeKeepingDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clockOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userActivityBindingSource1;
    }
}

