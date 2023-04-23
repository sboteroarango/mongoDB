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
    public partial class MunicipiosAñadir : Form
    {
        public MunicipiosAñadir()
        {
            InitializeComponent();
        }

        private void MunicipiosAñadir_Load(object sender, EventArgs e)
        {
            inicializarListBoxDepartamentos();
        }

        private void inicializarListBoxDepartamentos()
        {
            listBoxDepartamentos.DataSource = null;
            listBoxDepartamentos.DataSource = AccesoDatos.ObtenerListaDepartamentos();
            listBoxDepartamentos.DisplayMember = "municipio";
            listBoxDepartamentos.SelectedIndex = 0;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IrAñadirProgramas_Click(object sender, EventArgs e)
        {
            string municipio = textBoxMunicipiosAñadir.Text;
            string departamento = listBoxDepartamentos.SelectedItem!.ToString();
            string idMunicipio = textBoxIdMunicipio.Text;
            if (municipio.Equals("") || idMunicipio.Equals(""))
            {
                MessageBox.Show("debe colocar un valor");
            }
            else
            {
                bool flag = AccesoDatos.AñadirMunicipio(idMunicipio,municipio,departamento);
                if (flag)
                {
                    MessageBox.Show("Municipio añadido");
                }
                else
                {
                    MessageBox.Show("Este municipio ya existe entonces no se puede añadir");
                }
            }

        }
    }
}
