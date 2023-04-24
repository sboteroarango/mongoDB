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
    public partial class SubsidiosBorrar : Form
    {
        public SubsidiosBorrar()
        {
            InitializeComponent();
        }

        private void SubsidiosBorrar_Load(object sender, EventArgs e)
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

        private void Borrar_Click(object sender, EventArgs e)
        {
            string idSubsidio = listBoxSubsidios.SelectedItem!.ToString();
            MessageBox.Show("Borrado Exitoso");
            AccesoDatos.BorrarSubsidio(idSubsidio);
            inicializaListBoxSubsidios();
        }
    }
}
