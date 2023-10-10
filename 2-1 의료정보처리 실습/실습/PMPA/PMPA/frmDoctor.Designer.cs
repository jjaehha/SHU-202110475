namespace PMPA
{
    partial class frmDoctor
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
            System.Windows.Forms.Label docNoLabel;
            System.Windows.Forms.Label docNameLabel;
            System.Windows.Forms.Label seqLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label pathLabel;
            this.dataSet1 = new PMPA.DataSet1();
            this.codeDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDeptTableAdapter = new PMPA.DataSet1TableAdapters.CodeDeptTableAdapter();
            this.tableAdapterManager = new PMPA.DataSet1TableAdapters.TableAdapterManager();
            this.codeDoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDoctorTableAdapter = new PMPA.DataSet1TableAdapters.CodeDoctorTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.codeDeptDataGridView = new System.Windows.Forms.DataGridView();
            this.codeDoctorDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNoTextBox = new System.Windows.Forms.TextBox();
            this.docNameTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.codeDoctorSignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDoctorSignTableAdapter = new PMPA.DataSet1TableAdapters.CodeDoctorSignTableAdapter();
            this.codeDoctorSignDataGridView = new System.Windows.Forms.DataGridView();
            this.seqTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            docNoLabel = new System.Windows.Forms.Label();
            docNameLabel = new System.Windows.Forms.Label();
            seqLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            pathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorSignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorSignDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMPA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codeDoctorBindingSource
            // 
            this.codeDoctorBindingSource.DataMember = "FK_CodeDoctor_CodeDept1";
            this.codeDoctorBindingSource.DataSource = this.codeDeptBindingSource;
            // 
            // codeDoctorTableAdapter
            // 
            this.codeDoctorTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.codeDoctorDataGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.codeDeptDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 705);
            this.panel1.TabIndex = 2;
            // 
            // codeDeptDataGridView
            // 
            this.codeDeptDataGridView.AutoGenerateColumns = false;
            this.codeDeptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeDeptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.codeDeptDataGridView.DataSource = this.codeDeptBindingSource;
            this.codeDeptDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeDeptDataGridView.Location = new System.Drawing.Point(0, 51);
            this.codeDeptDataGridView.Name = "codeDeptDataGridView";
            this.codeDeptDataGridView.RowTemplate.Height = 23;
            this.codeDeptDataGridView.Size = new System.Drawing.Size(395, 283);
            this.codeDeptDataGridView.TabIndex = 3;
            // 
            // codeDoctorDataGridView
            // 
            this.codeDoctorDataGridView.AutoGenerateColumns = false;
            this.codeDoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeDoctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docNoDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn,
            this.deptCodeDataGridViewTextBoxColumn});
            this.codeDoctorDataGridView.DataSource = this.codeDoctorBindingSource;
            this.codeDoctorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeDoctorDataGridView.Location = new System.Drawing.Point(0, 385);
            this.codeDoctorDataGridView.Name = "codeDoctorDataGridView";
            this.codeDoctorDataGridView.RowTemplate.Height = 23;
            this.codeDoctorDataGridView.Size = new System.Drawing.Size(395, 320);
            this.codeDoctorDataGridView.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 51);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "진료과 리스트";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 51);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "진료의 리스트";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeptCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "진료과 코드";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeptName";
            this.dataGridViewTextBoxColumn2.HeaderText = "진료과 명";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // docNoDataGridViewTextBoxColumn
            // 
            this.docNoDataGridViewTextBoxColumn.DataPropertyName = "DocNo";
            this.docNoDataGridViewTextBoxColumn.HeaderText = "진료의 코드";
            this.docNoDataGridViewTextBoxColumn.Name = "docNoDataGridViewTextBoxColumn";
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "DocName";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "의사이름";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            this.docNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // deptCodeDataGridViewTextBoxColumn
            // 
            this.deptCodeDataGridViewTextBoxColumn.DataPropertyName = "DeptCode";
            this.deptCodeDataGridViewTextBoxColumn.HeaderText = "DeptCode";
            this.deptCodeDataGridViewTextBoxColumn.Name = "deptCodeDataGridViewTextBoxColumn";
            this.deptCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // docNoLabel
            // 
            docNoLabel.AutoSize = true;
            docNoLabel.Location = new System.Drawing.Point(423, 79);
            docNoLabel.Name = "docNoLabel";
            docNoLabel.Size = new System.Drawing.Size(69, 12);
            docNoLabel.TabIndex = 2;
            docNoLabel.Text = "진료의 코드";
            // 
            // docNoTextBox
            // 
            this.docNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDoctorBindingSource, "DocNo", true));
            this.docNoTextBox.Location = new System.Drawing.Point(513, 76);
            this.docNoTextBox.Name = "docNoTextBox";
            this.docNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.docNoTextBox.TabIndex = 3;
            // 
            // docNameLabel
            // 
            docNameLabel.AutoSize = true;
            docNameLabel.Location = new System.Drawing.Point(648, 79);
            docNameLabel.Name = "docNameLabel";
            docNameLabel.Size = new System.Drawing.Size(53, 12);
            docNameLabel.TabIndex = 3;
            docNameLabel.Text = "진료의사";
            // 
            // docNameTextBox
            // 
            this.docNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDoctorBindingSource, "DocName", true));
            this.docNameTextBox.Location = new System.Drawing.Point(723, 76);
            this.docNameTextBox.Name = "docNameTextBox";
            this.docNameTextBox.Size = new System.Drawing.Size(177, 21);
            this.docNameTextBox.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(395, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 51);
            this.panel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(628, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(507, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(386, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "저장";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(265, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "추가";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // codeDoctorSignBindingSource
            // 
            this.codeDoctorSignBindingSource.DataMember = "FK_CodeDoctorSign_CodeDoctor";
            this.codeDoctorSignBindingSource.DataSource = this.codeDoctorBindingSource;
            // 
            // codeDoctorSignTableAdapter
            // 
            this.codeDoctorSignTableAdapter.ClearBeforeFill = true;
            // 
            // codeDoctorSignDataGridView
            // 
            this.codeDoctorSignDataGridView.AutoGenerateColumns = false;
            this.codeDoctorSignDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeDoctorSignDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.codeDoctorSignDataGridView.DataSource = this.codeDoctorSignBindingSource;
            this.codeDoctorSignDataGridView.Location = new System.Drawing.Point(401, 177);
            this.codeDoctorSignDataGridView.Name = "codeDoctorSignDataGridView";
            this.codeDoctorSignDataGridView.RowTemplate.Height = 23;
            this.codeDoctorSignDataGridView.Size = new System.Drawing.Size(731, 109);
            this.codeDoctorSignDataGridView.TabIndex = 7;
            this.codeDoctorSignDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.codeDoctorSignDataGridView_CellClick);
            this.codeDoctorSignDataGridView.Click += new System.EventHandler(this.codeDoctorSignDataGridView_Click);
            this.codeDoctorSignDataGridView.DoubleClick += new System.EventHandler(this.codeDoctorSignDataGridView_DoubleClick);
            // 
            // seqLabel
            // 
            seqLabel.AutoSize = true;
            seqLabel.Location = new System.Drawing.Point(440, 295);
            seqLabel.Name = "seqLabel";
            seqLabel.Size = new System.Drawing.Size(29, 12);
            seqLabel.TabIndex = 9;
            seqLabel.Text = "순번";
            // 
            // seqTextBox
            // 
            this.seqTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDoctorSignBindingSource, "Seq", true));
            this.seqTextBox.Location = new System.Drawing.Point(484, 292);
            this.seqTextBox.Name = "seqTextBox";
            this.seqTextBox.ReadOnly = true;
            this.seqTextBox.Size = new System.Drawing.Size(52, 21);
            this.seqTextBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(440, 322);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(29, 12);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "내용";
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new System.Drawing.Point(409, 348);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new System.Drawing.Size(69, 12);
            pathLabel.TabIndex = 13;
            pathLabel.Text = "이미지 경로";
            // 
            // pathTextBox
            // 
            this.pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDoctorSignBindingSource, "Path", true));
            this.pathTextBox.Location = new System.Drawing.Point(484, 345);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(648, 21);
            this.pathTextBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(484, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(795, 423);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "사진 등록";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(795, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "사진 가져오기";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Location = new System.Drawing.Point(401, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(749, 51);
            this.panel5.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(265, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 51);
            this.button7.TabIndex = 3;
            this.button7.Text = "추가";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(386, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 51);
            this.button8.TabIndex = 2;
            this.button8.Text = "저장";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(507, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 51);
            this.button9.TabIndex = 1;
            this.button9.Text = "삭제";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Right;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(628, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 51);
            this.button10.TabIndex = 0;
            this.button10.Text = "종료";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "진료과 등록";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "이미지 등록";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeDoctorSignBindingSource, "Title", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "사진",
            "도장",
            "싸인"});
            this.comboBox1.Location = new System.Drawing.Point(484, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 20);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DocNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "DocNo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Seq";
            this.dataGridViewTextBoxColumn4.HeaderText = "번호";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "내용";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Path";
            this.dataGridViewTextBoxColumn6.HeaderText = "사진경로";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 705);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(seqLabel);
            this.Controls.Add(this.seqTextBox);
            this.Controls.Add(this.codeDoctorSignDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(docNameLabel);
            this.Controls.Add(this.docNameTextBox);
            this.Controls.Add(docNoLabel);
            this.Controls.Add(this.docNoTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "frmDoctor";
            this.Text = "frmDoctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeDeptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorSignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeDoctorSignDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource codeDeptBindingSource;
        private DataSet1TableAdapters.CodeDeptTableAdapter codeDeptTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource codeDoctorBindingSource;
        private DataSet1TableAdapters.CodeDoctorTableAdapter codeDoctorTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView codeDoctorDataGridView;
        private System.Windows.Forms.DataGridView codeDeptDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox docNoTextBox;
        private System.Windows.Forms.TextBox docNameTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource codeDoctorSignBindingSource;
        private DataSet1TableAdapters.CodeDoctorSignTableAdapter codeDoctorSignTableAdapter;
        private System.Windows.Forms.DataGridView codeDoctorSignDataGridView;
        private System.Windows.Forms.TextBox seqTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}