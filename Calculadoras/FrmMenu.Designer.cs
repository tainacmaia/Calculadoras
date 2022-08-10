namespace Calculadoras
{
    partial class FrmMenu
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalculaIMC = new System.Windows.Forms.Button();
            this.btnCalculadoraSimples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBemVindo.Location = new System.Drawing.Point(111, 36);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(149, 31);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-vindo!";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPergunta.Location = new System.Drawing.Point(31, 76);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(321, 25);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "Qual programa você deseja acessar?";
            this.lblPergunta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(147, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalculaIMC
            // 
            this.btnCalculaIMC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculaIMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculaIMC.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculaIMC.Location = new System.Drawing.Point(94, 123);
            this.btnCalculaIMC.Name = "btnCalculaIMC";
            this.btnCalculaIMC.Size = new System.Drawing.Size(178, 38);
            this.btnCalculaIMC.TabIndex = 7;
            this.btnCalculaIMC.Text = "Calculadora de IMC";
            this.btnCalculaIMC.UseVisualStyleBackColor = false;
            this.btnCalculaIMC.Click += new System.EventHandler(this.btnCalculaIMC_Click);
            // 
            // btnCalculadoraSimples
            // 
            this.btnCalculadoraSimples.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculadoraSimples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculadoraSimples.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculadoraSimples.Location = new System.Drawing.Point(94, 167);
            this.btnCalculadoraSimples.Name = "btnCalculadoraSimples";
            this.btnCalculadoraSimples.Size = new System.Drawing.Size(178, 38);
            this.btnCalculadoraSimples.TabIndex = 9;
            this.btnCalculadoraSimples.Text = "Calculadora Simples";
            this.btnCalculadoraSimples.UseVisualStyleBackColor = false;
            this.btnCalculadoraSimples.Click += new System.EventHandler(this.btnCalculadoraSimples_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalculadoraSimples);
            this.Controls.Add(this.btnCalculaIMC);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblBemVindo);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBemVindo;
        private Label lblPergunta;
        private Button btnSair;
        private Button btnCalculaIMC;
        private Button btnCalculadoraSimples;
    }
}