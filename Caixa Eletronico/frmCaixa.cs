using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caixa_Eletronico
{
    public partial class FrmCaixa : Form
    {
        Singleton s;
        //siga a banda contritus
        public FrmCaixa()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txLogin.Text);
            if (c != null)
            {
                s.conta_logada = c;
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Conta inexistente");
                txLogin.Text = "";
            }
        }

        private void txLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {

        }

        private void FrmCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
