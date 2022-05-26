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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void BtnMenuCadFun_Click(object sender, EventArgs e)
        {
            Menus Me = new Menus();
            Me.Show();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
