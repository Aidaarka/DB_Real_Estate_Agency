
namespace KursProjDB
{
    partial class Istor_oper
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nedvizhimost_idLabel;
            System.Windows.Forms.Label операцияLabel;
            System.Windows.Forms.Label дата_операцииLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Istor_oper));
            this.agentNedvizh = new KursProjDB.AgentNedvizh();
            this.история_операцийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_операцийTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.История_операцийTableAdapter();
            this.tableAdapterManager = new KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager();
            this.история_операцийBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.история_операцийBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.история_операцийDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nedvizhimost_idTextBox = new System.Windows.Forms.TextBox();
            this.операцияTextBox = new System.Windows.Forms.TextBox();
            this.дата_операцииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nedvizhimost_idLabel = new System.Windows.Forms.Label();
            операцияLabel = new System.Windows.Forms.Label();
            дата_операцииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_операцийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_операцийBindingNavigator)).BeginInit();
            this.история_операцийBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.история_операцийDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idLabel.Location = new System.Drawing.Point(13, 272);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 16);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // nedvizhimost_idLabel
            // 
            nedvizhimost_idLabel.AutoSize = true;
            nedvizhimost_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nedvizhimost_idLabel.Location = new System.Drawing.Point(13, 298);
            nedvizhimost_idLabel.Name = "nedvizhimost_idLabel";
            nedvizhimost_idLabel.Size = new System.Drawing.Size(103, 16);
            nedvizhimost_idLabel.TabIndex = 4;
            nedvizhimost_idLabel.Text = "nedvizhimost id:";
            // 
            // операцияLabel
            // 
            операцияLabel.AutoSize = true;
            операцияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            операцияLabel.Location = new System.Drawing.Point(13, 324);
            операцияLabel.Name = "операцияLabel";
            операцияLabel.Size = new System.Drawing.Size(76, 16);
            операцияLabel.TabIndex = 6;
            операцияLabel.Text = "Операция:";
            // 
            // дата_операцииLabel
            // 
            дата_операцииLabel.AutoSize = true;
            дата_операцииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_операцииLabel.Location = new System.Drawing.Point(13, 351);
            дата_операцииLabel.Name = "дата_операцииLabel";
            дата_операцииLabel.Size = new System.Drawing.Size(110, 16);
            дата_операцииLabel.TabIndex = 8;
            дата_операцииLabel.Text = "Дата операции:";
            // 
            // agentNedvizh
            // 
            this.agentNedvizh.DataSetName = "AgentNedvizh";
            this.agentNedvizh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // история_операцийBindingSource
            // 
            this.история_операцийBindingSource.DataMember = "История_операций";
            this.история_операцийBindingSource.DataSource = this.agentNedvizh;
            // 
            // история_операцийTableAdapter
            // 
            this.история_операцийTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KursProjDB.AgentNedvizhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.История_операцийTableAdapter = this.история_операцийTableAdapter;
            this.tableAdapterManager.Клиент_недвижимостьTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НедвижимостьTableAdapter = null;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // история_операцийBindingNavigator
            // 
            this.история_операцийBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.история_операцийBindingNavigator.BindingSource = this.история_операцийBindingSource;
            this.история_операцийBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.история_операцийBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.история_операцийBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.история_операцийBindingNavigatorSaveItem});
            this.история_операцийBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.история_операцийBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.история_операцийBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.история_операцийBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.история_операцийBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.история_операцийBindingNavigator.Name = "история_операцийBindingNavigator";
            this.история_операцийBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.история_операцийBindingNavigator.Size = new System.Drawing.Size(468, 25);
            this.история_операцийBindingNavigator.TabIndex = 0;
            this.история_операцийBindingNavigator.Text = "bindingNavigator1";
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
            // история_операцийBindingNavigatorSaveItem
            // 
            this.история_операцийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.история_операцийBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("история_операцийBindingNavigatorSaveItem.Image")));
            this.история_операцийBindingNavigatorSaveItem.Name = "история_операцийBindingNavigatorSaveItem";
            this.история_операцийBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.история_операцийBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.история_операцийBindingNavigatorSaveItem.Click += new System.EventHandler(this.история_операцийBindingNavigatorSaveItem_Click);
            // 
            // история_операцийDataGridView
            // 
            this.история_операцийDataGridView.AutoGenerateColumns = false;
            this.история_операцийDataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.история_операцийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.история_операцийDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.история_операцийDataGridView.DataSource = this.история_операцийBindingSource;
            this.история_операцийDataGridView.Location = new System.Drawing.Point(12, 28);
            this.история_операцийDataGridView.Name = "история_операцийDataGridView";
            this.история_операцийDataGridView.Size = new System.Drawing.Size(443, 220);
            this.история_операцийDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nedvizhimost_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "nedvizhimost_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Операция";
            this.dataGridViewTextBoxColumn3.HeaderText = "Операция";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_операции";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_операции";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_операцийBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idTextBox.Location = new System.Drawing.Point(137, 269);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(318, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // nedvizhimost_idTextBox
            // 
            this.nedvizhimost_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_операцийBindingSource, "nedvizhimost_id", true));
            this.nedvizhimost_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nedvizhimost_idTextBox.Location = new System.Drawing.Point(137, 295);
            this.nedvizhimost_idTextBox.Name = "nedvizhimost_idTextBox";
            this.nedvizhimost_idTextBox.Size = new System.Drawing.Size(318, 22);
            this.nedvizhimost_idTextBox.TabIndex = 5;
            // 
            // операцияTextBox
            // 
            this.операцияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.история_операцийBindingSource, "Операция", true));
            this.операцияTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.операцияTextBox.Location = new System.Drawing.Point(137, 321);
            this.операцияTextBox.Name = "операцияTextBox";
            this.операцияTextBox.Size = new System.Drawing.Size(318, 22);
            this.операцияTextBox.TabIndex = 7;
            // 
            // дата_операцииDateTimePicker
            // 
            this.дата_операцииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.история_операцийBindingSource, "Дата_операции", true));
            this.дата_операцииDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_операцииDateTimePicker.Location = new System.Drawing.Point(137, 347);
            this.дата_операцииDateTimePicker.Name = "дата_операцииDateTimePicker";
            this.дата_операцииDateTimePicker.Size = new System.Drawing.Size(318, 22);
            this.дата_операцииDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(365, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Istor_oper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(468, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nedvizhimost_idLabel);
            this.Controls.Add(this.nedvizhimost_idTextBox);
            this.Controls.Add(операцияLabel);
            this.Controls.Add(this.операцияTextBox);
            this.Controls.Add(дата_операцииLabel);
            this.Controls.Add(this.дата_операцииDateTimePicker);
            this.Controls.Add(this.история_операцийDataGridView);
            this.Controls.Add(this.история_операцийBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Istor_oper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История операций";
            this.Load += new System.EventHandler(this.Istor_oper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_операцийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_операцийBindingNavigator)).EndInit();
            this.история_операцийBindingNavigator.ResumeLayout(false);
            this.история_операцийBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.история_операцийDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgentNedvizh agentNedvizh;
        private System.Windows.Forms.BindingSource история_операцийBindingSource;
        private AgentNedvizhTableAdapters.История_операцийTableAdapter история_операцийTableAdapter;
        private AgentNedvizhTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator история_операцийBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton история_операцийBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView история_операцийDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nedvizhimost_idTextBox;
        private System.Windows.Forms.TextBox операцияTextBox;
        private System.Windows.Forms.DateTimePicker дата_операцииDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}