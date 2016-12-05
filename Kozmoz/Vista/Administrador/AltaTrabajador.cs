﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using BussinesLayer.Administrador;
using BussinesLayer;
using Validaciones;

namespace Vista.Administrador
{
    public partial class AltaTrabajador : Form
    {
        private DepartamentoController funcion = new DepartamentoController();
        private TrabajadorController tabajador = new TrabajadorController();
        private trabajador dtotrabajador = new trabajador();
        private usuario dtousuario = new usuario();

        private String usuarios;

        public AltaTrabajador()
        {
            InitializeComponent();
        }
        public AltaTrabajador(String usuario)
        {
            InitializeComponent();
            this.usuarios = usuario;
        }

        private void AltaTrabajador_Load(object sender, EventArgs e)
        {
            muestraempresa();
        }
        private void muestraempresa()
        {
            cmbempresa.DataSource = funcion.muestraacombo();
            cmbempresa.DisplayMember = "nombre";
            cmbempresa.ValueMember = "id";
        }
        private void muestra_departamento(int id)
        {
            
            cmbdepartamento.DataSource = tabajador.muestra_departamento(id);
            cmbdepartamento.DisplayMember = "nombre";
            cmbdepartamento.ValueMember = "id";
        }

        private void cmbempresa_TextChanged(object sender, EventArgs e)
        {
            int id = cmbempresa.SelectedIndex + 1;
            muestra_departamento( id);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }
    }
}