
namespace KursProjDB
{
    partial class Klient_Nedviz
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
            System.Windows.Forms.Label klient_idLabel;
            System.Windows.Forms.Label nedvizhimost_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klient_Nedviz));
            this.agentNedvizh = new KursProjDB.AgentNedvizh();
            this.клиент_недвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиент_недвижимостьTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.Клиент_недвижимостьTableAdapter();
            this.tableAdapterManager = new KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager();
            this.клиентыTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.КлиентыTableAdapter();
            this.недвижимостьTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.НедвижимостьTableAdapter();
            this.клиент_недвижимостьBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.клиент_недвижимостьBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.клиент_недвижимостьDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.недвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            klient_idLabel = new System.Windows.Forms.Label();
            nedvizhimost_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиент_недвижимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиент_недвижимостьBindingNavigator)).BeginInit();
            this.клиент_недвижимостьBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиент_недвижимостьDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // klient_idLabel
            // 
            klient_idLabel.AutoSize = true;
            klient_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            klient_idLabel.Location = new System.Drawing.Point(264, 39);
            klient_idLabel.Name = "klient_idLabel";
            klient_idLabel.Size = new System.Drawing.Size(58, 16);
            klient_idLabel.TabIndex = 2;
            klient_idLabel.Text = "Клиент:";
            // 
            // nedvizhimost_idLabel
            // 
            nedvizhimost_idLabel.AutoSize = true;
            nedvizhimost_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nedvizhimost_idLabel.Location = new System.Drawing.Point(513, 39);
            nedvizhimost_idLabel.Name = "nedvizhimost_idLabel";
            nedvizhimost_idLabel.Size = new System.Drawing.Size(108, 16);
            nedvizhimost_idLabel.TabIndex = 4;
            nedvizhimost_idLabel.Text = "Недвижимость:";
            // 
            // agentNedvizh
            // 
            this.agentNedvizh.DataSetName = "AgentNedvizh";
            this.agentNedvizh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиент_недвижимостьBindingSource
            // 
            this.клиент_недвижимостьBindingSource.DataMember = "Клиент_недвижимость";
            this.клиент_недвижимостьBindingSource.DataSource = this.agentNedvizh;
            // 
            // клиент_недвижимостьTableAdapter
            // 
            this.клиент_недвижимостьTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.История_операцийTableAdapter = null;
            this.tableAdapterManager.Клиент_недвижимостьTableAdapter = this.клиент_недвижимостьTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.НедвижимостьTableAdapter = this.недвижимостьTableAdapter;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // недвижимостьTableAdapter
            // 
            this.недвижимостьTableAdapter.ClearBeforeFill = true;
            // 
            // клиент_недвижимостьBindingNavigator
            // 
            this.клиент_недвижимостьBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиент_недвижимостьBindingNavigator.BindingSource = this.клиент_недвижимостьBindingSource;
            this.клиент_недвижимостьBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиент_недвижимостьBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиент_недвижимостьBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.клиент_недвижимостьBindingNavigatorSaveItem});
            this.клиент_недвижимостьBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиент_недвижимостьBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клиент_недвижимостьBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клиент_недвижимостьBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиент_недвижимостьBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиент_недвижимостьBindingNavigator.Name = "клиент_недвижимостьBindingNavigator";
            this.клиент_недвижимостьBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиент_недвижимостьBindingNavigator.Size = new System.Drawing.Size(753, 25);
            this.клиент_недвижимостьBindingNavigator.TabIndex = 0;
            this.клиент_недвижимостьBindingNavigator.Text = "bindingNavigator1";
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
            // клиент_недвижимостьBindingNavigatorSaveItem
            // 
            this.клиент_недвижимостьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиент_недвижимостьBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиент_недвижимостьBindingNavigatorSaveItem.Image")));
            this.клиент_недвижимостьBindingNavigatorSaveItem.Name = "клиент_недвижимостьBindingNavigatorSaveItem";
            this.клиент_недвижимостьBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клиент_недвижимостьBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиент_недвижимостьBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиент_недвижимостьBindingNavigatorSaveItem_Click);
            // 
            // клиент_недвижимостьDataGridView
            // 
            this.клиент_недвижимостьDataGridView.AutoGenerateColumns = false;
            this.клиент_недвижимостьDataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.клиент_недвижимостьDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиент_недвижимостьDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.клиент_недвижимостьDataGridView.DataSource = this.клиент_недвижимостьBindingSource;
            this.клиент_недвижимостьDataGridView.Location = new System.Drawing.Point(12, 39);
            this.клиент_недвижимостьDataGridView.Name = "клиент_недвижимостьDataGridView";
            this.клиент_недвижимостьDataGridView.Size = new System.Drawing.Size(246, 300);
            this.клиент_недвижимостьDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "klient_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "klient_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nedvizhimost_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "nedvizhimost_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.клиент_недвижимостьBindingSource, "klient_id", true));
            this.comboBox1.DataSource = this.клиентыBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "klient_id";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.agentNedvizh;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.клиент_недвижимостьBindingSource, "nedvizhimost_id", true));
            this.comboBox2.DataSource = this.недвижимостьBindingSource;
            this.comboBox2.DisplayMember = "Наименование_недвижимости";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(516, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "nedvizhimost_id";
            // 
            // недвижимостьBindingSource
            // 
            this.недвижимостьBindingSource.DataMember = "Недвижимость";
            this.недвижимостьBindingSource.DataSource = this.agentNedvizh;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(650, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Klient_Nedviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(753, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(klient_idLabel);
            this.Controls.Add(nedvizhimost_idLabel);
            this.Controls.Add(this.клиент_недвижимостьDataGridView);
            this.Controls.Add(this.клиент_недвижимостьBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Klient_Nedviz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент-недвижимость";
            this.Load += new System.EventHandler(this.Klient_Nedviz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиент_недвижимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиент_недвижимостьBindingNavigator)).EndInit();
            this.клиент_недвижимостьBindingNavigator.ResumeLayout(false);
            this.клиент_недвижимостьBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиент_недвижимостьDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgentNedvizh agentNedvizh;
        private System.Windows.Forms.BindingSource клиент_недвижимостьBindingSource;
        private AgentNedvizhTableAdapters.Клиент_недвижимостьTableAdapter клиент_недвижимостьTableAdapter;
        private AgentNedvizhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиент_недвижимостьBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton клиент_недвижимостьBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView клиент_недвижимостьDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private AgentNedvizhTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private AgentNedvizhTableAdapters.НедвижимостьTableAdapter недвижимостьTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource недвижимостьBindingSource;
        private System.Windows.Forms.Button button1;
    }
}