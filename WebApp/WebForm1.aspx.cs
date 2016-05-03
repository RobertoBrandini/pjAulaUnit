using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcularSalario_Click(object sender, EventArgs e)
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