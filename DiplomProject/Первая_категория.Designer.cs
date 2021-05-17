
namespace DiplomProject
{
    partial class Первая_категория
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Первая_категория));
            this.label1 = new System.Windows.Forms.Label();
            this.FirstCategory = new System.Windows.Forms.Label();
            this._Molotilov403_ISiP_DiplomBaseDataSet = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.ТоварыTableAdapter();
            this.tableAdapterManager = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager();
            this.товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.товарыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.характеристикитоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.категориятоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.категория_товаровTableAdapter = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.Категория_товаровTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.характеристики_товаровTableAdapter = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.Характеристики_товаровTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Molotilov403_ISiP_DiplomBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).BeginInit();
            this.товарыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикитоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориятоваровBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // FirstCategory
            // 
            this.FirstCategory.AutoSize = true;
            this.FirstCategory.Location = new System.Drawing.Point(136, 35);
            this.FirstCategory.Name = "FirstCategory";
            this.FirstCategory.Size = new System.Drawing.Size(133, 18);
            this.FirstCategory.TabIndex = 1;
            this.FirstCategory.Text = "Первая категория";
            this.FirstCategory.Click += new System.EventHandler(this.FirstCategory_Click);
            // 
            // _Molotilov403_ISiP_DiplomBaseDataSet
            // 
            this._Molotilov403_ISiP_DiplomBaseDataSet.DataSetName = "_Molotilov403_ISiP_DiplomBaseDataSet";
            this._Molotilov403_ISiP_DiplomBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this._Molotilov403_ISiP_DiplomBaseDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аккаунт_сотрудникаTableAdapter = null;
            this.tableAdapterManager.Категория_товаровTableAdapter = null;
            this.tableAdapterManager.Лого_товаровTableAdapter = null;
            this.tableAdapterManager.Логотипы_пользователейTableAdapter = null;
            this.tableAdapterManager.Обратная_связьTableAdapter = null;
            this.tableAdapterManager.Подкатегории_товаровTableAdapter = null;
            this.tableAdapterManager.ПолTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = this.товарыTableAdapter;
            this.tableAdapterManager.Фото_товаровTableAdapter = null;
            this.tableAdapterManager.Характеристики_товаровTableAdapter = null;
            // 
            // товарыBindingNavigator
            // 
            this.товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарыBindingNavigator.BindingSource = this.товарыBindingSource;
            this.товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.товарыBindingNavigatorSaveItem});
            this.товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарыBindingNavigator.Name = "товарыBindingNavigator";
            this.товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарыBindingNavigator.Size = new System.Drawing.Size(880, 25);
            this.товарыBindingNavigator.TabIndex = 2;
            this.товарыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // товарыBindingNavigatorSaveItem
            // 
            this.товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарыBindingNavigatorSaveItem.Image")));
            this.товарыBindingNavigatorSaveItem.Name = "товарыBindingNavigatorSaveItem";
            this.товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарыBindingNavigatorSaveItem_Click);
            // 
            // товарыDataGridView
            // 
            this.товарыDataGridView.AutoGenerateColumns = false;
            this.товарыDataGridView.BackgroundColor = System.Drawing.Color.SlateGray;
            this.товарыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.товарыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.товарыDataGridView.DataSource = this.товарыBindingSource;
            this.товарыDataGridView.GridColor = System.Drawing.Color.MidnightBlue;
            this.товарыDataGridView.Location = new System.Drawing.Point(26, 183);
            this.товарыDataGridView.Name = "товарыDataGridView";
            this.товарыDataGridView.Size = new System.Drawing.Size(844, 236);
            this.товарыDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Индикатор";
            this.dataGridViewTextBoxColumn1.HeaderText = "Индикатор";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Характеристики";
            this.dataGridViewTextBoxColumn4.DataSource = this.характеристикитоваровBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn4.HeaderText = "Характеристики";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Индикатор_Характеристики";
            // 
            // характеристикитоваровBindingSource
            // 
            this.характеристикитоваровBindingSource.DataMember = "Характеристики_товаров";
            this.характеристикитоваровBindingSource.DataSource = this._Molotilov403_ISiP_DiplomBaseDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Отзыв";
            this.dataGridViewTextBoxColumn5.HeaderText = "Отзыв";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Оценка";
            this.dataGridViewTextBoxColumn6.HeaderText = "Оценка";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn7.DataSource = this.категориятоваровBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn7.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "Индикатор";
            // 
            // категориятоваровBindingSource
            // 
            this.категориятоваровBindingSource.DataMember = "Категория_товаров";
            this.категориятоваровBindingSource.DataSource = this._Molotilov403_ISiP_DiplomBaseDataSet;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Лого_товара";
            this.dataGridViewTextBoxColumn8.HeaderText = "Лого_товара";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Фото_товара";
            this.dataGridViewTextBoxColumn9.HeaderText = "Фото_товара";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "По оценке от меньшей к большей";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "По оценке от большей к меньшей";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "По наименованию от Я до А";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "По наименованию от А до Я";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // категория_товаровTableAdapter
            // 
            this.категория_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // характеристики_товаровTableAdapter
            // 
            this.характеристики_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Редактировать товары";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Первая_категория
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(880, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.товарыDataGridView);
            this.Controls.Add(this.товарыBindingNavigator);
            this.Controls.Add(this.FirstCategory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Первая_категория";
            this.Text = "Первая_категория";
            this.Load += new System.EventHandler(this.Первая_категория_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Molotilov403_ISiP_DiplomBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingNavigator)).EndInit();
            this.товарыBindingNavigator.ResumeLayout(false);
            this.товарыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.характеристикитоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категориятоваровBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstCategory;
        private _Molotilov403_ISiP_DiplomBaseDataSet _Molotilov403_ISiP_DiplomBaseDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton товарыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView товарыDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource категориятоваровBindingSource;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.Категория_товаровTableAdapter категория_товаровTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource характеристикитоваровBindingSource;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.Характеристики_товаровTableAdapter характеристики_товаровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}