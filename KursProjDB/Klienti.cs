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
    public partial class Klienti : Form
    {
        public Klienti()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentNedvizh);

        }

        private void Klienti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.agentNedvizh.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.клиентыTableAdapter.Update(this.agentNedvizh.Клиенты);
        }
    }
}
