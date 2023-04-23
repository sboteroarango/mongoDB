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
    public partial class DepartamentosActualizar : Form
    {
        public DepartamentosActualizar()
        {
            InitializeComponent();
        }

        private void DepartamentosActualizar_Load(object sender, EventArgs e)
        {
            inicializarListBoxDepartamentos();
        }
        private void inicializarListBoxDepartamentos()
        {
            listBoxDepartamentos.DataSource = null;
            listBoxDepartamentos.DataSource = AccesoDatos.ObtenerListaDepartamentos();
            listBoxDepartamentos.DisplayMember = "NOMBREDEPARTAMENTO";
            listBoxDepartamentos.SelectedIndex = 0;
        }

        private void IrActualizarDepartamentos_Click(object sender, EventArgs e)
        {
            String infoDepartamentos = listBoxDepartamentos.SelectedItem!.ToString()!;
            String actual = textBoxActualizarDepartamentos.Text;
            if (actual.Equals(""))
            {
                MessageBox.Show("Debe colocar un valor");
            }
            else
            {
                AccesoDatos.ActualizarDepartamentos(infoDepartamentos, actual);
                MessageBox.Show("Actualización exitosa");
                inicializarListBoxDepartamentos();
            }
        }
    }
}
