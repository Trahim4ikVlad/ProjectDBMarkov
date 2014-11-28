namespace StorePhone
{
    partial class EditSpecForm
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
            this.modelTableAdapter = new StorePhone.StorePhoneDataSetTableAdapters.ModelTableAdapter();
            this.specificationDataGridView = new System.Windows.Forms.DataGridView();
            this.modelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.storePhoneDataSet3 = new StorePhone.StorePhoneDataSet3();
            this.storePhoneDataSet = new StorePhone.StorePhoneDataSet();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.modelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.modelTableAdapter1 = new StorePhone.StorePhoneDataSet3TableAdapters.ModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.specificationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // specificationDataGridView
            // 
            this.specificationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.specificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specificationDataGridView.Location = new System.Drawing.Point(3, 4);
            this.specificationDataGridView.Name = "specificationDataGridView";
            this.specificationDataGridView.Size = new System.Drawing.Size(507, 211);
            this.specificationDataGridView.TabIndex = 9;
            // 
            // modelBindingSource3
            // 
            this.modelBindingSource3.DataMember = "Model";
            this.modelBindingSource3.DataSource = this.storePhoneDataSet3;
            // 
            // storePhoneDataSet3
            // 
            this.storePhoneDataSet3.DataSetName = "StorePhoneDataSet3";
            this.storePhoneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // modelBindingSource1
            // 
            this.modelBindingSource1.DataMember = "Model";
            this.modelBindingSource1.DataSource = this.storePhoneDataSet;
            // 
            // modelBindingSource2
            // 
            this.modelBindingSource2.DataMember = "Model";
            this.modelBindingSource2.DataSource = this.storePhoneDataSet;
            // 
            // modelBindingSource4
            // 
            this.modelBindingSource4.DataMember = "Model";
            this.modelBindingSource4.DataSource = this.storePhoneDataSet;
            // 
            // modelTableAdapter1
            // 
            this.modelTableAdapter1.ClearBeforeFill = true;
            // 
            // EditSpecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 215);
            this.Controls.Add(this.specificationDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditSpecForm";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditSpecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specificationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storePhoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView specificationDataGridView;
        private StorePhoneDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private StorePhoneDataSet storePhoneDataSet;
        private System.Windows.Forms.BindingSource modelBindingSource1;
        private System.Windows.Forms.BindingSource modelBindingSource2;
        private System.Windows.Forms.BindingSource modelBindingSource4;
        private StorePhoneDataSet3 storePhoneDataSet3;
        private System.Windows.Forms.BindingSource modelBindingSource3;
        private StorePhoneDataSet3TableAdapters.ModelTableAdapter modelTableAdapter1;
    }
}