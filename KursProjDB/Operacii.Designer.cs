
namespace KursProjDB
{
    partial class Operacii
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
            System.Windows.Forms.Label operaci_idLabel;
            System.Windows.Forms.Label наименование_операцииLabel;
            System.Windows.Forms.Label klient_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacii));
            this.agentNedvizh = new KursProjDB.AgentNedvizh();
            this.операцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.операцииTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.ОперацииTableAdapter();
            this.tableAdapterManager = new KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager();
            this.клиентыTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.КлиентыTableAdapter();
            this.операцииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.операцииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.операцииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operaci_idTextBox = new System.Windows.Forms.TextBox();
            this.наименование_операцииTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            operaci_idLabel = new System.Windows.Forms.Label();
            наименование_операцииLabel = new System.Windows.Forms.Label();
            klient_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingNavigator)).BeginInit();
            this.операцииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.операцииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // operaci_idLabel
            // 
            operaci_idLabel.AutoSize = true;
            operaci_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            operaci_idLabel.Location = new System.Drawing.Point(370, 31);
            operaci_idLabel.Name = "operaci_idLabel";
            operaci_idLabel.Size = new System.Drawing.Size(71, 16);
            operaci_idLabel.TabIndex = 2;
            operaci_idLabel.Text = "operaci id:";
            // 
            // наименование_операцииLabel
            // 
            наименование_операцииLabel.AutoSize = true;
            наименование_операцииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            наименование_операцииLabel.Location = new System.Drawing.Point(370, 57);
            наименование_операцииLabel.Name = "наименование_операцииLabel";
            наименование_операцииLabel.Size = new System.Drawing.Size(177, 16);
            наименование_операцииLabel.TabIndex = 4;
            наименование_операцииLabel.Text = "Наименование операции:";
            // 
            // klient_idLabel
            // 
            klient_idLabel.AutoSize = true;
            klient_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            klient_idLabel.Location = new System.Drawing.Point(370, 83);
            klient_idLabel.Name = "klient_idLabel";
            klient_idLabel.Size = new System.Drawing.Size(67, 16);
            klient_idLabel.TabIndex = 6;
            klient_idLabel.Text = "Клиенты:";
            // 
            // agentNedvizh
            // 
            this.agentNedvizh.DataSetName = "AgentNedvizh";
            this.agentNedvizh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // операцииBindingSource
            // 
            this.операцииBindingSource.DataMember = "Операции";
            this.операцииBindingSource.DataSource = this.agentNedvizh;
            // 
            // операцииTableAdapter
            // 
            this.операцииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.История_операцийTableAdapter = null;
            this.tableAdapterManager.Клиент_недвижимостьTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.НедвижимостьTableAdapter = null;
            this.tableAdapterManager.ОперацииTableAdapter = this.операцииTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // операцииBindingNavigator
            // 
            this.операцииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.операцииBindingNavigator.BindingSource = this.операцииBindingSource;
            this.операцииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.операцииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.операцииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.операцииBindingNavigatorSaveItem});
            this.операцииBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.операцииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.операцииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.операцииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.операцииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.операцииBindingNavigator.Name = "операцииBindingNavigator";
            this.операцииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.операцииBindingNavigator.Size = new System.Drawing.Size(748, 25);
            this.операцииBindingNavigator.TabIndex = 0;
            this.операцииBindingNavigator.Text = "bindingNavigator1";
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
            // операцииBindingNavigatorSaveItem
            // 
            this.операцииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.операцииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("операцииBindingNavigatorSaveItem.Image")));
            this.операцииBindingNavigatorSaveItem.Name = "операцииBindingNavigatorSaveItem";
            this.операцииBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.операцииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.операцииBindingNavigatorSaveItem.Click += new System.EventHandler(this.операцииBindingNavigatorSaveItem_Click);
            // 
            // операцииDataGridView
            // 
            this.операцииDataGridView.AutoGenerateColumns = false;
            this.операцииDataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.операцииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.операцииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.операцииDataGridView.DataSource = this.операцииBindingSource;
            this.операцииDataGridView.Location = new System.Drawing.Point(12, 28);
            this.операцииDataGridView.Name = "операцииDataGridView";
            this.операцииDataGridView.Size = new System.Drawing.Size(343, 300);
            this.операцииDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "operaci_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "operaci_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_операции";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование_операции";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "klient_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "klient_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // operaci_idTextBox
            // 
            this.operaci_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "operaci_id", true));
            this.operaci_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operaci_idTextBox.Location = new System.Drawing.Point(555, 28);
            this.operaci_idTextBox.Name = "operaci_idTextBox";
            this.operaci_idTextBox.Size = new System.Drawing.Size(177, 22);
            this.operaci_idTextBox.TabIndex = 3;
            // 
            // наименование_операцииTextBox
            // 
            this.наименование_операцииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Наименование_операции", true));
            this.наименование_операцииTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименование_операцииTextBox.Location = new System.Drawing.Point(555, 54);
            this.наименование_операцииTextBox.Name = "наименование_операцииTextBox";
            this.наименование_операцииTextBox.Size = new System.Drawing.Size(177, 22);
            this.наименование_операцииTextBox.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.операцииBindingSource, "klient_id", true));
            this.comboBox1.DataSource = this.клиентыBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "klient_id";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.agentNedvizh;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(642, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operacii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(748, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(operaci_idLabel);
            this.Controls.Add(this.operaci_idTextBox);
            this.Controls.Add(наименование_операцииLabel);
            this.Controls.Add(this.наименование_операцииTextBox);
            this.Controls.Add(klient_idLabel);
            this.Controls.Add(this.операцииDataGridView);
            this.Controls.Add(this.операцииBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Operacii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операции";
            this.Load += new System.EventHandler(this.Operacii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingNavigator)).EndInit();
            this.операцииBindingNavigator.ResumeLayout(false);
            this.операцииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.операцииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgentNedvizh agentNedvizh;
        private System.Windows.Forms.BindingSource операцииBindingSource;
        private AgentNedvizhTableAdapters.ОперацииTableAdapter операцииTableAdapter;
        private AgentNedvizhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator операцииBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton операцииBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView операцииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox operaci_idTextBox;
        private System.Windows.Forms.TextBox наименование_операцииTextBox;
        private AgentNedvizhTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private System.Windows.Forms.Button button1;
    }
}