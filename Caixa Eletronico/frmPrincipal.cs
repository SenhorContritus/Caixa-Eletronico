using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Caixa_Eletronico
{
    public partial class FrmPrincipal : Form
    {
        Singleton s;
        public FrmPrincipal()
        {
            InitializeComponent();
            s = Singleton.Instance;
            saldo.Text = s.conta_logada.Saldo.ToString();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frmInicial = new FrmInicial();
            frmInicial.Show();
            this.Close();
        }
        private void BtnExtrato_Click(object sender, EventArgs e)
        {
            FrmExtrato frm = new FrmExtrato();
            frm.Show();
            this.Hide();
        }
        private void BtnSacar_Click(object sender, EventArgs e)
        {
            FrmProc frmProc = new FrmProc("Saque");
            frmProc.Show();
            this.Hide();
        }
        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            FrmProc frmProc = new FrmProc("Depósito");
            frmProc.Show();
            this.Hide();
        }
        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            FrmProc frmProc = new FrmProc("Transferência");
            frmProc.Show();
            this.Hide();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
