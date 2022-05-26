using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctrl_informatica.Apresentacao
{
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
        }

        private void BtnCadFunc_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadFun = new CadastroFuncionario();
            cadFun.Show();
        }

        private void BtnServico_Click(object sender, EventArgs e)
        {
            OrdemServiço Os = new OrdemServiço();
            Os.Show();
        }

        private void BtnChamado_Click(object sender, EventArgs e)
        {
            Chamado Chamd = new Chamado();
            Chamd.Show();
        }

        private void BtnBloc_Click(object sender, EventArgs e)
        {
            Entrar Log = new Entrar();
            Log.Show();
        }
    }
}
