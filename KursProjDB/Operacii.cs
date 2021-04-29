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
    public partial class Operacii : Form
    {
        public Operacii()
        {
            InitializeComponent();
        }

        private void операцииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.операцииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentNedvizh);

        }

        private void Operacii_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.agentNedvizh.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Операции". При необходимости она может быть перемещена или удалена.
            this.операцииTableAdapter.Fill(this.agentNedvizh.Операции);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.операцииBindingSource.EndEdit();
            this.операцииTableAdapter.Update(this.agentNedvizh.Операции);
        }
    }
}
