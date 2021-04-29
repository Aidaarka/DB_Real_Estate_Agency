using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursProjDB
{
    public partial class Klient_Nedviz : Form
    {
        public Klient_Nedviz()
        {
            InitializeComponent();
        }

        private void клиент_недвижимостьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиент_недвижимостьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentNedvizh);

        }

        private void Klient_Nedviz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Недвижимость". При необходимости она может быть перемещена или удалена.
            this.недвижимостьTableAdapter.Fill(this.agentNedvizh.Недвижимость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.agentNedvizh.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Клиент_недвижимость". При необходимости она может быть перемещена или удалена.
            this.клиент_недвижимостьTableAdapter.Fill(this.agentNedvizh.Клиент_недвижимость);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиент_недвижимостьBindingSource.EndEdit();
            this.клиент_недвижимостьTableAdapter.Update(this.agentNedvizh.Клиент_недвижимость);
        }
    }
}
