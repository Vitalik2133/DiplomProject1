
namespace DiplomProject
{
    partial class Регистрация
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
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label электронная_почтаLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label полLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Регистрация));
            System.Windows.Forms.Label телефонLabel;
            this._Molotilov403_ISiP_DiplomBaseDataSet = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSet();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.ПользовательTableAdapter();
            this.tableAdapterManager = new DiplomProject._Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager();
            this.пользовательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.пользовательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.электронная_почтаTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.полRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            электронная_почтаLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Molotilov403_ISiP_DiplomBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).BeginInit();
            this.пользовательBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(13, 94);
            логинLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(54, 18);
            логинLabel.TabIndex = 1;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(15, 318);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(65, 18);
            парольLabel.TabIndex = 4;
            парольLabel.Text = "Пароль:";
            // 
            // электронная_почтаLabel
            // 
            электронная_почтаLabel.AutoSize = true;
            электронная_почтаLabel.Location = new System.Drawing.Point(13, 285);
            электронная_почтаLabel.Name = "электронная_почтаLabel";
            электронная_почтаLabel.Size = new System.Drawing.Size(148, 18);
            электронная_почтаLabel.TabIndex = 6;
            электронная_почтаLabel.Text = "Электронная почта:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(14, 124);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(42, 18);
            имяLabel.TabIndex = 8;
            имяLabel.Text = "Имя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(14, 158);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(77, 18);
            фамилияLabel.TabIndex = 10;
            фамилияLabel.Text = "Фамилия:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(14, 189);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(79, 18);
            отчествоLabel.TabIndex = 12;
            отчествоLabel.Text = "Отчество:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(15, 219);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(41, 18);
            полLabel.TabIndex = 14;
            полLabel.Text = "Пол:";
            // 
            // _Molotilov403_ISiP_DiplomBaseDataSet
            // 
            this._Molotilov403_ISiP_DiplomBaseDataSet.DataSetName = "_Molotilov403_ISiP_DiplomBaseDataSet";
            this._Molotilov403_ISiP_DiplomBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this._Molotilov403_ISiP_DiplomBaseDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПользовательTableAdapter = this.пользовательTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            this.tableAdapterManager.Фото_товаровTableAdapter = null;
            this.tableAdapterManager.Характеристики_товаровTableAdapter = null;
            // 
            // пользовательBindingNavigator
            // 
            this.пользовательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пользовательBindingNavigator.BindingSource = this.пользовательBindingSource;
            this.пользовательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пользовательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пользовательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.пользовательBindingNavigatorSaveItem});
            this.пользовательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пользовательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пользовательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пользовательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пользовательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пользовательBindingNavigator.Name = "пользовательBindingNavigator";
            this.пользовательBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.пользовательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пользовательBindingNavigator.Size = new System.Drawing.Size(382, 25);
            this.пользовательBindingNavigator.TabIndex = 0;
            this.пользовательBindingNavigator.Text = "bindingNavigator1";
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
            // пользовательBindingNavigatorSaveItem
            // 
            this.пользовательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пользовательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пользовательBindingNavigatorSaveItem.Image")));
            this.пользовательBindingNavigatorSaveItem.Name = "пользовательBindingNavigatorSaveItem";
            this.пользовательBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.пользовательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пользовательBindingNavigatorSaveItem.Click += new System.EventHandler(this.пользовательBindingNavigatorSaveItem_Click);
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(83, 90);
            this.логинTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(148, 24);
            this.логинTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регистрация";
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(86, 315);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(189, 24);
            this.парольTextBox.TabIndex = 5;
            // 
            // электронная_почтаTextBox
            // 
            this.электронная_почтаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Электронная_почта", true));
            this.электронная_почтаTextBox.Location = new System.Drawing.Point(167, 282);
            this.электронная_почтаTextBox.Name = "электронная_почтаTextBox";
            this.электронная_почтаTextBox.Size = new System.Drawing.Size(194, 24);
            this.электронная_почтаTextBox.TabIndex = 7;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(83, 121);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(148, 24);
            this.имяTextBox.TabIndex = 9;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(97, 155);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(160, 24);
            this.фамилияTextBox.TabIndex = 11;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(99, 186);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(158, 24);
            this.отчествоTextBox.TabIndex = 13;
            // 
            // полRadioButton
            // 
            this.полRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.пользовательBindingSource, "Пол", true));
            this.полRadioButton.Location = new System.Drawing.Point(97, 218);
            this.полRadioButton.Name = "полRadioButton";
            this.полRadioButton.Size = new System.Drawing.Size(41, 24);
            this.полRadioButton.TabIndex = 15;
            this.полRadioButton.TabStop = true;
            this.полRadioButton.Text = "м";
            this.полRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(144, 219);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 22);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ж";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(13, 251);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(76, 18);
            телефонLabel.TabIndex = 20;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пользовательBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(95, 248);
            this.телефонMaskedTextBox.Mask = "+7(000)000-00-00";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(158, 24);
            this.телефонMaskedTextBox.TabIndex = 21;
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(382, 470);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонMaskedTextBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полRadioButton);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(электронная_почтаLabel);
            this.Controls.Add(this.электронная_почтаTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(this.пользовательBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Регистрация";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Регистрация_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Molotilov403_ISiP_DiplomBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingNavigator)).EndInit();
            this.пользовательBindingNavigator.ResumeLayout(false);
            this.пользовательBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Molotilov403_ISiP_DiplomBaseDataSet _Molotilov403_ISiP_DiplomBaseDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private _Molotilov403_ISiP_DiplomBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пользовательBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton пользовательBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox электронная_почтаTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.RadioButton полRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
    }
}