using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsidiosNoSQL.Formularios
{
    public partial class BeneficiariosReporte : Form
    {
        public BeneficiariosReporte()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BeneficiariosReporte_Load(object sender, EventArgs e)
        {
            inicializarListaBeneficiarios();
        }

        private void inicializarListaBeneficiarios()
        {
            listBoxBeneficiarios.DataSource = null;
            listBoxBeneficiarios.DataSource = AccesoDatos.ObtenerListaBeneficiarios();
            listBoxBeneficiarios.DisplayMember = "id";
            listBoxBeneficiarios.SelectedIndex = 0;
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            string beneficiario = listBoxBeneficiarios.SelectedItem!.ToString();

            listBoxMeses.DataSource = AccesoDatos.ObtenerMesesBeneficiario(beneficiario);
            listBoxMeses.DisplayMember = "mes";
            listBoxAños.DataSource = AccesoDatos.ObtenerAñosBeneficiario(beneficiario);
            listBoxAños.DisplayMember = "año";
            listBoxProgramas.DataSource = AccesoDatos.ObtenerProgramasBeneficiario(beneficiario);
            listBoxProgramas.DisplayMember = "programa";
            textBoxValor.Text = AccesoDatos.ObtenerValorBeneficiario(beneficiario);
        }
    }
}
