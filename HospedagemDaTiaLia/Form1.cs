using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospedagemDaTiaLia
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void tsmsair(object sender, EventArgs e)
        {
            
        }

        private void NovoCadastroClientes(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastrarHospede ch = new FrmCadastrarHospede();
            ch.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastroReserva cr = new FrmCadastroReserva();
            cr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
