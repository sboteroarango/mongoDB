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
    public partial class ProgramasAñadir : Form
    {
        public ProgramasAñadir()
        {
            InitializeComponent();
        }

        private void IrAñadirProgramas_Click_1(object sender, EventArgs e)
        {
            String infoPrograma = textBoxProgramasAñadir.Text;
            if (infoPrograma.Equals(""))
            {
                MessageBox.Show("debe colocar un valor");
            }
            else
            {
                bool flag = AccesoDatos.AñadirProgramas(infoPrograma);
                if (flag)
                {
                    MessageBox.Show("Programa añadido");
                }
                else
                {
                    MessageBox.Show("Este programa ya existe entonces no se puede añadir");
                }
            }


        }

        private void ProgramasAñadir_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProgramasAñadir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
