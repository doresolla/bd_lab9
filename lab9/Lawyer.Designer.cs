namespace lab9
{
    partial class Lawyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lawyer));
            this.delivery_OchirmaDataSet = new lab9.Delivery_OchirmaDataSet();
            this.юридическиеЛицаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.юридическиеЛицаTableAdapter = new lab9.Delivery_OchirmaDataSetTableAdapters.ЮридическиеЛицаTableAdapter();
            this.tableAdapterManager = new lab9.Delivery_OchirmaDataSetTableAdapters.TableAdapterManager();
            this.юридическиеЛицаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.юридическиеЛицаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.юридическиеЛицаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryOchirmaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиTableAdapter = new lab9.Delivery_OchirmaDataSetTableAdapters.ПоставщикиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_OchirmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридическиеЛицаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридическиеЛицаBindingNavigator)).BeginInit();
            this.юридическиеЛицаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.юридическиеЛицаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOchirmaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // delivery_OchirmaDataSet
            // 
            this.delivery_OchirmaDataSet.DataSetName = "Delivery_OchirmaDataSet";
            this.delivery_OchirmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // юридическиеЛицаBindingSource
            // 
            this.юридическиеЛицаBindingSource.DataMember = "ЮридическиеЛица";
            this.юридическиеЛицаBindingSource.DataSource = this.delivery_OchirmaDataSet;
            // 
            // юридическиеЛицаTableAdapter
            // 
            this.юридическиеЛицаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = lab9.Delivery_OchirmaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговорыTableAdapter = null;
            this.tableAdapterManager.ПоставленоTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ФизическиеЛицаTableAdapter = null;
            this.tableAdapterManager.ЮридическиеЛицаTableAdapter = this.юридическиеЛицаTableAdapter;
            // 
            // юридическиеЛицаBindingNavigator
            // 
            this.юридическиеЛицаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.юридическиеЛицаBindingNavigator.BindingSource = this.юридическиеЛицаBindingSource;
            this.юридическиеЛицаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.юридическиеЛицаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.юридическиеЛицаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.юридическиеЛицаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.юридическиеЛицаBindingNavigatorSaveItem});
            this.юридическиеЛицаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.юридическиеЛицаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.юридическиеЛицаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.юридическиеЛицаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.юридическиеЛицаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.юридическиеЛицаBindingNavigator.Name = "юридическиеЛицаBindingNavigator";
            this.юридическиеЛицаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.юридическиеЛицаBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.юридическиеЛицаBindingNavigator.TabIndex = 0;
            this.юридическиеЛицаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // юридическиеЛицаBindingNavigatorSaveItem
            // 
            this.юридическиеЛицаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.юридическиеЛицаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("юридическиеЛицаBindingNavigatorSaveItem.Image")));
            this.юридическиеЛицаBindingNavigatorSaveItem.Name = "юридическиеЛицаBindingNavigatorSaveItem";
            this.юридическиеЛицаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.юридическиеЛицаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.юридическиеЛицаBindingNavigatorSaveItem.Click += new System.EventHandler(this.юридическиеЛицаBindingNavigatorSaveItem_Click);
            // 
            // юридическиеЛицаDataGridView
            // 
            this.юридическиеЛицаDataGridView.AutoGenerateColumns = false;
            this.юридическиеЛицаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.юридическиеЛицаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.юридическиеЛицаDataGridView.DataSource = this.юридическиеЛицаBindingSource;
            this.юридическиеЛицаDataGridView.Location = new System.Drawing.Point(12, 89);
            this.юридическиеЛицаDataGridView.Name = "юридическиеЛицаDataGridView";
            this.юридическиеЛицаDataGridView.RowHeadersWidth = 51;
            this.юридическиеЛицаDataGridView.RowTemplate.Height = 24;
            this.юридическиеЛицаDataGridView.Size = new System.Drawing.Size(599, 228);
            this.юридическиеЛицаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодПоставщика";
            this.dataGridViewTextBoxColumn1.DataSource = this.поставщикиBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "КодПоставщика";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодПоставщика";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.deliveryOchirmaDataSetBindingSource;
            // 
            // deliveryOchirmaDataSetBindingSource
            // 
            this.deliveryOchirmaDataSetBindingSource.DataSource = this.delivery_OchirmaDataSet;
            this.deliveryOchirmaDataSetBindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "НалоговыйНомер";
            this.dataGridViewTextBoxColumn3.HeaderText = "НалоговыйНомер";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "НомерСвидетельстваНДС";
            this.dataGridViewTextBoxColumn4.HeaderText = "НомерСвидетельстваНДС";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // Lawyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.юридическиеЛицаDataGridView);
            this.Controls.Add(this.юридическиеЛицаBindingNavigator);
            this.Name = "Lawyer";
            this.Text = "Юридические лица";
            this.Load += new System.EventHandler(this.Lawyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delivery_OchirmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридическиеЛицаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.юридическиеЛицаBindingNavigator)).EndInit();
            this.юридическиеЛицаBindingNavigator.ResumeLayout(false);
            this.юридическиеЛицаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.юридическиеЛицаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryOchirmaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Delivery_OchirmaDataSet delivery_OchirmaDataSet;
        private System.Windows.Forms.BindingSource юридическиеЛицаBindingSource;
        private Delivery_OchirmaDataSetTableAdapters.ЮридическиеЛицаTableAdapter юридическиеЛицаTableAdapter;
        private Delivery_OchirmaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator юридическиеЛицаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton юридическиеЛицаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView юридическиеЛицаDataGridView;
        private System.Windows.Forms.BindingSource deliveryOchirmaDataSetBindingSource;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Delivery_OchirmaDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}