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
    public partial class DepartamentosAñadir : Form
    {
        public DepartamentosAñadir()
        {
            InitializeComponent();
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            string departamento = textBoxDepartamento.Text;
            if (departamento.Equals(""))
            {
                MessageBox.Show("debe colocar un valor");
            }
            else
            {
                bool flag = AccesoDatos.AñadirDepartamento(departamento);
                if (flag)
                {
                    MessageBox.Show("Departamento añadido");
                }
                else
                {
                    MessageBox.Show("Este departamento ya existe entonces no se puede añadir");
                }
            }
        }
    }
}
