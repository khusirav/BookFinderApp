
namespace BookFinderApp
{
    partial class AcessLevel1_Form
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
            this.bookFinderDataSet = new BookFinderApp.BookFinderDataSet();
            this.shopsManagersPhones_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsManagersPhones_viewTableAdapter = new BookFinderApp.BookFinderDataSetTableAdapters.ShopsManagersPhones_viewTableAdapter();
            this.tableAdapterManager = new BookFinderApp.BookFinderDataSetTableAdapters.TableAdapterManager();
            this.shopsProviders_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsProviders_viewTableAdapter = new BookFinderApp.BookFinderDataSetTableAdapters.ShopsProviders_viewTableAdapter();
            this.shopsProviders_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersPhones_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersPhones_viewTableAdapter = new BookFinderApp.BookFinderDataSetTableAdapters.ProvidersPhones_viewTableAdapter();
            this.providersPhones_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookFinderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsManagersPhones_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsProviders_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsProviders_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersPhones_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersPhones_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookFinderDataSet
            // 
            this.bookFinderDataSet.DataSetName = "BookFinderDataSet";
            this.bookFinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopsManagersPhones_viewBindingSource
            // 
            this.shopsManagersPhones_viewBindingSource.DataMember = "ShopsManagersPhones_view";
            this.shopsManagersPhones_viewBindingSource.DataSource = this.bookFinderDataSet;
            // 
            // shopsManagersPhones_viewTableAdapter
            // 
            this.shopsManagersPhones_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.LoginDataTableAdapter = null;
            this.tableAdapterManager.ManagersTableAdapter = null;
            this.tableAdapterManager.PhonesTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.ShopsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookFinderApp.BookFinderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shopsProviders_viewBindingSource
            // 
            this.shopsProviders_viewBindingSource.DataMember = "ShopsProviders_view";
            this.shopsProviders_viewBindingSource.DataSource = this.bookFinderDataSet;
            // 
            // shopsProviders_viewTableAdapter
            // 
            this.shopsProviders_viewTableAdapter.ClearBeforeFill = true;
            // 
            // shopsProviders_viewDataGridView
            // 
            this.shopsProviders_viewDataGridView.AllowUserToAddRows = false;
            this.shopsProviders_viewDataGridView.AllowUserToDeleteRows = false;
            this.shopsProviders_viewDataGridView.AllowUserToResizeColumns = false;
            this.shopsProviders_viewDataGridView.AllowUserToResizeRows = false;
            this.shopsProviders_viewDataGridView.AutoGenerateColumns = false;
            this.shopsProviders_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsProviders_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.shopsProviders_viewDataGridView.DataSource = this.shopsProviders_viewBindingSource;
            this.shopsProviders_viewDataGridView.Location = new System.Drawing.Point(12, 264);
            this.shopsProviders_viewDataGridView.Name = "shopsProviders_viewDataGridView";
            this.shopsProviders_viewDataGridView.RowHeadersWidth = 51;
            this.shopsProviders_viewDataGridView.RowTemplate.Height = 24;
            this.shopsProviders_viewDataGridView.Size = new System.Drawing.Size(1055, 220);
            this.shopsProviders_viewDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Идентификатор магазина";
            this.dataGridViewTextBoxColumn9.HeaderText = "Идентификатор магазина";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Название магазина";
            this.dataGridViewTextBoxColumn10.HeaderText = "Название магазина";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Сайт";
            this.dataGridViewTextBoxColumn11.HeaderText = "Сайт";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Тип магазина";
            this.dataGridViewTextBoxColumn12.HeaderText = "Тип магазина";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Номер закупщика";
            this.dataGridViewTextBoxColumn13.HeaderText = "Номер закупщика";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Фамилия закупщика";
            this.dataGridViewTextBoxColumn14.HeaderText = "Фамилия закупщика";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Имя закупщика";
            this.dataGridViewTextBoxColumn15.HeaderText = "Имя закупщика";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Отчество закупщика";
            this.dataGridViewTextBoxColumn16.HeaderText = "Отчество закупщика";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // providersPhones_viewBindingSource
            // 
            this.providersPhones_viewBindingSource.DataMember = "ProvidersPhones_view";
            this.providersPhones_viewBindingSource.DataSource = this.bookFinderDataSet;
            // 
            // providersPhones_viewTableAdapter
            // 
            this.providersPhones_viewTableAdapter.ClearBeforeFill = true;
            // 
            // providersPhones_viewDataGridView
            // 
            this.providersPhones_viewDataGridView.AllowUserToAddRows = false;
            this.providersPhones_viewDataGridView.AllowUserToDeleteRows = false;
            this.providersPhones_viewDataGridView.AllowUserToResizeColumns = false;
            this.providersPhones_viewDataGridView.AllowUserToResizeRows = false;
            this.providersPhones_viewDataGridView.AutoGenerateColumns = false;
            this.providersPhones_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providersPhones_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.providersPhones_viewDataGridView.DataSource = this.providersPhones_viewBindingSource;
            this.providersPhones_viewDataGridView.Location = new System.Drawing.Point(633, 38);
            this.providersPhones_viewDataGridView.Name = "providersPhones_viewDataGridView";
            this.providersPhones_viewDataGridView.RowHeadersWidth = 51;
            this.providersPhones_viewDataGridView.RowTemplate.Height = 24;
            this.providersPhones_viewDataGridView.Size = new System.Drawing.Size(434, 220);
            this.providersPhones_viewDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Имя компании";
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя компании";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Поставляемый товар";
            this.dataGridViewTextBoxColumn2.HeaderText = "Поставляемый товар";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер телефона поставщика";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер телефона поставщика";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вы вошли как менеджер.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поставщики:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Магазины и закупщики:";
            // 
            // AcessLevel1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.providersPhones_viewDataGridView);
            this.Controls.Add(this.shopsProviders_viewDataGridView);
            this.Name = "AcessLevel1_Form";
            this.Text = "BookFinder - Manager";
            this.Load += new System.EventHandler(this.AcessLevel1_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookFinderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsManagersPhones_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsProviders_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsProviders_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersPhones_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersPhones_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookFinderDataSet bookFinderDataSet;
        private System.Windows.Forms.BindingSource shopsManagersPhones_viewBindingSource;
        private BookFinderDataSetTableAdapters.ShopsManagersPhones_viewTableAdapter shopsManagersPhones_viewTableAdapter;
        private BookFinderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource shopsProviders_viewBindingSource;
        private BookFinderDataSetTableAdapters.ShopsProviders_viewTableAdapter shopsProviders_viewTableAdapter;
        private System.Windows.Forms.DataGridView shopsProviders_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource providersPhones_viewBindingSource;
        private BookFinderDataSetTableAdapters.ProvidersPhones_viewTableAdapter providersPhones_viewTableAdapter;
        private System.Windows.Forms.DataGridView providersPhones_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}