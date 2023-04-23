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
    public partial class BeneficiariosAñadir : Form
    {
        public BeneficiariosAñadir()
        {
            InitializeComponent();
        }

        private void BeneficiariosAñadir_Load(object sender, EventArgs e)
        {
            inicializarListBoxMunicipios();
        }
        private void inicializarListBoxMunicipios()
        {
            listBoxMunicipios.DataSource = null;
            listBoxMunicipios.DataSource = AccesoDatos.ObtenerListaMunicipios();
            listBoxMunicipios.DisplayMember = "nombre";
            listBoxMunicipios.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string municipio = listBoxMunicipios.SelectedItem!.ToString()!;
            string idBeneficiario = textBoxBeneficiario.Text!;
            if (idBeneficiario.Equals(""))
            {
                MessageBox.Show("debe colocar un valor");
            }
            else {
                bool succ = AccesoDatos.AñadirBeneficiarios(idBeneficiario, municipio);
                if (succ)
                {
                    MessageBox.Show("añadido exitoso");

                }
                else
                {
                    MessageBox.Show("no se puede añadir este beneficiario porque ya existe");
                }
            }
            
        }
    }
}
