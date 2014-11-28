namespace StorePhone
{
    partial class EditPhonesForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label producerLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label operationSystemLabel;
            System.Windows.Forms.Label cameraLabel;
            System.Windows.Forms.Label countCoreLabel;
            System.Windows.Forms.Label memoryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPhonesForm));
            this.storePhoneDataSet = new StorePhone.StorePhoneDataSet();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter = new StorePhone.StorePhoneDataSetTableAdapters.ModelTableAdapter();
            this.tableAdapterManager = new StorePhone.StorePhoneDataSetTableAdapters.TableAdapterManager();
            this.producerTableAdapter = new StorePhone.StorePhoneDataSetTableAdapters.ProducerTableAdapter();
            this.modelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.modelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storePhoneDataSet2 = new StorePhone.StorePhoneDataSet2();
            this.producerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter1 = new StorePhone.StorePhoneDataSet2TableAdapters.ProducerTableAdapter();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.producerListBox = new System.Windows.Forms.ListBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.operationSystemTextBox = new System.Windows.Forms.TextBox();
            this.cameraTextBox = new System.Windows.Forms.TextBox();
            this.countCoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.memoryTextBox = new System.Windows.Forms.TextBox();
            this.fKModelProducerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            iDLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            producerLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            operationSystemLabel = new System.Windows.Forms.Label();
            cameraLabel = new System.Windows.Forms.Label();
            countCoreLabel = new System.Windows.Forms.Label();
            memoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingNavigator)).BeginInit();
            this.modelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCoreNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelProducerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(57, 35);
            iDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 16);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(57, 62);
            modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(61, 16);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Модель:";
            // 
            // producerLabel
            // 
            producerLabel.AutoSize = true;
            producerLabel.Location = new System.Drawing.Point(57, 102);
            producerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            producerLabel.Name = "producerLabel";
            producerLabel.Size = new System.Drawing.Size(115, 16);
            producerLabel.TabIndex = 6;
            producerLabel.Text = "Производитель:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(57, 145);
            priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 16);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Цена:";
            // 
            // operationSystemLabel
            // 
            operationSystemLabel.AutoSize = true;
            operationSystemLabel.Location = new System.Drawing.Point(57, 175);
            operationSystemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            operationSystemLabel.Name = "operationSystemLabel";
            operationSystemLabel.Size = new System.Drawing.Size(105, 16);
            operationSystemLabel.TabIndex = 10;
            operationSystemLabel.Text = "Опер. система:";
            // 
            // cameraLabel
            // 
            cameraLabel.AutoSize = true;
            cameraLabel.Location = new System.Drawing.Point(58, 205);
            cameraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cameraLabel.Name = "cameraLabel";
            cameraLabel.Size = new System.Drawing.Size(60, 16);
            cameraLabel.TabIndex = 12;
            cameraLabel.Text = "Камера:";
            // 
            // countCoreLabel
            // 
            countCoreLabel.AutoSize = true;
            countCoreLabel.Location = new System.Drawing.Point(58, 235);
            countCoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countCoreLabel.Name = "countCoreLabel";
            countCoreLabel.Size = new System.Drawing.Size(89, 16);
            countCoreLabel.TabIndex = 14;
            countCoreLabel.Text = "Кол-во ядер:";
            // 
            // memoryLabel
            // 
            memoryLabel.AutoSize = true;
            memoryLabel.Location = new System.Drawing.Point(58, 262);
            memoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new System.Drawing.Size(59, 16);
            memoryLabel.TabIndex = 16;
            memoryLabel.Text = "Память:";
            // 
            // storePhoneDataSet
            // 
            this.storePhoneDataSet.DataSetName = "StorePhoneDataSet";
            this.storePhoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.storePhoneDataSet;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProducerTableAdapter = this.producerTableAdapter;
            this.tableAdapterManager.SpecificationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StorePhone.StorePhoneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // modelBindingNavigator
            // 
            this.modelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.modelBindingNavigator.BindingSource = this.modelBindingSource;
            this.modelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.modelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.modelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.modelBindingNavigatorSaveItem});
            this.modelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.modelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.modelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.modelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.modelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.modelBindingNavigator.Name = "modelBindingNavigator";
            this.modelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.modelBindingNavigator.Size = new System.Drawing.Size(661, 25);
            this.modelBindingNavigator.TabIndex = 0;
            this.modelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // modelBindingNavigatorSaveItem
            // 
            this.modelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("modelBindingNavigatorSaveItem.Image")));
            this.modelBindingNavigatorSaveItem.Name = "modelBindingNavigatorSaveItem";
            this.modelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.modelBindingNavigatorSaveItem.Text = "Save Data";
            this.modelBindingNavigatorSaveItem.Click += new System.EventHandler(this.modelBindingNavigatorSaveItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.modelBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(663, 100);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Producer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Producer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OperationSystem";
            this.dataGridViewTextBoxColumn5.HeaderText = "OperationSystem";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Camera";
            this.dataGridViewTextBoxColumn6.HeaderText = "Camera";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CountCore";
            this.dataGridViewTextBoxColumn7.HeaderText = "CountCore";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Memory";
            this.dataGridViewTextBoxColumn8.HeaderText = "Memory";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.storePhoneDataSet;
            // 
            // storePhoneDataSet2
            // 
            this.storePhoneDataSet2.DataSetName = "StorePhoneDataSet2";
            this.storePhoneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producerBindingSource1
            // 
            this.producerBindingSource1.DataMember = "Producer";
            this.producerBindingSource1.DataSource = this.storePhoneDataSet2;
            // 
            // producerTableAdapter1
            // 
            this.producerTableAdapter1.ClearBeforeFill = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(189, 32);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(159, 22);
            this.iDTextBox.TabIndex = 3;
            this.iDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(189, 62);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(159, 22);
            this.modelTextBox.TabIndex = 5;
            this.modelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // producerListBox
            // 
            this.producerListBox.BackColor = System.Drawing.SystemColors.Info;
            this.producerListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modelBindingSource, "Producer", true));
            this.producerListBox.DataSource = this.producerBindingSource1;
            this.producerListBox.DisplayMember = "Name";
            this.producerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producerListBox.FormattingEnabled = true;
            this.producerListBox.IntegralHeight = false;
            this.producerListBox.ItemHeight = 16;
            this.producerListBox.Location = new System.Drawing.Point(189, 92);
            this.producerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.producerListBox.Name = "producerListBox";
            this.producerListBox.ScrollAlwaysVisible = true;
            this.producerListBox.Size = new System.Drawing.Size(159, 39);
            this.producerListBox.TabIndex = 7;
            this.producerListBox.ValueMember = "ID";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(189, 139);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(159, 22);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operationSystemTextBox
            // 
            this.operationSystemTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.operationSystemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "OperationSystem", true));
            this.operationSystemTextBox.Location = new System.Drawing.Point(189, 169);
            this.operationSystemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.operationSystemTextBox.Name = "operationSystemTextBox";
            this.operationSystemTextBox.Size = new System.Drawing.Size(159, 22);
            this.operationSystemTextBox.TabIndex = 11;
            this.operationSystemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cameraTextBox
            // 
            this.cameraTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.cameraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Camera", true));
            this.cameraTextBox.Location = new System.Drawing.Point(189, 199);
            this.cameraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cameraTextBox.Name = "cameraTextBox";
            this.cameraTextBox.Size = new System.Drawing.Size(159, 22);
            this.cameraTextBox.TabIndex = 13;
            this.cameraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countCoreNumericUpDown
            // 
            this.countCoreNumericUpDown.BackColor = System.Drawing.SystemColors.Info;
            this.countCoreNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.modelBindingSource, "CountCore", true));
            this.countCoreNumericUpDown.Location = new System.Drawing.Point(189, 229);
            this.countCoreNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.countCoreNumericUpDown.Name = "countCoreNumericUpDown";
            this.countCoreNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.countCoreNumericUpDown.TabIndex = 15;
            this.countCoreNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // memoryTextBox
            // 
            this.memoryTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.memoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Memory", true));
            this.memoryTextBox.Location = new System.Drawing.Point(190, 259);
            this.memoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.memoryTextBox.Name = "memoryTextBox";
            this.memoryTextBox.Size = new System.Drawing.Size(159, 22);
            this.memoryTextBox.TabIndex = 17;
            this.memoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fKModelProducerBindingSource
            // 
            this.fKModelProducerBindingSource.DataMember = "FK_Model_Producer";
            this.fKModelProducerBindingSource.DataSource = this.producerBindingSource;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StorePhone.Properties.Resources.images__7_;
            this.pictureBox1.Location = new System.Drawing.Point(402, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 154);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // EditPhonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(producerLabel);
            this.Controls.Add(this.producerListBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(operationSystemLabel);
            this.Controls.Add(this.operationSystemTextBox);
            this.Controls.Add(cameraLabel);
            this.Controls.Add(this.cameraTextBox);
            this.Controls.Add(countCoreLabel);
            this.Controls.Add(this.countCoreNumericUpDown);
            this.Controls.Add(memoryLabel);
            this.Controls.Add(this.memoryTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modelBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(677, 431);
            this.MinimumSize = new System.Drawing.Size(677, 431);
            this.Name = "EditPhonesForm";
            this.Text = "EditPhonesForm";
            this.Load += new System.EventHandler(this.EditPhonesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingNavigator)).EndInit();
            this.modelBindingNavigator.ResumeLayout(false);
            this.modelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countCoreNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKModelProducerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StorePhoneDataSet storePhoneDataSet;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private StorePhoneDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private StorePhoneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator modelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton modelBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private StorePhoneDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private StorePhoneDataSet2 storePhoneDataSet2;
        private System.Windows.Forms.BindingSource producerBindingSource1;
        private StorePhoneDataSet2TableAdapters.ProducerTableAdapter producerTableAdapter1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ListBox producerListBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox operationSystemTextBox;
        private System.Windows.Forms.TextBox cameraTextBox;
        private System.Windows.Forms.NumericUpDown countCoreNumericUpDown;
        private System.Windows.Forms.TextBox memoryTextBox;
        private System.Windows.Forms.BindingSource fKModelProducerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}