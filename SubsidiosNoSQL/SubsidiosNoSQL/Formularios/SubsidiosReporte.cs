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
    public partial class SubsidiosNoSQLReporte : Form
    {
        public SubsidiosNoSQLReporte()
        {
            InitializeComponent();
        }



        private void SubsidiosNoSQLReporte_Load(object sender, EventArgs e)
        {
            inicializaListBoxSubsidiosNoSQL();
        }

        private void inicializaListBoxSubsidiosNoSQL()
        {
            listBoxSubsidiosNoSQL.DataSource = null;
            listBoxSubsidiosNoSQL.DataSource = AccesoDatos.ObtenerListaSubsidiosNoSQL();
            listBoxSubsidiosNoSQL.DisplayMember = "ID";
            listBoxSubsidiosNoSQL.SelectedIndex = 0;
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            String infoSubsidio = listBoxSubsidiosNoSQL.SelectedItem!.ToString();
            textBoxMes.Text = AccesoDatos.ObtenerMes(infoSubsidio).ToString();
            textBoxAño.Text = AccesoDatos.ObtenerAño(infoSubsidio).ToString();
            textBoxPrograma.Text = AccesoDatos.ObtenerPrograma(infoSubsidio).ToString();
            textBoxCantidadBeneficiarios.Text = AccesoDatos.ObtenerCantidadBeneficiarios(infoSubsidio).ToString();
            textBoxValor.Text = AccesoDatos.ObtenerValor(infoSubsidio).ToString();
        }
    }
}
