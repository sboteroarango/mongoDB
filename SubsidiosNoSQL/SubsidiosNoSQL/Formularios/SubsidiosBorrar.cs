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
    public partial class SubsidiosNoSQLBorrar : Form
    {
        public SubsidiosNoSQLBorrar()
        {
            InitializeComponent();
        }

        private void SubsidiosNoSQLBorrar_Load(object sender, EventArgs e)
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

        private void Borrar_Click(object sender, EventArgs e)
        {
            string idSubsidio = listBoxSubsidiosNoSQL.SelectedItem!.ToString();
            MessageBox.Show("Borrado Exitoso");
            AccesoDatos.BorrarSubsidio(idSubsidio);
            inicializaListBoxSubsidiosNoSQL();
        }
    }
}
