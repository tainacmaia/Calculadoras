namespace Calculadoras
{
    partial class FrmCalculaIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculaIMC));
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Label();
            this.lblSistema = new System.Windows.Forms.Label();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.lblkg = new System.Windows.Forms.Label();
            this.lblcm = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskAltura
            // 
            this.mskAltura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskAltura.Location = new System.Drawing.Point(154, 271);
            this.mskAltura.Mask = "000";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.PromptChar = ' ';
            this.mskAltura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskAltura.Size = new System.Drawing.Size(329, 23);
            this.mskAltura.TabIndex = 2;
            this.mskAltura.ValidatingType = typeof(int);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(105, 234);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(38, 18);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.Location = new System.Drawing.Point(95, 272);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(48, 18);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(322, 352);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(223, 309);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(60, 18);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(363, 309);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(54, 18);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.lblLimpar_Click);
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSistema.Location = new System.Drawing.Point(245, 165);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(153, 56);
            this.lblSistema.TabIndex = 8;
            this.lblSistema.Text = "Sistema de \r\nCálculo de IMC";
            this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mskPeso
            // 
            this.mskPeso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskPeso.Location = new System.Drawing.Point(154, 233);
            this.mskPeso.Mask = "000";
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.PromptChar = ' ';
            this.mskPeso.Size = new System.Drawing.Size(329, 23);
            this.mskPeso.TabIndex = 1;
            this.mskPeso.ValidatingType = typeof(int);
            this.mskPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskPeso_MaskInputRejected);
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Location = new System.Drawing.Point(489, 237);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(20, 15);
            this.lblkg.TabIndex = 11;
            this.lblkg.Text = "kg";
            // 
            // lblcm
            // 
            this.lblcm.AutoSize = true;
            this.lblcm.Location = new System.Drawing.Point(489, 275);
            this.lblcm.Name = "lblcm";
            this.lblcm.Size = new System.Drawing.Size(24, 15);
            this.lblcm.TabIndex = 12;
            this.lblcm.Text = "cm";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(163, 384);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(159, 23);
            this.btnRetornar.TabIndex = 27;
            this.btnRetornar.Text = "Retornar ao Menu Inicial";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(363, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmCalculaIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 419);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.lblcm);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.mskPeso);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.lblSistema);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "FrmCalculaIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.Load += new System.EventHandler(this.CalculaIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPeso;
        private Label lblAltura;
        private PictureBox pictureBox1;
        private Label lblResultado;
        private Label btnCalcular;
        private Label btnLimpar;
        private Label lblSistema;
        private MaskedTextBox mskAltura;
        private MaskedTextBox mskPeso;
        private Label lblkg;
        private Label lblcm;
        private Button btnRetornar;
        private Button btnSair;
    }
}