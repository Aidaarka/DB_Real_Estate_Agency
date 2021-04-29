
namespace KursProjDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentNedvizh = new KursProjDB.AgentNedvizh();
            this.клиентыTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.КлиентыTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nedvizhimostidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиенедвижимостиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.районDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.балконDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.недвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.недвижимостьTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.НедвижимостьTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.sotrudnikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пасспортныеданныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонасотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.СотрудникиTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nedvizhimostidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.операцияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаоперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.историяоперацийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.история_операцийTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.История_операцийTableAdapter();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.operaciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеоперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.операцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.операцииTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.ОперацииTableAdapter();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.klientidDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nedvizhimostidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентнедвижимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиент_недвижимостьTableAdapter = new KursProjDB.AgentNedvizhTableAdapters.Клиент_недвижимостьTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.недвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентнедвижимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяОперацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделкаВДиапозонеЦенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentNedvizh1 = new KursProjDB.AgentNedvizh();
            this.операцииTableAdapter1 = new KursProjDB.AgentNedvizhTableAdapters.ОперацииTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.историяоперацийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентнедвижимостьBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klientidDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // klientidDataGridViewTextBoxColumn
            // 
            this.klientidDataGridViewTextBoxColumn.DataPropertyName = "klient_id";
            this.klientidDataGridViewTextBoxColumn.HeaderText = "klient_id";
            this.klientidDataGridViewTextBoxColumn.Name = "klientidDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.agentNedvizh;
            // 
            // agentNedvizh
            // 
            this.agentNedvizh.DataSetName = "AgentNedvizh";
            this.agentNedvizh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nedvizhimostidDataGridViewTextBoxColumn,
            this.наименованиенедвижимостиDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.районDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.балконDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.недвижимостьBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(842, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // nedvizhimostidDataGridViewTextBoxColumn
            // 
            this.nedvizhimostidDataGridViewTextBoxColumn.DataPropertyName = "nedvizhimost_id";
            this.nedvizhimostidDataGridViewTextBoxColumn.HeaderText = "nedvizhimost_id";
            this.nedvizhimostidDataGridViewTextBoxColumn.Name = "nedvizhimostidDataGridViewTextBoxColumn";
            // 
            // наименованиенедвижимостиDataGridViewTextBoxColumn
            // 
            this.наименованиенедвижимостиDataGridViewTextBoxColumn.DataPropertyName = "Наименование_недвижимости";
            this.наименованиенедвижимостиDataGridViewTextBoxColumn.HeaderText = "Наименование_недвижимости";
            this.наименованиенедвижимостиDataGridViewTextBoxColumn.Name = "наименованиенедвижимостиDataGridViewTextBoxColumn";
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            // 
            // районDataGridViewTextBoxColumn
            // 
            this.районDataGridViewTextBoxColumn.DataPropertyName = "Район";
            this.районDataGridViewTextBoxColumn.HeaderText = "Район";
            this.районDataGridViewTextBoxColumn.Name = "районDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            // 
            // балконDataGridViewTextBoxColumn
            // 
            this.балконDataGridViewTextBoxColumn.DataPropertyName = "Балкон";
            this.балконDataGridViewTextBoxColumn.HeaderText = "Балкон";
            this.балконDataGridViewTextBoxColumn.Name = "балконDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
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
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sotrudnikidDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.датарожденияDataGridViewTextBoxColumn1,
            this.пасспортныеданныеDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.номертелефонасотрудникаDataGridViewTextBoxColumn,
            this.klientidDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.сотрудникиBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 348);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(843, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // sotrudnikidDataGridViewTextBoxColumn
            // 
            this.sotrudnikidDataGridViewTextBoxColumn.DataPropertyName = "sotrudnik_id";
            this.sotrudnikidDataGridViewTextBoxColumn.HeaderText = "sotrudnik_id";
            this.sotrudnikidDataGridViewTextBoxColumn.Name = "sotrudnikidDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            // 
            // датарожденияDataGridViewTextBoxColumn1
            // 
            this.датарожденияDataGridViewTextBoxColumn1.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn1.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn1.Name = "датарожденияDataGridViewTextBoxColumn1";
            // 
            // пасспортныеданныеDataGridViewTextBoxColumn
            // 
            this.пасспортныеданныеDataGridViewTextBoxColumn.DataPropertyName = "Пасспортные_данные";
            this.пасспортныеданныеDataGridViewTextBoxColumn.HeaderText = "Пасспортные_данные";
            this.пасспортныеданныеDataGridViewTextBoxColumn.Name = "пасспортныеданныеDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // номертелефонасотрудникаDataGridViewTextBoxColumn
            // 
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона_сотрудника";
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона_сотрудника";
            this.номертелефонасотрудникаDataGridViewTextBoxColumn.Name = "номертелефонасотрудникаDataGridViewTextBoxColumn";
            // 
            // klientidDataGridViewTextBoxColumn1
            // 
            this.klientidDataGridViewTextBoxColumn1.DataPropertyName = "klient_id";
            this.klientidDataGridViewTextBoxColumn1.HeaderText = "klient_id";
            this.klientidDataGridViewTextBoxColumn1.Name = "klientidDataGridViewTextBoxColumn1";
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
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nedvizhimostidDataGridViewTextBoxColumn1,
            this.операцияDataGridViewTextBoxColumn,
            this.датаоперацииDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.историяоперацийBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(13, 505);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(459, 150);
            this.dataGridView4.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nedvizhimostidDataGridViewTextBoxColumn1
            // 
            this.nedvizhimostidDataGridViewTextBoxColumn1.DataPropertyName = "nedvizhimost_id";
            this.nedvizhimostidDataGridViewTextBoxColumn1.HeaderText = "nedvizhimost_id";
            this.nedvizhimostidDataGridViewTextBoxColumn1.Name = "nedvizhimostidDataGridViewTextBoxColumn1";
            // 
            // операцияDataGridViewTextBoxColumn
            // 
            this.операцияDataGridViewTextBoxColumn.DataPropertyName = "Операция";
            this.операцияDataGridViewTextBoxColumn.HeaderText = "Операция";
            this.операцияDataGridViewTextBoxColumn.Name = "операцияDataGridViewTextBoxColumn";
            // 
            // датаоперацииDataGridViewTextBoxColumn
            // 
            this.датаоперацииDataGridViewTextBoxColumn.DataPropertyName = "Дата_операции";
            this.датаоперацииDataGridViewTextBoxColumn.HeaderText = "Дата_операции";
            this.датаоперацииDataGridViewTextBoxColumn.Name = "датаоперацииDataGridViewTextBoxColumn";
            // 
            // историяоперацийBindingSource
            // 
            this.историяоперацийBindingSource.DataMember = "История_операций";
            this.историяоперацийBindingSource.DataSource = this.agentNedvizh;
            // 
            // история_операцийTableAdapter
            // 
            this.история_операцийTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operaciidDataGridViewTextBoxColumn,
            this.наименованиеоперацииDataGridViewTextBoxColumn,
            this.klientidDataGridViewTextBoxColumn2});
            this.dataGridView5.DataSource = this.операцииBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(478, 504);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(377, 150);
            this.dataGridView5.TabIndex = 4;
            // 
            // operaciidDataGridViewTextBoxColumn
            // 
            this.operaciidDataGridViewTextBoxColumn.DataPropertyName = "operaci_id";
            this.operaciidDataGridViewTextBoxColumn.HeaderText = "operaci_id";
            this.operaciidDataGridViewTextBoxColumn.Name = "operaciidDataGridViewTextBoxColumn";
            // 
            // наименованиеоперацииDataGridViewTextBoxColumn
            // 
            this.наименованиеоперацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование_операции";
            this.наименованиеоперацииDataGridViewTextBoxColumn.HeaderText = "Наименование_операции";
            this.наименованиеоперацииDataGridViewTextBoxColumn.Name = "наименованиеоперацииDataGridViewTextBoxColumn";
            // 
            // klientidDataGridViewTextBoxColumn2
            // 
            this.klientidDataGridViewTextBoxColumn2.DataPropertyName = "klient_id";
            this.klientidDataGridViewTextBoxColumn2.HeaderText = "klient_id";
            this.klientidDataGridViewTextBoxColumn2.Name = "klientidDataGridViewTextBoxColumn2";
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
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klientidDataGridViewTextBoxColumn3,
            this.nedvizhimostidDataGridViewTextBoxColumn2});
            this.dataGridView6.DataSource = this.клиентнедвижимостьBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(555, 34);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(300, 150);
            this.dataGridView6.TabIndex = 5;
            // 
            // klientidDataGridViewTextBoxColumn3
            // 
            this.klientidDataGridViewTextBoxColumn3.DataPropertyName = "klient_id";
            this.klientidDataGridViewTextBoxColumn3.HeaderText = "klient_id";
            this.klientidDataGridViewTextBoxColumn3.Name = "klientidDataGridViewTextBoxColumn3";
            // 
            // nedvizhimostidDataGridViewTextBoxColumn2
            // 
            this.nedvizhimostidDataGridViewTextBoxColumn2.DataPropertyName = "nedvizhimost_id";
            this.nedvizhimostidDataGridViewTextBoxColumn2.HeaderText = "nedvizhimost_id";
            this.nedvizhimostidDataGridViewTextBoxColumn2.Name = "nedvizhimostidDataGridViewTextBoxColumn2";
            // 
            // клиентнедвижимостьBindingSource
            // 
            this.клиентнедвижимостьBindingSource.DataMember = "Клиент_недвижимость";
            this.клиентнедвижимостьBindingSource.DataSource = this.agentNedvizh;
            // 
            // клиент_недвижимостьTableAdapter
            // 
            this.клиент_недвижимостьTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem,
            this.сделкаВДиапозонеЦенToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.недвижимостьToolStripMenuItem,
            this.клиентнедвижимостьToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.историяОперацийToolStripMenuItem});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // недвижимостьToolStripMenuItem
            // 
            this.недвижимостьToolStripMenuItem.Name = "недвижимостьToolStripMenuItem";
            this.недвижимостьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.недвижимостьToolStripMenuItem.Text = "Недвижимость";
            this.недвижимостьToolStripMenuItem.Click += new System.EventHandler(this.недвижимостьToolStripMenuItem_Click);
            // 
            // клиентнедвижимостьToolStripMenuItem
            // 
            this.клиентнедвижимостьToolStripMenuItem.Name = "клиентнедвижимостьToolStripMenuItem";
            this.клиентнедвижимостьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.клиентнедвижимостьToolStripMenuItem.Text = "Клиент недвижимость";
            this.клиентнедвижимостьToolStripMenuItem.Click += new System.EventHandler(this.клиентнедвижимостьToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.операцииToolStripMenuItem.Text = "Операции";
            this.операцииToolStripMenuItem.Click += new System.EventHandler(this.операцииToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // историяОперацийToolStripMenuItem
            // 
            this.историяОперацийToolStripMenuItem.Name = "историяОперацийToolStripMenuItem";
            this.историяОперацийToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.историяОперацийToolStripMenuItem.Text = "История операций";
            this.историяОперацийToolStripMenuItem.Click += new System.EventHandler(this.историяОперацийToolStripMenuItem_Click);
            // 
            // сделкаВДиапозонеЦенToolStripMenuItem
            // 
            this.сделкаВДиапозонеЦенToolStripMenuItem.Name = "сделкаВДиапозонеЦенToolStripMenuItem";
            this.сделкаВДиапозонеЦенToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.сделкаВДиапозонеЦенToolStripMenuItem.Text = "Сделка в диапозоне цен";
            this.сделкаВДиапозонеЦенToolStripMenuItem.Click += new System.EventHandler(this.сделкаВДиапозонеЦенToolStripMenuItem_Click);
            // 
            // agentNedvizh1
            // 
            this.agentNedvizh1.DataSetName = "AgentNedvizh";
            this.agentNedvizh1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // операцииTableAdapter1
            // 
            this.операцииTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(902, 669);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Агентство недвижимости";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.недвижимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.историяоперацийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентнедвижимостьBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentNedvizh1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AgentNedvizh agentNedvizh;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private AgentNedvizhTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource недвижимостьBindingSource;
        private AgentNedvizhTableAdapters.НедвижимостьTableAdapter недвижимостьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedvizhimostidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиенедвижимостиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn районDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn балконDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private AgentNedvizhTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrudnikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn пасспортныеданныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонасотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource историяоперацийBindingSource;
        private AgentNedvizhTableAdapters.История_операцийTableAdapter история_операцийTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedvizhimostidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn операцияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаоперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource операцииBindingSource;
        private AgentNedvizhTableAdapters.ОперацииTableAdapter операцииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operaciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеоперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource клиентнедвижимостьBindingSource;
        private AgentNedvizhTableAdapters.Клиент_недвижимостьTableAdapter клиент_недвижимостьTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientidDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedvizhimostidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem недвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентнедвижимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяОперацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделкаВДиапозонеЦенToolStripMenuItem;
        private AgentNedvizh agentNedvizh1;
        private AgentNedvizhTableAdapters.ОперацииTableAdapter операцииTableAdapter1;
    }
}

