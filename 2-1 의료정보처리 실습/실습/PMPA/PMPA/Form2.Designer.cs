namespace PMPA
{
    partial class Form2
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
            System.Windows.Forms.Label insuCodeLabel;
            System.Windows.Forms.Label insuNameLabel;
            System.Windows.Forms.Label myRateLabel;
            System.Windows.Forms.Label insuCodeLabel1;
            System.Windows.Forms.Label subCodeLabel;
            System.Windows.Forms.Label myRateLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataSet1 = new PMPA.DataSet1();
            this.codeInsuranceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeInsuranceTableAdapter = new PMPA.DataSet1TableAdapters.CodeInsuranceTableAdapter();
            this.tableAdapterManager = new PMPA.DataSet1TableAdapters.TableAdapterManager();
            this.codeInsuranceSubTableAdapter = new PMPA.DataSet1TableAdapters.CodeInsuranceSubTableAdapter();
            this.codeInsuranceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.codeInsuranceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codeInsuranceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeInsuranceSubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeInsuranceSubDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.insuCodeTextBox = new System.Windows.Forms.TextBox();
            this.insuNameTextBox = new System.Windows.Forms.TextBox();
            this.myRateSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.insuCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.subCodeTextBox = new System.Windows.Forms.TextBox();
            this.myRateSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            insuCodeLabel = new System.Windows.Forms.Label();
            insuNameLabel = new System.Windows.Forms.Label();
            myRateLabel = new System.Windows.Forms.Label();
            insuCodeLabel1 = new System.Windows.Forms.Label();
            subCodeLabel = new System.Windows.Forms.Label();
            myRateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceBindingNavigator)).BeginInit();
            this.codeInsuranceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRateSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRateSpinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // insuCodeLabel
            // 
            insuCodeLabel.AutoSize = true;
            insuCodeLabel.Location = new System.Drawing.Point(462, 165);
            insuCodeLabel.Name = "insuCodeLabel";
            insuCodeLabel.Size = new System.Drawing.Size(79, 15);
            insuCodeLabel.TabIndex = 9;
            insuCodeLabel.Text = "Insu Code:";
            // 
            // insuNameLabel
            // 
            insuNameLabel.AutoSize = true;
            insuNameLabel.Location = new System.Drawing.Point(546, 208);
            insuNameLabel.Name = "insuNameLabel";
            insuNameLabel.Size = new System.Drawing.Size(80, 15);
            insuNameLabel.TabIndex = 11;
            insuNameLabel.Text = "Insu Name:";
            // 
            // myRateLabel
            // 
            myRateLabel.AutoSize = true;
            myRateLabel.Location = new System.Drawing.Point(493, 244);
            myRateLabel.Name = "myRateLabel";
            myRateLabel.Size = new System.Drawing.Size(67, 15);
            myRateLabel.TabIndex = 13;
            myRateLabel.Text = "My Rate:";
            // 
            // insuCodeLabel1
            // 
            insuCodeLabel1.AutoSize = true;
            insuCodeLabel1.Location = new System.Drawing.Point(464, 458);
            insuCodeLabel1.Name = "insuCodeLabel1";
            insuCodeLabel1.Size = new System.Drawing.Size(79, 15);
            insuCodeLabel1.TabIndex = 15;
            insuCodeLabel1.Text = "Insu Code:";
            // 
            // subCodeLabel
            // 
            subCodeLabel.AutoSize = true;
            subCodeLabel.Location = new System.Drawing.Point(467, 492);
            subCodeLabel.Name = "subCodeLabel";
            subCodeLabel.Size = new System.Drawing.Size(78, 15);
            subCodeLabel.TabIndex = 17;
            subCodeLabel.Text = "Sub Code:";
            // 
            // myRateLabel1
            // 
            myRateLabel1.AutoSize = true;
            myRateLabel1.Location = new System.Drawing.Point(477, 536);
            myRateLabel1.Name = "myRateLabel1";
            myRateLabel1.Size = new System.Drawing.Size(67, 15);
            myRateLabel1.TabIndex = 19;
            myRateLabel1.Text = "My Rate:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeInsuranceBindingSource
            // 
            this.codeInsuranceBindingSource.DataMember = "CodeInsurance";
            this.codeInsuranceBindingSource.DataSource = this.dataSet1;
            // 
            // codeInsuranceTableAdapter
            // 
            this.codeInsuranceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CodeDeptTableAdapter = null;
            this.tableAdapterManager.CodeDoctorSignTableAdapter = null;
            this.tableAdapterManager.CodeDoctorTableAdapter = null;
            this.tableAdapterManager.CodeInsuranceSubTableAdapter = this.codeInsuranceSubTableAdapter;
            this.tableAdapterManager.CodeInsuranceTableAdapter = this.codeInsuranceTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PatientAcceptanceTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PMPA.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // codeInsuranceSubTableAdapter
            // 
            this.codeInsuranceSubTableAdapter.ClearBeforeFill = true;
            // 
            // codeInsuranceBindingNavigator
            // 
            this.codeInsuranceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.codeInsuranceBindingNavigator.BindingSource = this.codeInsuranceBindingSource;
            this.codeInsuranceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.codeInsuranceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.codeInsuranceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.codeInsuranceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.codeInsuranceBindingNavigatorSaveItem});
            this.codeInsuranceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.codeInsuranceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.codeInsuranceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.codeInsuranceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.codeInsuranceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.codeInsuranceBindingNavigator.Name = "codeInsuranceBindingNavigator";
            this.codeInsuranceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.codeInsuranceBindingNavigator.Size = new System.Drawing.Size(914, 27);
            this.codeInsuranceBindingNavigator.TabIndex = 0;
            this.codeInsuranceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "새로 추가";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(33, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "전체 항목 수";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "삭제";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "처음으로 이동";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "이전으로 이동";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "위치";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(57, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "현재 위치";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "다음으로 이동";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "마지막으로 이동";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // codeInsuranceBindingNavigatorSaveItem
            // 
            this.codeInsuranceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.codeInsuranceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("codeInsuranceBindingNavigatorSaveItem.Image")));
            this.codeInsuranceBindingNavigatorSaveItem.Name = "codeInsuranceBindingNavigatorSaveItem";
            this.codeInsuranceBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.codeInsuranceBindingNavigatorSaveItem.Text = "데이터 저장";
            this.codeInsuranceBindingNavigatorSaveItem.Click += new System.EventHandler(this.codeInsuranceBindingNavigatorSaveItem_Click);
            // 
            // codeInsuranceDataGridView
            // 
            this.codeInsuranceDataGridView.AutoGenerateColumns = false;
            this.codeInsuranceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeInsuranceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.codeInsuranceDataGridView.DataSource = this.codeInsuranceBindingSource;
            this.codeInsuranceDataGridView.Location = new System.Drawing.Point(33, 77);
            this.codeInsuranceDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeInsuranceDataGridView.Name = "codeInsuranceDataGridView";
            this.codeInsuranceDataGridView.RowHeadersWidth = 51;
            this.codeInsuranceDataGridView.RowTemplate.Height = 23;
            this.codeInsuranceDataGridView.Size = new System.Drawing.Size(343, 275);
            this.codeInsuranceDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InsuCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "InsuCode";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InsuName";
            this.dataGridViewTextBoxColumn2.HeaderText = "InsuName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MyRate";
            this.dataGridViewTextBoxColumn3.HeaderText = "MyRate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // codeInsuranceSubBindingSource
            // 
            this.codeInsuranceSubBindingSource.DataMember = "FK_CodeInsuranceSub_CodeInsurance";
            this.codeInsuranceSubBindingSource.DataSource = this.codeInsuranceBindingSource;
            // 
            // codeInsuranceSubDataGridView
            // 
            this.codeInsuranceSubDataGridView.AutoGenerateColumns = false;
            this.codeInsuranceSubDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeInsuranceSubDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.codeInsuranceSubDataGridView.DataSource = this.codeInsuranceSubBindingSource;
            this.codeInsuranceSubDataGridView.Location = new System.Drawing.Point(46, 371);
            this.codeInsuranceSubDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeInsuranceSubDataGridView.Name = "codeInsuranceSubDataGridView";
            this.codeInsuranceSubDataGridView.RowHeadersWidth = 51;
            this.codeInsuranceSubDataGridView.Size = new System.Drawing.Size(343, 275);
            this.codeInsuranceSubDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InsuCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "InsuCode";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SubCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "SubCode";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MyRate";
            this.dataGridViewTextBoxColumn6.HeaderText = "MyRate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "신규등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(698, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(645, 391);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 391);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(445, 391);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // insuCodeTextBox
            // 
            this.insuCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceBindingSource, "InsuCode", true));
            this.insuCodeTextBox.Location = new System.Drawing.Point(545, 161);
            this.insuCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insuCodeTextBox.Name = "insuCodeTextBox";
            this.insuCodeTextBox.Size = new System.Drawing.Size(114, 25);
            this.insuCodeTextBox.TabIndex = 10;
            // 
            // insuNameTextBox
            // 
            this.insuNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceBindingSource, "InsuName", true));
            this.insuNameTextBox.Location = new System.Drawing.Point(634, 204);
            this.insuNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insuNameTextBox.Name = "insuNameTextBox";
            this.insuNameTextBox.Size = new System.Drawing.Size(114, 25);
            this.insuNameTextBox.TabIndex = 12;
            // 
            // myRateSpinEdit
            // 
            this.myRateSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.codeInsuranceBindingSource, "MyRate", true));
            this.myRateSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.myRateSpinEdit.Location = new System.Drawing.Point(563, 240);
            this.myRateSpinEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.myRateSpinEdit.Name = "myRateSpinEdit";
            // 
            // 
            // 
            this.myRateSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myRateSpinEdit.Size = new System.Drawing.Size(114, 24);
            this.myRateSpinEdit.TabIndex = 14;
            // 
            // insuCodeTextBox1
            // 
            this.insuCodeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceSubBindingSource, "InsuCode", true));
            this.insuCodeTextBox1.Location = new System.Drawing.Point(547, 454);
            this.insuCodeTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insuCodeTextBox1.Name = "insuCodeTextBox1";
            this.insuCodeTextBox1.Size = new System.Drawing.Size(114, 25);
            this.insuCodeTextBox1.TabIndex = 16;
            // 
            // subCodeTextBox
            // 
            this.subCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.codeInsuranceSubBindingSource, "SubCode", true));
            this.subCodeTextBox.Location = new System.Drawing.Point(549, 489);
            this.subCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subCodeTextBox.Name = "subCodeTextBox";
            this.subCodeTextBox.Size = new System.Drawing.Size(114, 25);
            this.subCodeTextBox.TabIndex = 18;
            // 
            // myRateSpinEdit1
            // 
            this.myRateSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.codeInsuranceSubBindingSource, "MyRate", true));
            this.myRateSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.myRateSpinEdit1.Location = new System.Drawing.Point(547, 532);
            this.myRateSpinEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.myRateSpinEdit1.Name = "myRateSpinEdit1";
            // 
            // 
            // 
            this.myRateSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myRateSpinEdit1.Size = new System.Drawing.Size(114, 24);
            this.myRateSpinEdit1.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 671);
            this.Controls.Add(myRateLabel1);
            this.Controls.Add(this.myRateSpinEdit1);
            this.Controls.Add(subCodeLabel);
            this.Controls.Add(this.subCodeTextBox);
            this.Controls.Add(insuCodeLabel1);
            this.Controls.Add(this.insuCodeTextBox1);
            this.Controls.Add(myRateLabel);
            this.Controls.Add(this.myRateSpinEdit);
            this.Controls.Add(insuNameLabel);
            this.Controls.Add(this.insuNameTextBox);
            this.Controls.Add(insuCodeLabel);
            this.Controls.Add(this.insuCodeTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeInsuranceSubDataGridView);
            this.Controls.Add(this.codeInsuranceDataGridView);
            this.Controls.Add(this.codeInsuranceBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceBindingNavigator)).EndInit();
            this.codeInsuranceBindingNavigator.ResumeLayout(false);
            this.codeInsuranceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeInsuranceSubDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRateSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRateSpinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource codeInsuranceBindingSource;
        private DataSet1TableAdapters.CodeInsuranceTableAdapter codeInsuranceTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator codeInsuranceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton codeInsuranceBindingNavigatorSaveItem;
        private DataSet1TableAdapters.CodeInsuranceSubTableAdapter codeInsuranceSubTableAdapter;
        private System.Windows.Forms.DataGridView codeInsuranceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource codeInsuranceSubBindingSource;
        private System.Windows.Forms.DataGridView codeInsuranceSubDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox insuCodeTextBox;
        private System.Windows.Forms.TextBox insuNameTextBox;
        private DevExpress.XtraEditors.SpinEdit myRateSpinEdit;
        private System.Windows.Forms.TextBox insuCodeTextBox1;
        private System.Windows.Forms.TextBox subCodeTextBox;
        private DevExpress.XtraEditors.SpinEdit myRateSpinEdit1;
    }
}