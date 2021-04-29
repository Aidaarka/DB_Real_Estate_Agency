
namespace KursProjDB
{
    partial class Sotrudniki
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
            System.Windows.Forms.Label sotrudnik_idLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label пасспортные_данныеLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label номер_телефона_сотрудникаLabel;
            System.Windows.Forms.Label klient_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sotrudniki));
            this.agentNedvizh = new KursProjDB.AgentNedvizh();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager();
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
            this.сотрудникиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrudnik_idTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.пасспортные_данныеTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефона_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.КлиентыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            sotrudnik_idLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            пасспортные_данныеLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            номер_телефона_сотрудникаLabel = new System.Windows.Forms.Label();
            klient_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
            this.сотрудникиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sotrudnik_idLabel
            // 
            sotrudnik_idLabel.AutoSize = true;
            sotrudnik_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sotrudnik_idLabel.Location = new System.Drawing.Point(12, 270);
            sotrudnik_idLabel.Name = "sotrudnik_idLabel";
            sotrudnik_idLabel.Size = new System.Drawing.Size(79, 16);
            sotrudnik_idLabel.TabIndex = 2;
            sotrudnik_idLabel.Text = "sotrudnik id:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(12, 296);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(42, 16);
            фИОLabel.TabIndex = 4;
            фИОLabel.Text = "ФИО:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_рожденияLabel.Location = new System.Drawing.Point(12, 323);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(110, 16);
            дата_рожденияLabel.TabIndex = 6;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // пасспортные_данныеLabel
            // 
            пасспортные_данныеLabel.AutoSize = true;
            пасспортные_данныеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            пасспортные_данныеLabel.Location = new System.Drawing.Point(12, 348);
            пасспортные_данныеLabel.Name = "пасспортные_данныеLabel";
            пасспортные_данныеLabel.Size = new System.Drawing.Size(151, 16);
            пасспортные_данныеLabel.TabIndex = 8;
            пасспортные_данныеLabel.Text = "Пасспортные данные:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            должностьLabel.Location = new System.Drawing.Point(14, 376);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(82, 16);
            должностьLabel.TabIndex = 10;
            должностьLabel.Text = "Должность:";
            // 
            // номер_телефона_сотрудникаLabel
            // 
            номер_телефона_сотрудникаLabel.AutoSize = true;
            номер_телефона_сотрудникаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_телефона_сотрудникаLabel.Location = new System.Drawing.Point(14, 402);
            номер_телефона_сотрудникаLabel.Name = "номер_телефона_сотрудникаLabel";
            номер_телефона_сотрудникаLabel.Size = new System.Drawing.Size(203, 16);
            номер_телефона_сотрудникаLabel.TabIndex = 12;
            номер_телефона_сотрудникаLabel.Text = "Номер телефона сотрудника:";
            // 
            // klient_idLabel
            // 
            klient_idLabel.AutoSize = true;
            klient_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            klient_idLabel.Location = new System.Drawing.Point(14, 428);
            klient_idLabel.Name = "klient_idLabel";
            klient_idLabel.Size = new System.Drawing.Size(58, 16);
            klient_idLabel.TabIndex = 14;
            klient_idLabel.Text = "Клиент:";
            // 
            // agentNedvizh
            // 
            this.agentNedvizh.DataSetName = "AgentNedvizh";
            this.agentNedvizh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.agentNedvizh;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.История_операцийTableAdapter = null;
            this.tableAdapterManager.Клиент_недвижимостьTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НедвижимостьTableAdapter = null;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
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
            this.сотрудникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(769, 25);
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
            // сотрудникиDataGridView
            // 
            this.сотрудникиDataGridView.AutoGenerateColumns = false;
            this.сотрудникиDataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.сотрудникиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сотрудникиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.сотрудникиDataGridView.DataSource = this.сотрудникиBindingSource;
            this.сотрудникиDataGridView.Location = new System.Drawing.Point(12, 28);
            this.сотрудникиDataGridView.Name = "сотрудникиDataGridView";
            this.сотрудникиDataGridView.Size = new System.Drawing.Size(745, 220);
            this.сотрудникиDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sotrudnik_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "sotrudnik_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_рождения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата_рождения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Пасспортные_данные";
            this.dataGridViewTextBoxColumn4.HeaderText = "Пасспортные_данные";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Номер_телефона_сотрудника";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер_телефона_сотрудника";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "klient_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "klient_id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // sotrudnik_idTextBox
            // 
            this.sotrudnik_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "sotrudnik_id", true));
            this.sotrudnik_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sotrudnik_idTextBox.Location = new System.Drawing.Point(218, 267);
            this.sotrudnik_idTextBox.Name = "sotrudnik_idTextBox";
            this.sotrudnik_idTextBox.Size = new System.Drawing.Size(236, 22);
            this.sotrudnik_idTextBox.TabIndex = 3;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(218, 293);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(236, 22);
            this.фИОTextBox.TabIndex = 5;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникиBindingSource, "Дата_рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(218, 318);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            // 
            // пасспортные_данныеTextBox
            // 
            this.пасспортные_данныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пасспортные_данные", true));
            this.пасспортные_данныеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пасспортные_данныеTextBox.Location = new System.Drawing.Point(218, 345);
            this.пасспортные_данныеTextBox.Name = "пасспортные_данныеTextBox";
            this.пасспортные_данныеTextBox.Size = new System.Drawing.Size(236, 22);
            this.пасспортные_данныеTextBox.TabIndex = 9;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Должность", true));
            this.должностьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.должностьTextBox.Location = new System.Drawing.Point(218, 373);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(236, 22);
            this.должностьTextBox.TabIndex = 11;
            // 
            // номер_телефона_сотрудникаTextBox
            // 
            this.номер_телефона_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Номер_телефона_сотрудника", true));
            this.номер_телефона_сотрудникаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_телефона_сотрудникаTextBox.Location = new System.Drawing.Point(218, 399);
            this.номер_телефона_сотрудникаTextBox.Name = "номер_телефона_сотрудникаTextBox";
            this.номер_телефона_сотрудникаTextBox.Size = new System.Drawing.Size(236, 22);
            this.номер_телефона_сотрудникаTextBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сотрудникиBindingSource, "klient_id", true));
            this.comboBox1.DataSource = this.клиентыBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 425);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "klient_id";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.agentNedvizh;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(638, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(769, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(sotrudnik_idLabel);
            this.Controls.Add(this.sotrudnik_idTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(пасспортные_данныеLabel);
            this.Controls.Add(this.пасспортные_данныеTextBox);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(номер_телефона_сотрудникаLabel);
            this.Controls.Add(this.номер_телефона_сотрудникаTextBox);
            this.Controls.Add(klient_idLabel);
            this.Controls.Add(this.сотрудникиDataGridView);
            this.Controls.Add(this.сотрудникиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sotrudniki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Sotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
            this.сотрудникиBindingNavigator.ResumeLayout(false);
            this.сотрудникиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgentNedvizh agentNedvizh;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private AgentNedvizhTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private AgentNedvizhTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView сотрудникиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox sotrudnik_idTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox пасспортные_данныеTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox номер_телефона_сотрудникаTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private AgentNedvizhTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}