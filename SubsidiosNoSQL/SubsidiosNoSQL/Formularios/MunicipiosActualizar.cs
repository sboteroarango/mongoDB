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
    public partial class MunicipiosActualizar : Form
    {
        public MunicipiosActualizar()
        {
            InitializeComponent();
        }

        private void MunicipiosActualizar_Load(object sender, EventArgs e)
        {
            inicializaListBoxMunicipios();

        }

        private void inicializaListBoxMunicipios()
        {
            listBoxMunicipios.DataSource = null;
            listBoxMunicipios.DataSource = AccesoDatos.ObtenerListaMunicipios();
            listBoxMunicipios.DisplayMember = "municipio";
            listBoxMunicipios.SelectedIndex = 0;
        }

        private void IrActualizarProgramas_Click(object sender, EventArgs e)
        {
            String infoMunicipio = listBoxMunicipios.SelectedItem!.ToString()!;
            String actual = textBoxActualizarMunicipios.Text;
            if (actual.Equals(""))
            {
                MessageBox.Show("Debe colocar un valor");
            }
            else
            {
                AccesoDatos.ActualizarMunicipios(infoMunicipio, actual);
                MessageBox.Show("Actualización exitosa");
                inicializaListBoxMunicipios();
            }
        }

        private void textBoxActualizarMunicipios_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
