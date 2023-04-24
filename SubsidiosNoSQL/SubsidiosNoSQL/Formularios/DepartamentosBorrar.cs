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
    public partial class DepartamentosBorrar : Form
    {
        public DepartamentosBorrar()
        {
            InitializeComponent();
        }

        private void DepartamentosBorrar_Load(object sender, EventArgs e)
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

        private void IrDepartamentosBorrar_Click(object sender, EventArgs e)
        {
            string departamento = listBoxDepartamentos.SelectedItem!.ToString();
            bool succ = AccesoDatos.BorrarDepartamento(departamento);
            if (succ)
            {
                MessageBox.Show("borrado exitoso");
                inicializarListBoxDepartamentos();
            }
            else
            {
                MessageBox.Show("No se puede borrar porque ya se han hecho Subsidios con este departamento");
            }
        }
    }
}
