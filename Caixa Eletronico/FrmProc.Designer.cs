namespace Caixa_Eletronico
{
    partial class FrmProc
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
            NumValor = new NumericUpDown();
            lbDestino = new Label();
            TxtConta = new TextBox();
            BtnEnviar = new Button();
            lbValor = new Label();
            ((System.ComponentModel.ISupportInitialize)NumValor).BeginInit();
            SuspendLayout();
            // 
            // NumValor
            // 
            NumValor.Location = new Point(133, 30);
            NumValor.Name = "NumValor";
            NumValor.Size = new Size(120, 23);
            NumValor.TabIndex = 0;
            // 
            // lbDestino
            // 
            lbDestino.AutoSize = true;
            lbDestino.Location = new Point(27, 71);
            lbDestino.Name = "lbDestino";
            lbDestino.Size = new Size(100, 15);
            lbDestino.TabIndex = 2;
            lbDestino.Text = "Conta de destino:";
            lbDestino.Visible = false;
            // 
            // TxtConta
            // 
            TxtConta.Location = new Point(133, 68);
            TxtConta.Name = "TxtConta";
            TxtConta.Size = new Size(120, 23);
            TxtConta.TabIndex = 3;
            TxtConta.Visible = false;
            // 
            // BtnEnviar
            // 
            BtnEnviar.Location = new Point(45, 107);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(197, 42);
            BtnEnviar.TabIndex = 4;
            BtnEnviar.Text = "Enviar";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(27, 32);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(36, 15);
            lbValor.TabIndex = 5;
            lbValor.Text = "Valor:";
            // 
            // FrmProc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 180);
            Controls.Add(lbValor);
            Controls.Add(BtnEnviar);
            Controls.Add(TxtConta);
            Controls.Add(lbDestino);
            Controls.Add(NumValor);
            Name = "FrmProc";
            Text = "FrmProc";
            Load += FrmProc_Load;
            ((System.ComponentModel.ISupportInitialize)NumValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumValor;
        private Label lbDestino;
        private TextBox TxtConta;
        private Button BtnEnviar;
        private Label lbValor;
        private Label LblOpcao;
    }
}