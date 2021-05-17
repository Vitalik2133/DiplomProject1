
namespace DiplomProject
{
    partial class Сотрудники
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
            System.Windows.Forms.Label номер_сотрудникаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label аккаунт_сотрудникаLabel;
            System.Windows.Forms.Label фотоLabel;
            System.Windows.Forms.Label полLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сотрудники));
            this._Molotilov403_ISiP_DiplomBaseDataSet = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сотрудникиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.аккаунт_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фотоTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.полBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.полTableAdapter = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.ПолTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            номер_сотрудникаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            аккаунт_сотрудникаLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Molotilov403_ISiP_DiplomBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
            this.сотрудникиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_сотрудникаLabel
            // 
            номер_сотрудникаLabel.AutoSize = true;
            номер_сотрудникаLabel.Location = new System.Drawing.Point(13, 45);
            номер_сотрудникаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_сотрудникаLabel.Name = "номер_сотрудникаLabel";
            номер_сотрудникаLabel.Size = new System.Drawing.Size(143, 18);
            номер_сотрудникаLabel.TabIndex = 1;
            номер_сотрудникаLabel.Text = "Номер сотрудника:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(13, 81);
            фамилияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(77, 18);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(13, 119);
            имяLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(42, 18);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(13, 151);
            отчествоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(79, 18);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // аккаунт_сотрудникаLabel
            // 
            аккаунт_сотрудникаLabel.AutoSize = true;
            аккаунт_сотрудникаLabel.Location = new System.Drawing.Point(14, 225);
            аккаунт_сотрудникаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            аккаунт_сотрудникаLabel.Name = "аккаунт_сотрудникаLabel";
            аккаунт_сотрудникаLabel.Size = new System.Drawing.Size(151, 18);
            аккаунт_сотрудникаLabel.TabIndex = 9;
            аккаунт_сотрудникаLabel.Text = "Аккаунт сотрудника:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(14, 265);
            фотоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(50, 18);
            фотоLabel.TabIndex = 11;
            фотоLabel.Text = "Фото:";
            фотоLabel.Visible = false;
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(14, 189);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(41, 18);
            полLabel.TabIndex = 16;
            полLabel.Text = "Пол:";
            // 
            // _Molotilov403_ISiP_DiplomBaseDataSet
            // 
            this._Molotilov403_ISiP_DiplomBaseDataSet.DataSetName = "_Molotilov403_ISiP_DiplomBaseDataSet";
            this._Molotilov403_ISiP_DiplomBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this._Molotilov403_ISiP_DiplomBaseDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            this.tableAdapterManager.Фото_товаровTableAdapter = null;
            this.tableAdapterManager.Характеристики_товаровTableAdapter = null;
            // 
            // сотрудникиBindingNavigator
            // 
            this.сотрудникиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сотрудникиBindingNavigator.BindingSource = this.сотрудникиBindingSource;
            this.сотрудникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сотрудникиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сотрудникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сотрудникиBindingNavigatorSaveItem});
            this.сотрудникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сотрудникиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сотрудникиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сотрудникиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сотрудникиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сотрудникиBindingNavigator.Name = "сотрудникиBindingNavigator";
            this.сотрудникиBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.сотрудникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(622, 25);
            this.сотрудникиBindingNavigator.TabIndex = 0;
            this.сотрудникиBindingNavigator.Text = "bindingNavigator1";
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
            // сотрудникиBindingNavigatorSaveItem
            // 
            this.сотрудникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сотрудникиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиBindingNavigatorSaveItem.Image")));
            this.сотрудникиBindingNavigatorSaveItem.Name = "сотрудникиBindingNavigatorSaveItem";
            this.сотрудникиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.сотрудникиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сотрудникиBindingNavigatorSaveItem.Click += new System.EventHandler(this.сотрудникиBindingNavigatorSaveItem_Click);
            // 
            // номер_сотрудникаTextBox
            // 
            this.номер_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Номер_сотрудника", true));
            this.номер_сотрудникаTextBox.Location = new System.Drawing.Point(190, 41);
            this.номер_сотрудникаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_сотрудникаTextBox.Name = "номер_сотрудникаTextBox";
            this.номер_сотрудникаTextBox.Size = new System.Drawing.Size(148, 24);
            this.номер_сотрудникаTextBox.TabIndex = 2;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(190, 77);
            this.фамилияTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(148, 24);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(190, 109);
            this.имяTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(148, 24);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(190, 141);
            this.отчествоTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(148, 24);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // аккаунт_сотрудникаTextBox
            // 
            this.аккаунт_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Аккаунт_сотрудника", true));
            this.аккаунт_сотрудникаTextBox.Location = new System.Drawing.Point(191, 221);
            this.аккаунт_сотрудникаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.аккаунт_сотрудникаTextBox.Name = "аккаунт_сотрудникаTextBox";
            this.аккаунт_сотрудникаTextBox.Size = new System.Drawing.Size(148, 24);
            this.аккаунт_сотрудникаTextBox.TabIndex = 10;
            // 
            // фотоTextBox
            // 
            this.фотоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Фото", true));
            this.фотоTextBox.Location = new System.Drawing.Point(191, 260);
            this.фотоTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фотоTextBox.Name = "фотоTextBox";
            this.фотоTextBox.Size = new System.Drawing.Size(148, 24);
            this.фотоTextBox.TabIndex = 12;
            this.фотоTextBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Аккаунт сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(364, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 166);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пол", true));
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.полBindingSource, "Наименование", true));
            this.полComboBox.DataSource = this.полBindingSource;
            this.полComboBox.DisplayMember = "Индикатор";
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Location = new System.Drawing.Point(190, 186);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(121, 26);
            this.полComboBox.TabIndex = 17;
            this.полComboBox.ValueMember = "Наименование";
            // 
            // полBindingSource
            // 
            this.полBindingSource.DataMember = "Пол";
            this.полBindingSource.DataSource = this._Molotilov403_ISiP_DiplomBaseDataSet;
            // 
            // полTableAdapter
            // 
            this.полTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(622, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоTextBox);
            this.Controls.Add(аккаунт_сотрудникаLabel);
            this.Controls.Add(this.аккаунт_сотрудникаTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(номер_сотрудникаLabel);
            this.Controls.Add(this.номер_сотрудникаTextBox);
            this.Controls.Add(this.сотрудникиBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Сотрудники";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Сотрудники_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Molotilov403_ISiP_DiplomBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
            this.сотрудникиBindingNavigator.ResumeLayout(false);
            this.сотрудникиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Molotilov403_ISiP_DiplomBaseDataSet _Molotilov403_ISiP_DiplomBaseDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сотрудникиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сотрудникиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_сотрудникаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox аккаунт_сотрудникаTextBox;
        private System.Windows.Forms.TextBox фотоTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.BindingSource полBindingSource;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.ПолTableAdapter полTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}