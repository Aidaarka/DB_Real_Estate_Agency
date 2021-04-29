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
    public partial class Nedvizhimost : Form
    {
        public Nedvizhimost()
        {
            InitializeComponent();
        }

        private void недвижимостьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.недвижимостьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agentNedvizh);

        }

        private void Nedvizhimost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Недвижимость". При необходимости она может быть перемещена или удалена.
            this.недвижимостьTableAdapter.Fill(this.agentNedvizh.Недвижимость);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.недвижимостьBindingSource.EndEdit();
            this.недвижимостьTableAdapter.Update(this.agentNedvizh.Недвижимость);
        }
    }
}
