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
    public partial class ProgramasReporte : Form
    {
        public ProgramasReporte()
        {
            InitializeComponent();
        }

        private void ProgramasReporte_Load(object sender, EventArgs e)
        {
            inicializaListBoxDepartamentosProgramas();
            inicializaListBoxMesProgramas();
            inicializaListBoxAñoProgramas();
            inicializaListBoxProgramaProgramas();

        }
        private void inicializaListBoxDepartamentosProgramas()
        {
            listBoxDepartamentosProgramas.DataSource = null;
            listBoxDepartamentosProgramas.DataSource = AccesoDatos.ObtenerListaDepartamentos();
            listBoxDepartamentosProgramas.DisplayMember = "nombredepartamento";
            listBoxDepartamentosProgramas.SelectedIndex = 0;
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IrProgramas_Click(object sender, EventArgs e)
        {
            int infoMes = Convert.ToInt32(listBoxMesProgramas.SelectedItem!);
            int infoAño = Convert.ToInt32(listBoxAñoProgramas.SelectedItem!.ToString()!);
            String infoDepartamento = listBoxDepartamentosProgramas.SelectedItem!.ToString()!;
            String infoPrograma = listBoxProgramaProgramas.SelectedItem!.ToString()!;
            textBoxCantidadBeneficiariosProgramas.Text = AccesoDatos.ObtenerCantidadBeneficiarios(infoPrograma, infoMes, infoAño, infoDepartamento).ToString();
            textBoxValorProgramas.Text = AccesoDatos.ObtenerValor(infoPrograma, infoMes, infoAño, infoDepartamento).ToString();
        }
    }
}
