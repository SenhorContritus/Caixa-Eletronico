namespace Caixa_Eletronico
{
    partial class FrmCaixa
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
            lbConta = new Label();
            txLogin = new TextBox();
            btLogin = new Button();
            SuspendLayout();
            // 
            // lbConta
            // 
            lbConta.AutoSize = true;
            lbConta.Font = new Font("Segoe UI", 12F);
            lbConta.Location = new Point(29, 73);
            lbConta.Name = "lbConta";
            lbConta.Size = new Size(54, 21);
            lbConta.TabIndex = 0;
            lbConta.Text = "Conta:";
            // 
            // txLogin
            // 
            txLogin.BackColor = SystemColors.Control;
            txLogin.Font = new Font("Segoe UI", 12F);
            txLogin.Location = new Point(101, 70);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(240, 29);
            txLogin.TabIndex = 2;
            txLogin.TextChanged += txLogin_TextChanged;
            // 
            // btLogin
            // 
            btLogin.BackColor = SystemColors.Control;
            btLogin.Font = new Font("Segoe UI", 12F);
            btLogin.Location = new Point(112, 130);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(159, 37);
            btLogin.TabIndex = 3;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // FrmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(383, 193);
            Controls.Add(btLogin);
            Controls.Add(txLogin);
            Controls.Add(lbConta);
            Name = "FrmCaixa";
            Text = "FormCaixa";
            FormClosed += FrmCaixa_FormClosed;
            Load += FrmCaixa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblC;
        private TextBox txLogin;
        private Button btLogin;
        private Label lbConta;
    }
}