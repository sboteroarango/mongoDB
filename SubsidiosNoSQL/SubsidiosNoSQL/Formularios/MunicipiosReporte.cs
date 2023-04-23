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
    public partial class MunicipiosReporte : Form
    {
        public MunicipiosReporte()
        {
            InitializeComponent();
            inicializaListBoxAñoProgramas();
            inicializaListBoxMesProgramas();
            inicializaListBoxMunicipios();
            inicializaListBoxProgramaProgramas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void IrProgramas_Click(object sender, EventArgs e)
        {
            int infoMes = Convert.ToInt32(listBoxMesProgramas.SelectedItem!);
            int infoAño = Convert.ToInt32(listBoxAñoProgramas.SelectedItem!.ToString()!);
            String infoMunicipio = listBoxMunicipios.SelectedItem!.ToString()!;
            String infoPrograma = listBoxProgramaProgramas.SelectedItem!.ToString()!;
            textBoxCantidadBeneficiariosProgramas.Text = AccesoDatos.ObtenerCantidadBeneficiarios2(infoPrograma, infoMes, infoAño, infoMunicipio).ToString();
            textBoxValorProgramas.Text = AccesoDatos.ObtenerValor2(infoPrograma, infoMes, infoAño, infoMunicipio).ToString();
        }

        private void listBoxMesProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxAñoProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBoxDepartamentosProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBoxProgramaProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MunicipiosReporte_Load(object sender, EventArgs e)
        {

        }

        private void inicializaListBoxMunicipios()
        {
            listBoxMunicipios.DataSource = null;
            listBoxMunicipios.DataSource = AccesoDatos.ObtenerListaMunicipios();
            listBoxMunicipios.DisplayMember = "municipio";
            listBoxMunicipios.SelectedIndex = 0;
        }

        private void inicializaListBoxMesProgramas()
        {
            listBoxMesProgramas.DataSource = null;
            listBoxMesProgramas.DataSource = AccesoDatos.ObtenerListaMeses();
            listBoxMesProgramas.DisplayMember = "mes";
            listBoxMesProgramas.SelectedIndex = 0;
        }

        private void inicializaListBoxAñoProgramas()
        {
            listBoxAñoProgramas.DataSource = null;
            listBoxAñoProgramas.DataSource = AccesoDatos.ObtenerListaAño();
            listBoxAñoProgramas.DisplayMember = "año";
            listBoxAñoProgramas.SelectedIndex = 0;
        }

        private void inicializaListBoxProgramaProgramas()
        {
            listBoxProgramaProgramas.DataSource = null;
            listBoxProgramaProgramas.DataSource = AccesoDatos.ObtenerListaProgramas();
            listBoxProgramaProgramas.DisplayMember = "Programa";
            listBoxProgramaProgramas.SelectedIndex = 0;
        }
    }
}