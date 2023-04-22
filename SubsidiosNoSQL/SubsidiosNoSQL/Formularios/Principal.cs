using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubsidiosNoSQL.Formularios
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void listBoxIdentidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load_1(object sender, EventArgs e)
        {

        }


        private void Ir_Click(object sender, EventArgs e)
        {
            String infoIdentidad = listBoxIdentidades.SelectedItem!.ToString()!;
            String infoAcciones = listBoxAcciones.SelectedItem!.ToString()!;
            if (infoIdentidad.Equals("Programas") & infoAcciones.Equals("Reporte"))
            {
                ProgramasReporte abrir = new ProgramasReporte();

                abrir.Show();
            }
            //if (infoIdentidad.Equals("Programas") & infoAcciones.Equals("Actualizar"))
            //{
            //    ProgramasActualizar abrir = new ProgramasActualizar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Programas") & infoAcciones.Equals("Borrar"))
            //{
            //    ProgramasBorrar abrir = new ProgramasBorrar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Programas") & infoAcciones.Equals("Añadir"))
            //{
            //    ProgramasAñadir abrir = new ProgramasAñadir();
            //    abrir.Show();
            //}
            //if (infoIdentidad.Equals("SubsidiosNoSQL") & infoAcciones.Equals("Reporte"))
            //{
            //    SubsidiosNoSQLReporte abrir = new SubsidiosNoSQLReporte();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("SubsidiosNoSQL") & infoAcciones.Equals("Actualizar"))
            //{
            //    SubsidiosNoSQLActualizar abrir = new SubsidiosNoSQLActualizar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("SubsidiosNoSQL") & infoAcciones.Equals("Borrar"))
            //{
            //    SubsidiosNoSQLBorrar abrir = new SubsidiosNoSQLBorrar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("SubsidiosNoSQL") & infoAcciones.Equals("Añadir"))
            //{
            //    SubsidiosNoSQLAñadir abrir = new SubsidiosNoSQLAñadir();
            //    abrir.Show();
            //}
            //if (infoIdentidad.Equals("Beneficiarios") & infoAcciones.Equals("Reporte"))
            //{
            //    BeneficiariosReporte abrir = new BeneficiariosReporte();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Beneficiarios") & infoAcciones.Equals("Actualizar"))
            //{
            //    BeneficiariosActualizar abrir = new BeneficiariosActualizar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Beneficiarios") & infoAcciones.Equals("Borrar"))
            //{
            //    BeneficiariosBorrar abrir = new BeneficiariosBorrar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Beneficiarios") & infoAcciones.Equals("Añadir"))
            //{
            //    BeneficiariosAñadir abrir = new BeneficiariosAñadir();
            //    abrir.Show();
            //}
            //if (infoIdentidad.Equals("Municipios") & infoAcciones.Equals("Reporte"))
            //{
            //    MunicipiosReporte abrir = new MunicipiosReporte();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Municipios") & infoAcciones.Equals("Actualizar"))
            //{
            //    MunicipiosActualizar abrir = new MunicipiosActualizar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Municipios") & infoAcciones.Equals("Borrar"))
            //{
            //    MunicipiosBorrar abrir = new MunicipiosBorrar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Municipios") & infoAcciones.Equals("Añadir"))
            //{
            //    MunicipiosAñadir abrir = new MunicipiosAñadir();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Departamentos") & infoAcciones.Equals("Reporte"))
            //{
            //    ProgramasReporte abrir = new ProgramasReporte();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Departamentos") & infoAcciones.Equals("Actualizar"))
            //{
            //    DepartamentosActualizar abrir = new DepartamentosActualizar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Departamentos") & infoAcciones.Equals("Borrar"))
            //{
            //    DepartamentosBorrar abrir = new DepartamentosBorrar();
            //    abrir.Show();
            //}

            //if (infoIdentidad.Equals("Departamentos") & infoAcciones.Equals("Añadir"))
            //{
            //    DepartamentosAñadir abrir = new DepartamentosAñadir();
            //    abrir.Show();
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
