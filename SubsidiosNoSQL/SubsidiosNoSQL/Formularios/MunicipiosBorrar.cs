﻿using System;
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
    public partial class MunicipiosBorrar : Form
    {
        public MunicipiosBorrar()
        {
            InitializeComponent();
        }

        private void listBoxProgramasBorrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MunicipiosBorrar_Load(object sender, EventArgs e)
        {
            inicializaListBoxMunicipios();
        }

        private void inicializaListBoxMunicipios()
        {
            listBoxMunicipios.DataSource = null;
            listBoxMunicipios.DataSource = AccesoDatos.ObtenerListaMunicipios();
            listBoxMunicipios.DisplayMember = "municipio";
            listBoxMunicipios.SelectedIndex = 0;
        }

        private void IrProgramasBorrar_Click(object sender, EventArgs e)
        {
            string municipio = listBoxMunicipios.SelectedItem!.ToString();
            bool succ = AccesoDatos.BorrarMunicipio(municipio);
            if (succ)
            {
                MessageBox.Show("borrado exitoso");
                inicializaListBoxMunicipios();
            }
            else
            {
                MessageBox.Show("No se puede borrar porque ya se han hecho Subsidios con este municipio");
            }

        }
    }
}
