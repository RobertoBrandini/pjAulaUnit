using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularAumento_Click(object sender, EventArgs e)
        {
            Decimal salarioT = 0.00m;
            Decimal.TryParse(txtSalarioAtual.Text, out salarioT);
            if (salarioT == 0)
            {
                lblResposta.Text = "RN.SAL.001 - Informe o Salario";
                return;
            } 

            Decimal SalarioAtual = Convert.ToDecimal(txtSalarioAtual.Text);
            Decimal Aumento = Convert.ToDecimal(txtAumento.Text);

            Decimal NovoSalario = Negocio.Calculo.AumentoSalario(SalarioAtual, Aumento);
            Decimal NovoSalario2 = Negocio.Calculo.AumentoSalario(SalarioAtual);

            lblResposta.Text = String.Format("Novo Salario : {0} ", NovoSalario);
            lblResultado2.Text = String.Format("Novo Salario : {0} ", NovoSalario2);
            //lblResposta.Text = "Novo Salario : " + NovoSalario.ToString();

        }
    }
}
