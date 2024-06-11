namespace Caixa_Eletronico
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saldo = new Label();
            lbSaldo = new Label();
            BtnExtrato = new Button();
            BtnTransferir = new Button();
            BtnDepositar = new Button();
            BtnSacar = new Button();
            BtnVoltar = new Button();
            SuspendLayout();
            // 
            // saldo
            // 
            saldo.AutoSize = true;
            saldo.Location = new Point(344, 23);
            saldo.Name = "saldo";
            saldo.Size = new Size(0, 15);
            saldo.TabIndex = 14;
            // 
            // lbSaldo
            // 
            lbSaldo.AutoSize = true;
            lbSaldo.Location = new Point(302, 23);
            lbSaldo.Name = "lbSaldo";
            lbSaldo.Size = new Size(42, 15);
            lbSaldo.TabIndex = 13;
            lbSaldo.Text = "Saldo: ";
            // 
            // BtnExtrato
            // 
            BtnExtrato.Location = new Point(69, 231);
            BtnExtrato.Name = "BtnExtrato";
            BtnExtrato.Size = new Size(275, 39);
            BtnExtrato.TabIndex = 12;
            BtnExtrato.Text = "Extrato";
            BtnExtrato.UseVisualStyleBackColor = true;
            BtnExtrato.Click += BtnExtrato_Click;
            // 
            // BtnTransferir
            // 
            BtnTransferir.Location = new Point(69, 184);
            BtnTransferir.Name = "BtnTransferir";
            BtnTransferir.Size = new Size(275, 41);
            BtnTransferir.TabIndex = 11;
            BtnTransferir.Text = "Transferir";
            BtnTransferir.UseVisualStyleBackColor = true;
            BtnTransferir.Click += BtnTransferir_Click;
            // 
            // BtnDepositar
            // 
            BtnDepositar.Location = new Point(69, 137);
            BtnDepositar.Name = "BtnDepositar";
            BtnDepositar.Size = new Size(275, 41);
            BtnDepositar.TabIndex = 10;
            BtnDepositar.Text = "Depositar";
            BtnDepositar.UseVisualStyleBackColor = true;
            BtnDepositar.Click += BtnDepositar_Click;
            // 
            // BtnSacar
            // 
            BtnSacar.Location = new Point(69, 92);
            BtnSacar.Name = "BtnSacar";
            BtnSacar.Size = new Size(275, 39);
            BtnSacar.TabIndex = 9;
            BtnSacar.Text = "Sacar";
            BtnSacar.UseVisualStyleBackColor = true;
            BtnSacar.Click += BtnSacar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(118, 36);
            BtnVoltar.TabIndex = 8;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 290);
            Controls.Add(saldo);
            Controls.Add(lbSaldo);
            Controls.Add(BtnExtrato);
            Controls.Add(BtnTransferir);
            Controls.Add(BtnDepositar);
            Controls.Add(BtnSacar);
            Controls.Add(BtnVoltar);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSaldo;
        private Label label1;
        private Button BtnExtrato;
        private Button BtnTransferir;
        private Button BtnDepositar;
        private Button BtnSacar;
        private Button BtnVoltar;
        private Label saldo;
        private Label lbSaldo;
    }
}