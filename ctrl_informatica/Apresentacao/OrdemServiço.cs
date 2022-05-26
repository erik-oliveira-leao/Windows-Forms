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
    public partial class OrdemServiço : Form
    {
        public OrdemServiço()
        {
            InitializeComponent();
        }

        private void BtnMenuOs_Click(object sender, EventArgs e)
        {
            Menus Me = new Menus();
            Me.Show();
        }
    }
}
