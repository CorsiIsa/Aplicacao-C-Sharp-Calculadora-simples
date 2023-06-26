using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS03
{
    public partial class DDS03 : Form
    {
        public DDS03()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            lblExibir.Text = null;
            btnCalcular.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblExibir_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);

                if (opAdicao.Checked)
                {
                    lblExibir.Text = (a + b).ToString();
                }
                if (opSubtracao.Checked)
                {
                    lblExibir.Text = (a - b).ToString();
                }
                if (opMultiplicacao.Checked)
                {
                    lblExibir.Text = (a * b).ToString();
                }
                if (opDivisao.Checked)
                {
                    lblExibir.Text = (a / b).ToString();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message,
                        "++++++ ERRO ++++++",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                this.Limpar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa? ",
                                "<<<< SAINDO >>>>",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Limpar();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                opAdicao.Focus();
            }
        }
    }
}
