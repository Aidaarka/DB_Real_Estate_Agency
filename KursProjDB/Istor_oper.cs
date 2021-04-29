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
    public partial class Istor_oper : Form
    {
        public Istor_oper()
        {
            InitializeComponent();
        }

        private void история_операцийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.история_операцийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentNedvizh);

        }

        private void Istor_oper_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.История_операций". При необходимости она может быть перемещена или удалена.
            this.история_операцийTableAdapter.Fill(this.agentNedvizh.История_операций);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.история_операцийBindingSource.EndEdit();
            this.история_операцийTableAdapter.Update(this.agentNedvizh.История_операций);
        }
    }
}
