
namespace KursProjDB
{
    partial class Nedvizhimost
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
            System.Windows.Forms.Label nedvizhimost_idLabel;
            System.Windows.Forms.Label наименование_недвижимостиLabel;
            System.Windows.Forms.Label площадьLabel;
            System.Windows.Forms.Label районLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label этажLabel;
            System.Windows.Forms.Label балконLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nedvizhimost));
            this.agentNedvizh = new KursProjDB.AgentNedvizh();
            this.недвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.недвижимостьTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.НедвижимостьTableAdapter();
            this.tableAdapterManager = new KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager();
            this.недвижимостьBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.недвижимостьBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.недвижимостьDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nedvizhimost_idTextBox = new System.Windows.Forms.TextBox();
            this.наименование_недвижимостиTextBox = new System.Windows.Forms.TextBox();
            this.площадьTextBox = new System.Windows.Forms.TextBox();
            this.районTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.этажTextBox = new System.Windows.Forms.TextBox();
            this.балконTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nedvizhimost_idLabel = new System.Windows.Forms.Label();
            наименование_недвижимостиLabel = new System.Windows.Forms.Label();
            площадьLabel = new System.Windows.Forms.Label();
            районLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            этажLabel = new System.Windows.Forms.Label();
            балконLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingNavigator)).BeginInit();
            this.недвижимостьBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nedvizhimost_idLabel
            // 
            nedvizhimost_idLabel.AutoSize = true;
            nedvizhimost_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nedvizhimost_idLabel.Location = new System.Drawing.Point(12, 261);
            nedvizhimost_idLabel.Name = "nedvizhimost_idLabel";
            nedvizhimost_idLabel.Size = new System.Drawing.Size(103, 16);
            nedvizhimost_idLabel.TabIndex = 2;
            nedvizhimost_idLabel.Text = "nedvizhimost id:";
            // 
            // наименование_недвижимостиLabel
            // 
            наименование_недвижимостиLabel.AutoSize = true;
            наименование_недвижимостиLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_недвижимостиLabel.Location = new System.Drawing.Point(12, 287);
            наименование_недвижимостиLabel.Name = "наименование_недвижимостиLabel";
            наименование_недвижимостиLabel.Size = new System.Drawing.Size(209, 16);
            наименование_недвижимостиLabel.TabIndex = 4;
            наименование_недвижимостиLabel.Text = "Наименование недвижимости:";
            // 
            // площадьLabel
            // 
            площадьLabel.AutoSize = true;
            площадьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            площадьLabel.Location = new System.Drawing.Point(12, 313);
            площадьLabel.Name = "площадьLabel";
            площадьLabel.Size = new System.Drawing.Size(69, 16);
            площадьLabel.TabIndex = 6;
            площадьLabel.Text = "Площадь:";
            // 
            // районLabel
            // 
            районLabel.AutoSize = true;
            районLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            районLabel.Location = new System.Drawing.Point(12, 339);
            районLabel.Name = "районLabel";
            районLabel.Size = new System.Drawing.Size(52, 16);
            районLabel.TabIndex = 8;
            районLabel.Text = "Район:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.Location = new System.Drawing.Point(518, 261);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(51, 16);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // этажLabel
            // 
            этажLabel.AutoSize = true;
            этажLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            этажLabel.Location = new System.Drawing.Point(518, 287);
            этажLabel.Name = "этажLabel";
            этажLabel.Size = new System.Drawing.Size(45, 16);
            этажLabel.TabIndex = 12;
            этажLabel.Text = "Этаж:";
            // 
            // балконLabel
            // 
            балконLabel.AutoSize = true;
            балконLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            балконLabel.Location = new System.Drawing.Point(518, 313);
            балконLabel.Name = "балконLabel";
            балконLabel.Size = new System.Drawing.Size(59, 16);
            балконLabel.TabIndex = 14;
            балконLabel.Text = "Балкон:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            стоимостьLabel.Location = new System.Drawing.Point(518, 339);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(81, 16);
            стоимостьLabel.TabIndex = 16;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // agentNedvizh
            // 
            this.agentNedvizh.DataSetName = "AgentNedvizh";
            this.agentNedvizh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // недвижимостьBindingSource
            // 
            this.недвижимостьBindingSource.DataMember = "Недвижимость";
            this.недвижимостьBindingSource.DataSource = this.agentNedvizh;
            // 
            // недвижимостьTableAdapter
            // 
            this.недвижимостьTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.История_операцийTableAdapter = null;
            this.tableAdapterManager.Клиент_недвижимостьTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НедвижимостьTableAdapter = this.недвижимостьTableAdapter;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // недвижимостьBindingNavigator
            // 
            this.недвижимостьBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.недвижимостьBindingNavigator.BindingSource = this.недвижимостьBindingSource;
            this.недвижимостьBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.недвижимостьBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.недвижимостьBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.недвижимостьBindingNavigatorSaveItem});
            this.недвижимостьBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.недвижимостьBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.недвижимостьBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.недвижимостьBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.недвижимостьBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.недвижимостьBindingNavigator.Name = "недвижимостьBindingNavigator";
            this.недвижимостьBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.недвижимостьBindingNavigator.Size = new System.Drawing.Size(865, 25);
            this.недвижимостьBindingNavigator.TabIndex = 0;
            this.недвижимостьBindingNavigator.Text = "bindingNavigator1";
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
            // недвижимостьBindingNavigatorSaveItem
            // 
            this.недвижимостьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.недвижимостьBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("недвижимостьBindingNavigatorSaveItem.Image")));
            this.недвижимостьBindingNavigatorSaveItem.Name = "недвижимостьBindingNavigatorSaveItem";
            this.недвижимостьBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.недвижимостьBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.недвижимостьBindingNavigatorSaveItem.Click += new System.EventHandler(this.недвижимостьBindingNavigatorSaveItem_Click);
            // 
            // недвижимостьDataGridView
            // 
            this.недвижимостьDataGridView.AutoGenerateColumns = false;
            this.недвижимостьDataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.недвижимостьDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.недвижимостьDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.недвижимостьDataGridView.DataSource = this.недвижимостьBindingSource;
            this.недвижимостьDataGridView.Location = new System.Drawing.Point(12, 28);
            this.недвижимостьDataGridView.Name = "недвижимостьDataGridView";
            this.недвижимостьDataGridView.Size = new System.Drawing.Size(841, 220);
            this.недвижимостьDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nedvizhimost_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "nedvizhimost_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_недвижимости";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование_недвижимости";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Площадь";
            this.dataGridViewTextBoxColumn3.HeaderText = "Площадь";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Район";
            this.dataGridViewTextBoxColumn4.HeaderText = "Район";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Этаж";
            this.dataGridViewTextBoxColumn6.HeaderText = "Этаж";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Балкон";
            this.dataGridViewTextBoxColumn7.HeaderText = "Балкон";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn8.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // nedvizhimost_idTextBox
            // 
            this.nedvizhimost_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "nedvizhimost_id", true));
            this.nedvizhimost_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nedvizhimost_idTextBox.Location = new System.Drawing.Point(238, 258);
            this.nedvizhimost_idTextBox.Name = "nedvizhimost_idTextBox";
            this.nedvizhimost_idTextBox.Size = new System.Drawing.Size(225, 22);
            this.nedvizhimost_idTextBox.TabIndex = 3;
            // 
            // наименование_недвижимостиTextBox
            // 
            this.наименование_недвижимостиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Наименование_недвижимости", true));
            this.наименование_недвижимостиTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименование_недвижимостиTextBox.Location = new System.Drawing.Point(238, 284);
            this.наименование_недвижимостиTextBox.Name = "наименование_недвижимостиTextBox";
            this.наименование_недвижимостиTextBox.Size = new System.Drawing.Size(225, 22);
            this.наименование_недвижимостиTextBox.TabIndex = 5;
            // 
            // площадьTextBox
            // 
            this.площадьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Площадь", true));
            this.площадьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.площадьTextBox.Location = new System.Drawing.Point(238, 310);
            this.площадьTextBox.Name = "площадьTextBox";
            this.площадьTextBox.Size = new System.Drawing.Size(225, 22);
            this.площадьTextBox.TabIndex = 7;
            // 
            // районTextBox
            // 
            this.районTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Район", true));
            this.районTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.районTextBox.Location = new System.Drawing.Point(238, 336);
            this.районTextBox.Name = "районTextBox";
            this.районTextBox.Size = new System.Drawing.Size(225, 22);
            this.районTextBox.TabIndex = 9;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресTextBox.Location = new System.Drawing.Point(628, 258);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(225, 22);
            this.адресTextBox.TabIndex = 11;
            // 
            // этажTextBox
            // 
            this.этажTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Этаж", true));
            this.этажTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.этажTextBox.Location = new System.Drawing.Point(628, 284);
            this.этажTextBox.Name = "этажTextBox";
            this.этажTextBox.Size = new System.Drawing.Size(225, 22);
            this.этажTextBox.TabIndex = 13;
            // 
            // балконTextBox
            // 
            this.балконTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Балкон", true));
            this.балконTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.балконTextBox.Location = new System.Drawing.Point(628, 310);
            this.балконTextBox.Name = "балконTextBox";
            this.балконTextBox.Size = new System.Drawing.Size(225, 22);
            this.балконTextBox.TabIndex = 15;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.недвижимостьBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стоимостьTextBox.Location = new System.Drawing.Point(628, 336);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(225, 22);
            this.стоимостьTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(763, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nedvizhimost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(865, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(nedvizhimost_idLabel);
            this.Controls.Add(this.nedvizhimost_idTextBox);
            this.Controls.Add(наименование_недвижимостиLabel);
            this.Controls.Add(this.наименование_недвижимостиTextBox);
            this.Controls.Add(площадьLabel);
            this.Controls.Add(this.площадьTextBox);
            this.Controls.Add(районLabel);
            this.Controls.Add(this.районTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(этажLabel);
            this.Controls.Add(this.этажTextBox);
            this.Controls.Add(балконLabel);
            this.Controls.Add(this.балконTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.недвижимостьDataGridView);
            this.Controls.Add(this.недвижимостьBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nedvizhimost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Недвижимость";
            this.Load += new System.EventHandler(this.Nedvizhimost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingNavigator)).EndInit();
            this.недвижимостьBindingNavigator.ResumeLayout(false);
            this.недвижимостьBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgentNedvizh agentNedvizh;
        private System.Windows.Forms.BindingSource недвижимостьBindingSource;
        private AgentNedvizhTableAdapters.НедвижимостьTableAdapter недвижимостьTableAdapter;
        private AgentNedvizhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator недвижимостьBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton недвижимостьBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView недвижимостьDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox nedvizhimost_idTextBox;
        private System.Windows.Forms.TextBox наименование_недвижимостиTextBox;
        private System.Windows.Forms.TextBox площадьTextBox;
        private System.Windows.Forms.TextBox районTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox этажTextBox;
        private System.Windows.Forms.TextBox балконTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.Button button1;
    }
}