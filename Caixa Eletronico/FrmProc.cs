using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa_Eletronico.Classes;

namespace Caixa_Eletronico
{
    public partial class FrmProc : Form
    {
        bool pode_N;
        bool pode_T;
        Singleton s;
        private string t;

        public FrmProc()
        {
            s = Singleton.Instance;
        }
        public FrmProc(string tipo) : this()
        {
            InitializeComponent();
            this.t = tipo;
        }

        private void FrmProc_Load(object sender, EventArgs e)
        {
            if (t == "Transferência")
            {
                TxtConta.Visible = true;
                lbDestino.Visible = true;
            }
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (t == "Saque")
            {
                double valor = (double)NumValor.Value;
                if (s.conta_logada.Sacar(valor))
                {
                    MessageBox.Show("Saque realizado");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente");
                }
            }
            if (t == "Depósito")
            {
                double valor = (double)NumValor.Value;
                s.conta_logada.Depositar(valor);
                MessageBox.Show("Depósito realizado!");
            }
            if (t == "Transferência")
            {
                double valor = (double)NumValor.Value;
                Conta destino = s.BuscarConta(TxtConta.Text);
                if (destino != null)
                {
                    if (s.conta_logada.Transferir(destino, valor))
                    {
                        MessageBox.Show("Transferência realizada!");
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                    }
                }
                else
                {
                    MessageBox.Show("Conta destino inexistente!");
                }
            }
            FrmCaixa frm = new FrmCaixa();
            frm.Show();
            this.Hide();
        }
        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            if (t != "Transferência")
            {
                if (NumValor.Value != 0)
                {
                    BtnEnviar.Enabled = true;
                }
                else
                {
                    BtnEnviar.Enabled = false;
                }
            }
            else
            {
                if (NumValor.Value != 0)
                {
                    pode_N = true;
                    CheckEnableBtFazer();
                }
                else
                {
                    pode_N = false;
                    CheckEnableBtFazer();
                }
            }
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            if (TxtConta.Text != "")
            {
                pode_T = true;
                CheckEnableBtFazer();
            }
            else
            {
                BtnEnviar.Enabled = false;
            }
        }
        private void CheckEnableBtFazer()
        {
            if (t == "Transferência")
            {
                BtnEnviar.Enabled = pode_N && pode_T;
            }
        }
    }
}