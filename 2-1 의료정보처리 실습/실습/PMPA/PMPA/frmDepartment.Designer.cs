namespace PMPA
{
    partial class frmDepartment
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
            System.Windows.Forms.Label deptCodeLabel;
            System.Windows.Forms.Label deptNameLabel;
            this.dataSet1 = new PMPA.DataSet1();
            this.codeDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDeptTableAdapter = new PMPA.DataSet1TableAdapters.CodeDeptTableAdapter();
            this.tableAdapterManager = new PMPA.DataSet1TableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codeDeptDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCodeTextBox = new System.Windows.Forms.TextBox();
            this.deptNameTextBox = new System.Windows.Forms.TextBox();
            deptCodeLabel = new System.Windows.Forms.Label();
            deptNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deptCodeLabel
            // 
            deptCodeLabel.AutoSize = true;
            deptCodeLabel.Location = new System.Drawing.Point(483, 72);
            deptCodeLabel.Name = "deptCodeLabel";
            deptCodeLabel.Size = new System.Drawing.Size(69, 12);
            deptCodeLabel.TabIndex = 3;
            deptCodeLabel.Text = "진료과 코드";
            // 
            // deptNameLabel
            // 
            deptNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            deptNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            deptNameLabel.ForeColor = System.Drawing.Color.White;
            deptNameLabel.Location = new System.Drawing.Point(480, 105);
            deptNameLabel.Name = "deptNameLabel";
            deptNameLabel.Size = new System.Drawing.Size(100, 21);
            deptNameLabel.TabIndex = 4;
            deptNameLabel.Text = "진료과";
            deptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeDeptBindingSource
            // 
            this.codeDeptBindingSource.DataMember = "CodeDept";
            this.codeDeptBindingSource.DataSource = this.dataSet1;
            // 
            // codeDeptTableAdapter
            // 
            this.codeDeptTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodeDeptTableAdapter = this.codeDeptTableAdapter;
            this.tableAdapterManager.CodeDoctorSignTableAdapter = null;
            this.tableAdapterManager.CodeDoctorTableAdapter = null;
            this.tableAdapterManager.CodeInsuranceSubTableAdapter = null;
            this.tableAdapterManager.CodeInsuranceTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMPA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(380, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "신규등록";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(485, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "저장";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(590, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(695, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "진료과 관리";
            // 
            // codeDeptDataGridView
            // 
            this.codeDeptDataGridView.AutoGenerateColumns = false;
            this.codeDeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeDeptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.codeDeptDataGridView.DataSource = this.codeDeptBindingSource;
            this.codeDeptDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.codeDeptDataGridView.Location = new System.Drawing.Point(0, 44);
            this.codeDeptDataGridView.Name = "codeDeptDataGridView";
            this.codeDeptDataGridView.RowTemplate.Height = 23;
            this.codeDeptDataGridView.Size = new System.Drawing.Size(443, 406);
            this.codeDeptDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeptCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "진료과코드";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeptName";
            this.dataGridViewTextBoxColumn2.HeaderText = "진료과";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // deptCodeTextBox
            // 
            this.deptCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDeptBindingSource, "DeptCode", true));
            this.deptCodeTextBox.Location = new System.Drawing.Point(639, 105);
            this.deptCodeTextBox.Name = "deptCodeTextBox";
            this.deptCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.deptCodeTextBox.TabIndex = 4;
            // 
            // deptNameTextBox
            // 
            this.deptNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDeptBindingSource, "DeptName", true));
            this.deptNameTextBox.Location = new System.Drawing.Point(639, 151);
            this.deptNameTextBox.Name = "deptNameTextBox";
            this.deptNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.deptNameTextBox.TabIndex = 5;
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(deptNameLabel);
            this.Controls.Add(this.deptNameTextBox);
            this.Controls.Add(deptCodeLabel);
            this.Controls.Add(this.deptCodeTextBox);
            this.Controls.Add(this.codeDeptDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource codeDeptBindingSource;
        private DataSet1TableAdapters.CodeDeptTableAdapter codeDeptTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView codeDeptDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox deptCodeTextBox;
        private System.Windows.Forms.TextBox deptNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}