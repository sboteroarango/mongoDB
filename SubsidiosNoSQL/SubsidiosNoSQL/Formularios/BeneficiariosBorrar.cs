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
    public partial class BeneficiariosBorrar : Form
    {
        public BeneficiariosBorrar()
        {
            InitializeComponent();
        }

        private void BeneficiariosBorrar_Load(object sender, EventArgs e)
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

        private void Ir_Click(object sender, EventArgs e)
        {
            string beneficiario = listBoxBeneficiarios.SelectedItem!.ToString()!;
            bool succ = AccesoDatos.BorrarBeneficiario(beneficiario);
            if (succ)
            {
                MessageBox.Show("borrado exitoso");
                inicializarListBoxBeneficiarios();
            }
            else
            {
                MessageBox.Show("no se puede borrar el beneficiario porque tiene SubsidiosNoSQL asociados");
            }
        }
    }
}
