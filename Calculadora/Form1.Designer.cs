
namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblComentario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grpEntradaValores = new System.Windows.Forms.GroupBox();
            this.txtDigiteSegundoNumero = new System.Windows.Forms.TextBox();
            this.txtDigitePrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblDigiteSegundoNumero = new System.Windows.Forms.Label();
            this.lblDigitePrimeiroNumero = new System.Windows.Forms.Label();
            this.grpOperacoesMatematicas = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.grpExibirResultado = new System.Windows.Forms.GroupBox();
            this.grpEntradaValores.SuspendLayout();
            this.grpOperacoesMatematicas.SuspendLayout();
            this.grpExibirResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.lblComentario.Location = new System.Drawing.Point(172, 193);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(188, 15);
            this.lblComentario.TabIndex = 10;
            this.lblComentario.Text = "Digite somente números inteiros!";
            this.lblComentario.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(550, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(550, 211);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 51);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(149, 51);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.Visible = false;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // grpEntradaValores
            // 
            this.grpEntradaValores.Controls.Add(this.txtDigiteSegundoNumero);
            this.grpEntradaValores.Controls.Add(this.txtDigitePrimeiroNumero);
            this.grpEntradaValores.Controls.Add(this.lblDigiteSegundoNumero);
            this.grpEntradaValores.Controls.Add(this.lblDigitePrimeiroNumero);
            this.grpEntradaValores.Location = new System.Drawing.Point(44, 12);
            this.grpEntradaValores.Name = "grpEntradaValores";
            this.grpEntradaValores.Size = new System.Drawing.Size(316, 173);
            this.grpEntradaValores.TabIndex = 0;
            this.grpEntradaValores.TabStop = false;
            this.grpEntradaValores.Text = "Entrada de Valores";
            // 
            // txtDigiteSegundoNumero
            // 
            this.txtDigiteSegundoNumero.Location = new System.Drawing.Point(149, 107);
            this.txtDigiteSegundoNumero.Name = "txtDigiteSegundoNumero";
            this.txtDigiteSegundoNumero.Size = new System.Drawing.Size(100, 20);
            this.txtDigiteSegundoNumero.TabIndex = 8;
            this.txtDigiteSegundoNumero.TextChanged += new System.EventHandler(this.txtDigiteSegundoNumero_TextChanged);
            // 
            // txtDigitePrimeiroNumero
            // 
            this.txtDigitePrimeiroNumero.Location = new System.Drawing.Point(149, 34);
            this.txtDigitePrimeiroNumero.Name = "txtDigitePrimeiroNumero";
            this.txtDigitePrimeiroNumero.Size = new System.Drawing.Size(100, 20);
            this.txtDigitePrimeiroNumero.TabIndex = 7;
            this.txtDigitePrimeiroNumero.TextChanged += new System.EventHandler(this.txtDigitePrimeiroNumero_TextChanged);
            // 
            // lblDigiteSegundoNumero
            // 
            this.lblDigiteSegundoNumero.AutoSize = true;
            this.lblDigiteSegundoNumero.Location = new System.Drawing.Point(6, 110);
            this.lblDigiteSegundoNumero.Name = "lblDigiteSegundoNumero";
            this.lblDigiteSegundoNumero.Size = new System.Drawing.Size(127, 13);
            this.lblDigiteSegundoNumero.TabIndex = 6;
            this.lblDigiteSegundoNumero.Text = "Digite o Segundo número";
            // 
            // lblDigitePrimeiroNumero
            // 
            this.lblDigitePrimeiroNumero.AutoSize = true;
            this.lblDigitePrimeiroNumero.Location = new System.Drawing.Point(6, 37);
            this.lblDigitePrimeiroNumero.Name = "lblDigitePrimeiroNumero";
            this.lblDigitePrimeiroNumero.Size = new System.Drawing.Size(120, 13);
            this.lblDigitePrimeiroNumero.TabIndex = 5;
            this.lblDigitePrimeiroNumero.Text = "Digite o primeiro número";
            // 
            // grpOperacoesMatematicas
            // 
            this.grpOperacoesMatematicas.Controls.Add(this.btnAdicionar);
            this.grpOperacoesMatematicas.Controls.Add(this.btnSubtracao);
            this.grpOperacoesMatematicas.Controls.Add(this.btnDivisao);
            this.grpOperacoesMatematicas.Controls.Add(this.btnMultiplicacao);
            this.grpOperacoesMatematicas.Location = new System.Drawing.Point(396, 12);
            this.grpOperacoesMatematicas.Name = "grpOperacoesMatematicas";
            this.grpOperacoesMatematicas.Size = new System.Drawing.Size(229, 173);
            this.grpOperacoesMatematicas.TabIndex = 13;
            this.grpOperacoesMatematicas.TabStop = false;
            this.grpOperacoesMatematicas.Text = "Operações Matemáticas";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(24, 46);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(136, 46);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 23);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(24, 102);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 23);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(136, 102);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicacao.TabIndex = 9;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.button4_Click);
            // 
            // grpExibirResultado
            // 
            this.grpExibirResultado.Controls.Add(this.lblResultado);
            this.grpExibirResultado.Controls.Add(this.txtResultado);
            this.grpExibirResultado.Location = new System.Drawing.Point(44, 225);
            this.grpExibirResultado.Name = "grpExibirResultado";
            this.grpExibirResultado.Size = new System.Drawing.Size(316, 127);
            this.grpExibirResultado.TabIndex = 14;
            this.grpExibirResultado.TabStop = false;
            this.grpExibirResultado.Text = "Exibir Resultado";
            this.grpExibirResultado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpEntradaValores);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.grpOperacoesMatematicas);
            this.Controls.Add(this.grpExibirResultado);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.grpEntradaValores.ResumeLayout(false);
            this.grpEntradaValores.PerformLayout();
            this.grpOperacoesMatematicas.ResumeLayout(false);
            this.grpExibirResultado.ResumeLayout(false);
            this.grpExibirResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox grpEntradaValores;
        private System.Windows.Forms.TextBox txtDigiteSegundoNumero;
        private System.Windows.Forms.TextBox txtDigitePrimeiroNumero;
        private System.Windows.Forms.Label lblDigiteSegundoNumero;
        private System.Windows.Forms.Label lblDigitePrimeiroNumero;
        private System.Windows.Forms.GroupBox grpOperacoesMatematicas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.GroupBox grpExibirResultado;
    }
}

