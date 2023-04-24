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
    public partial class SubsidiosReporte : Form
    {
        public SubsidiosReporte()
        {
            InitializeComponent();
        }



        private void SubsidiosReporte_Load(object sender, EventArgs e)
        {
            inicializaListBoxSubsidios();
        }

        private void inicializaListBoxSubsidios()
        {
            listBoxSubsidios.DataSource = null;
            listBoxSubsidios.DataSource = AccesoDatos.ObtenerListaSubsidios();
            listBoxSubsidios.DisplayMember = "ID";
            listBoxSubsidios.SelectedIndex = 0;
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            String infoSubsidio = listBoxSubsidios.SelectedItem!.ToString();
            textBoxMes.Text = AccesoDatos.ObtenerMes(infoSubsidio).ToString();
            textBoxAño.Text = AccesoDatos.ObtenerAño(infoSubsidio).ToString();
            textBoxPrograma.Text = AccesoDatos.ObtenerPrograma(infoSubsidio).ToString();
            textBoxCantidadBeneficiarios.Text = AccesoDatos.ObtenerCantidadBeneficiarios(infoSubsidio).ToString();
            textBoxValor.Text = AccesoDatos.ObtenerValor(infoSubsidio).ToString();
        }
    }
}
