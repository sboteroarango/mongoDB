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
    public partial class SubsidiosNoSQLAñadir : Form
    {
        public SubsidiosNoSQLAñadir()
        {
            InitializeComponent();
        }

        private void SubsidiosNoSQLAñadir_Load(object sender, EventArgs e)
        {
            inicializaListBoxAños();
            inicializaListBoxProgramas();
            inicializaListBoxMeses();
            inicializaListBoxBeneficiarios();

        }


        private void inicializaListBoxMeses()
        {
            listBoxMeses.DataSource = null;
            listBoxMeses.DataSource = AccesoDatos.ObtenerListaMeses();
            listBoxMeses.DisplayMember = "mes";
            listBoxMeses.SelectedIndex = 0;
        }

        private void inicializaListBoxAños()
        {
            listBoxAños.DataSource = null;
            listBoxAños.DataSource = AccesoDatos.ObtenerListaAño();
            listBoxAños.DisplayMember = "año";
            listBoxAños.SelectedIndex = 0;
        }

        private void inicializaListBoxProgramas()
        {
            listBoxProgramas.DataSource = null;
            listBoxProgramas.DataSource = AccesoDatos.ObtenerListaProgramas();
            listBoxProgramas.DisplayMember = "nombre";
            listBoxProgramas.SelectedIndex = 0;
        }

        private void inicializaListBoxBeneficiarios()
        {
            listBoxBeneficiarios.DataSource = null;
            listBoxBeneficiarios.DataSource = AccesoDatos.ObtenerListaBeneficiarios();
            listBoxBeneficiarios.DisplayMember = "id";
            listBoxBeneficiarios.SelectedIndex = 0;
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            String infoPrograma = listBoxProgramas.SelectedItem!.ToString()!;
            String año = listBoxAños.SelectedItem!.ToString()!;
            String mes = listBoxMeses.SelectedItem!.ToString()!;
            String valor = textBoxValor.Text;
            String beneficiario = listBoxBeneficiarios.SelectedItem!.ToString()!;
            if (valor.Equals(""))
            {
                MessageBox.Show("Debe colocar un valor");
            }
            else { 
            AccesoDatos.AñadirSubsidiosNoSQL(infoPrograma, año, mes, valor, beneficiario);
            MessageBox.Show("Subsidio añadido");
            }
            
        }
    }
}
