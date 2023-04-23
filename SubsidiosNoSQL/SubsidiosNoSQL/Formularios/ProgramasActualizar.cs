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
    public partial class ProgramasActualizar : Form
    {
        public ProgramasActualizar()
        {
            InitializeComponent();
        }

        private void ProgramasActualizar_Load(object sender, EventArgs e)
        {
            inicializarListBoxProgramasActualizar();
        }

        private void inicializarListBoxProgramasActualizar()
        {
            listBoxProgramasActualizar.DataSource = null;
            listBoxProgramasActualizar.DataSource = AccesoDatos.ObtenerListaProgramas();
            listBoxProgramasActualizar.DisplayMember = "Programa";
            listBoxProgramasActualizar.SelectedIndex = 0;
        }

        private void IrActualizarProgramas_Click(object sender, EventArgs e)
        {


            String infoPrograma = listBoxProgramasActualizar.SelectedItem!.ToString()!;
            String actual = textBoxActualizarProgramas.Text;
            if (actual.Equals(""))
            {
                MessageBox.Show("Debe colocar un valor");
            }
            else
            {
                AccesoDatos.ActualizarProgramas(infoPrograma, actual);
                MessageBox.Show("Actualización exitosa");
                inicializarListBoxProgramasActualizar();
            }

        }

        private void textBoxActualizarProgramas_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxProgramasActualizar_SelectedIndexChanged(object sender, EventArgs e)
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
