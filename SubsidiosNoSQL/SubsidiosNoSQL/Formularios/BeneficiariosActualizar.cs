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
    public partial class BeneficiariosActualizar : Form
    {
        public BeneficiariosActualizar()
        {
            InitializeComponent();
        }

        private void BeneficiariosActualizar_Load(object sender, EventArgs e)
        {
            inicializarListBoxBeneficiarios();

        }
        private void inicializarListBoxBeneficiarios()
        {
            listBoxBeneficiarios.DataSource = null;
            listBoxBeneficiarios.DataSource = AccesoDatos.ObtenerListaBeneficiarios();
            listBoxBeneficiarios.DisplayMember = "id";
            listBoxBeneficiarios.SelectedIndex = 0;
        }

        private void IrActualizarProgramas_Click(object sender, EventArgs e)
        {
            string infoBeneficiario = listBoxBeneficiarios.SelectedItem!.ToString()!;
            string actual = textBoxActualizar.Text;
            bool existeBeneficiario = AccesoDatos.ExisteBeneficiario(actual);
            if (actual.Equals(""))
            {
                MessageBox.Show("Debe colocar un valor");
            }
            else {
                if (existeBeneficiario)
                {
                    MessageBox.Show("el beneficiario de actualización ya existe");
                }
                else
                {
                    
                    AccesoDatos.ActualizarBeneficiarios(infoBeneficiario, actual);
                    MessageBox.Show("Actualización exitosa");
                    inicializarListBoxBeneficiarios();
                    
                }
            
            
            }
            
        }
    }
}
