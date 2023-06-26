
namespace DDS03
{
    partial class DDS03
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExibir = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.opAdicao = new System.Windows.Forms.RadioButton();
            this.opSubtracao = new System.Windows.Forms.RadioButton();
            this.opMultiplicacao = new System.Windows.Forms.RadioButton();
            this.opDivisao = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblExibir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LblResultado);
            this.panel1.Controls.Add(this.LblNumero2);
            this.panel1.Controls.Add(this.LblNumero1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 164);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Location = new System.Drawing.Point(378, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 164);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opDivisao);
            this.groupBox1.Controls.Add(this.opMultiplicacao);
            this.groupBox1.Controls.Add(this.opSubtracao);
            this.groupBox1.Controls.Add(this.opAdicao);
            this.groupBox1.Location = new System.Drawing.Point(202, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Location = new System.Drawing.Point(13, 22);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(57, 13);
            this.LblNumero1.TabIndex = 0;
            this.LblNumero1.Text = "1º Número";
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Location = new System.Drawing.Point(13, 64);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.Size = new System.Drawing.Size(57, 13);
            this.LblNumero2.TabIndex = 1;
            this.LblNumero2.Text = "2º Número";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(13, 105);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(55, 13);
            this.LblResultado.TabIndex = 2;
            this.LblResultado.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // lblExibir
            // 
            this.lblExibir.BackColor = System.Drawing.SystemColors.Control;
            this.lblExibir.Location = new System.Drawing.Point(74, 105);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(69, 10);
            this.lblExibir.TabIndex = 7;
            this.lblExibir.Click += new System.EventHandler(this.lblExibir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(47, 16);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(47, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(47, 100);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // opAdicao
            // 
            this.opAdicao.AutoSize = true;
            this.opAdicao.Location = new System.Drawing.Point(22, 27);
            this.opAdicao.Name = "opAdicao";
            this.opAdicao.Size = new System.Drawing.Size(79, 17);
            this.opAdicao.TabIndex = 0;
            this.opAdicao.TabStop = true;
            this.opAdicao.Text = "Adição ( + )";
            this.opAdicao.UseVisualStyleBackColor = true;
            // 
            // opSubtracao
            // 
            this.opSubtracao.AutoSize = true;
            this.opSubtracao.Location = new System.Drawing.Point(22, 50);
            this.opSubtracao.Name = "opSubtracao";
            this.opSubtracao.Size = new System.Drawing.Size(92, 17);
            this.opSubtracao.TabIndex = 1;
            this.opSubtracao.TabStop = true;
            this.opSubtracao.Text = "Subtração ( - )";
            this.opSubtracao.UseVisualStyleBackColor = true;
            // 
            // opMultiplicacao
            // 
            this.opMultiplicacao.AutoSize = true;
            this.opMultiplicacao.Location = new System.Drawing.Point(22, 73);
            this.opMultiplicacao.Name = "opMultiplicacao";
            this.opMultiplicacao.Size = new System.Drawing.Size(106, 17);
            this.opMultiplicacao.TabIndex = 2;
            this.opMultiplicacao.TabStop = true;
            this.opMultiplicacao.Text = "Multiplicação ( * )";
            this.opMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // opDivisao
            // 
            this.opDivisao.AutoSize = true;
            this.opDivisao.Location = new System.Drawing.Point(22, 96);
            this.opDivisao.Name = "opDivisao";
            this.opDivisao.Size = new System.Drawing.Size(80, 17);
            this.opDivisao.TabIndex = 3;
            this.opDivisao.TabStop = true;
            this.opDivisao.Text = "Divisão ( / )";
            this.opDivisao.UseVisualStyleBackColor = true;
            // 
            // DDS03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 218);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "DDS03";
            this.Text = "Calculadora Versão 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblExibir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton opDivisao;
        private System.Windows.Forms.RadioButton opMultiplicacao;
        private System.Windows.Forms.RadioButton opSubtracao;
        private System.Windows.Forms.RadioButton opAdicao;
    }
}

