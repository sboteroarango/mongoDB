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
    public partial class SubsidiosActualizar : Form
    {
        public SubsidiosActualizar()
        {
            InitializeComponent();
        }

        private void SubsidiosActualizar_Load(object sender, EventArgs e)
        {
            inicializaListBoxSubsidios();
            inicializaListBoxAños();
            inicializaListBoxProgramas();
            inicializaListBoxMeses();
            inicializaListBoxBeneficiarios();
        }



        private void inicializaListBoxSubsidios()
        {
            listBoxSubsidios.DataSource = null;
            listBoxSubsidios.DataSource = AccesoDatos.ObtenerListaSubsidios();
            listBoxSubsidios.DisplayMember = "ID";
            listBoxSubsidios.SelectedIndex = 0;
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

        private void Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click_1(object sender, EventArgs e)
        {
            String infoPrograma = listBoxProgramas.SelectedItem!.ToString()!;
            String año = listBoxAños.SelectedItem!.ToString()!;
            String mes = listBoxMeses.SelectedItem!.ToString()!;
            String id = listBoxSubsidios.SelectedItem!.ToString()!;
            String valor = textBoxValor.Text;
            String beneficiario = listBoxBeneficiarios.SelectedItem!.ToString()!;
            if (valor.Equals(""))
            {
                MessageBox.Show("debe colocar un valor");
            }
            else
            {
                AccesoDatos.ActualizarSubsidios(infoPrograma, año, mes, id, valor, beneficiario);
                MessageBox.Show("Actualización exitosa");

            }


        }
    }
}
