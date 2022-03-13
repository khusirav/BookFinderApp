
namespace BookFinderApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookFinderDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookFinderDataSet = new BookFinderApp.BookFinderDataSet();
            this.booksAuthors_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksAuthors_viewTableAdapter = new BookFinderApp.BookFinderDataSetTableAdapters.BooksAuthors_viewTableAdapter();
            this.tableAdapterManager = new BookFinderApp.BookFinderDataSetTableAdapters.TableAdapterManager();
            this.booksAuthors_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shops_sites_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shops_sites_viewTableAdapter = new BookFinderApp.BookFinderDataSetTableAdapters.Shops_sites_viewTableAdapter();
            this.shops_sites_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookFinderDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookFinderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAuthors_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAuthors_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_sites_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_sites_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookFinderDataSetBindingSource
            // 
            this.bookFinderDataSetBindingSource.DataSource = this.bookFinderDataSet;
            this.bookFinderDataSetBindingSource.Position = 0;
            // 
            // bookFinderDataSet
            // 
            this.bookFinderDataSet.DataSetName = "BookFinderDataSet";
            this.bookFinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksAuthors_viewBindingSource
            // 
            this.booksAuthors_viewBindingSource.DataMember = "BooksAuthors_view";
            this.booksAuthors_viewBindingSource.DataSource = this.bookFinderDataSet;
            // 
            // booksAuthors_viewTableAdapter
            // 
            this.booksAuthors_viewTableAdapter.ClearBeforeFill = true;
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
            // booksAuthors_viewDataGridView
            // 
            this.booksAuthors_viewDataGridView.AllowUserToAddRows = false;
            this.booksAuthors_viewDataGridView.AllowUserToDeleteRows = false;
            this.booksAuthors_viewDataGridView.AllowUserToResizeColumns = false;
            this.booksAuthors_viewDataGridView.AllowUserToResizeRows = false;
            this.booksAuthors_viewDataGridView.AutoGenerateColumns = false;
            this.booksAuthors_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksAuthors_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.booksAuthors_viewDataGridView.DataSource = this.booksAuthors_viewBindingSource;
            this.booksAuthors_viewDataGridView.Location = new System.Drawing.Point(12, 84);
            this.booksAuthors_viewDataGridView.Name = "booksAuthors_viewDataGridView";
            this.booksAuthors_viewDataGridView.RowHeadersWidth = 51;
            this.booksAuthors_viewDataGridView.RowTemplate.Height = 24;
            this.booksAuthors_viewDataGridView.Size = new System.Drawing.Size(479, 149);
            this.booksAuthors_viewDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название книги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название книги";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Автор";
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // shops_sites_viewBindingSource
            // 
            this.shops_sites_viewBindingSource.DataMember = "Shops_sites_view";
            this.shops_sites_viewBindingSource.DataSource = this.bookFinderDataSet;
            // 
            // shops_sites_viewTableAdapter
            // 
            this.shops_sites_viewTableAdapter.ClearBeforeFill = true;
            // 
            // shops_sites_viewDataGridView
            // 
            this.shops_sites_viewDataGridView.AutoGenerateColumns = false;
            this.shops_sites_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shops_sites_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.shops_sites_viewDataGridView.DataSource = this.shops_sites_viewBindingSource;
            this.shops_sites_viewDataGridView.Location = new System.Drawing.Point(12, 239);
            this.shops_sites_viewDataGridView.Name = "shops_sites_viewDataGridView";
            this.shops_sites_viewDataGridView.RowHeadersWidth = 51;
            this.shops_sites_viewDataGridView.RowTemplate.Height = 24;
            this.shops_sites_viewDataGridView.Size = new System.Drawing.Size(585, 220);
            this.shops_sites_viewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Все книги вы можете найти на сайтах наших партнёров:";
            this.dataGridViewTextBoxColumn3.HeaderText = "Все книги вы можете найти на сайтах наших партнёров:";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 425;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Finder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Если не знаешь, что прочитать.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(497, 110);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 22);
            this.LoginTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(497, 155);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 468);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shops_sites_viewDataGridView);
            this.Controls.Add(this.booksAuthors_viewDataGridView);
            this.Name = "Form1";
            this.Text = "BookFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookFinderDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookFinderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAuthors_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksAuthors_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_sites_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shops_sites_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bookFinderDataSetBindingSource;
        private BookFinderDataSet bookFinderDataSet;
        private System.Windows.Forms.BindingSource booksAuthors_viewBindingSource;
        private BookFinderDataSetTableAdapters.BooksAuthors_viewTableAdapter booksAuthors_viewTableAdapter;
        private BookFinderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView booksAuthors_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource shops_sites_viewBindingSource;
        private BookFinderDataSetTableAdapters.Shops_sites_viewTableAdapter shops_sites_viewTableAdapter;
        private System.Windows.Forms.DataGridView shops_sites_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}

