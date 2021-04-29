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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Клиент_недвижимость". При необходимости она может быть перемещена или удалена.
            this.клиент_недвижимостьTableAdapter.Fill(this.agentNedvizh.Клиент_недвижимость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Операции". При необходимости она может быть перемещена или удалена.
            this.операцииTableAdapter.Fill(this.agentNedvizh.Операции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.История_операций". При необходимости она может быть перемещена или удалена.
            this.история_операцийTableAdapter.Fill(this.agentNedvizh.История_операций);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.agentNedvizh.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Недвижимость". При необходимости она может быть перемещена или удалена.
            this.недвижимостьTableAdapter.Fill(this.agentNedvizh.Недвижимость);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agentNedvizh.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.agentNedvizh.Клиенты);

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klienti myForm2 = new Klienti();
            myForm2.Show();
        }

        private void недвижимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nedvizhimost myForm3 = new Nedvizhimost();
            myForm3.Show();
        }

        private void клиентнедвижимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klient_Nedviz myForm4 = new Klient_Nedviz();
            myForm4.Show();
        }

        private void операцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacii myForm5 = new Operacii();
            myForm5.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sotrudniki myForm6 = new Sotrudniki();
            myForm6.Show();
        }

        private void историяОперацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istor_oper myForm7 = new Istor_oper();
            myForm7.Show();
        }

        private void сделкаВДиапозонеЦенToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procedura myForm8 = new Procedura();
            myForm8.Show();
        }
    }
}
