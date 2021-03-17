using HospedagemDaTiaLia.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HospedagemDaTiaLia
{
    public partial class FrmCadastrarHospede : Form
    {

        static TiaLiaContext tldb = new TiaLiaContext();

        public FrmCadastrarHospede()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCadastrarHospede_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGravaHospede_Click(object sender, EventArgs e)
        {
            var conta = tldb.Hospede.Count();
            conta++;
            try
            {
                var hospedes = new Hospede()
                {
                    Id = conta,
                    Nome = tbNome.Text.ToString(),
                    Sobrenome = tbSobrenome.Text.ToString(),
                    DataNasc = tbData.Text.ToString(),
                    Telefone = tbtelefone.Text.ToString(),
                    Celular = tbCelular.Text.ToString(),
                    Rg = tbRg.Text.ToString(),
                    Cpf = tbCpf.Text.ToString(),
                    Logadouro = tbRua.Text.ToString(),
                    Numero = tbNumero.Text.ToString(),
                    Complemento = tbComplemento.Text.ToString(),
                    Bairro = tbBairro.Text.ToString(),
                    Cidade = tbCidade.Text.ToString(),
                    Estado = tbEstado.Text.ToString(),
                    Empresa = tbEmpresa.Text.ToString()
                };

                tldb.Add(hospedes);
                tldb.SaveChanges();
                MessageBox.Show("Dados Gravados Com sucesso!!");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro" + er);
            }

        }
    }
}
