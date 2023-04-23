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
    public partial class ProgramasBorrar : Form
    {
        public ProgramasBorrar()
        {
            InitializeComponent();
        }

        private void ProgramasBorrar_Load(object sender, EventArgs e)
        {
            inicializarListBoxProgramasBorrar();
        }

        private void inicializarListBoxProgramasBorrar()
        {
            listBoxProgramasBorrar.DataSource = null;
            listBoxProgramasBorrar.DataSource = AccesoDatos.ObtenerListaProgramas();
            listBoxProgramasBorrar.DisplayMember = "Programa";
            listBoxProgramasBorrar.SelectedIndex = 0;
        }

        private void IrProgramasBorrar_Click(object sender, EventArgs e)
        {
            String infoPrograma = listBoxProgramasBorrar.SelectedItem!.ToString()!;
            bool succ = AccesoDatos.BorrarPrograma(infoPrograma);
            if (succ)
            {
                MessageBox.Show("borrado exitoso");
                inicializarListBoxProgramasBorrar();
            }
            else
            {
                MessageBox.Show("No se puede borrar porque ya se han hecho SubsidiosNoSQL con este programa");
            }
        }

        private void listBoxProgramasBorrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
