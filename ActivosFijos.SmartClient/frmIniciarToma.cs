using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Linq;

namespace ActivosFijos
{
    public partial class frmIniciarToma : Form
    {
        private Conexion mConexion = new Conexion();
        private ActivosFijosServiceClient cliente;
        private Parametro[] mUbicaciones;
        private Empleado[] mEmpleados;
        private Inventario mInventario;
        private string mUsuario;

        public frmIniciarToma(string _Usuario, Inventario _Inventario)
        {
            InitializeComponent();
            mInventario = _Inventario;
            mUsuario = _Usuario;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmTomaActivo f = new frmTomaActivo(mUsuario, mInventario, (Parametro)cboUbicacion.SelectedItem, (Empleado)cboCustodio.SelectedItem);
            f.ShowDialog();
        }

        private void frmIniciarToma_Load(object sender, EventArgs e)
        {
            cliente = mConexion.Cliente();
            try
            {
                mUbicaciones = cliente.ParametroTreeList(mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, 10079);
                mEmpleados = cliente.ListaEmpleados();

                cboUbicacion.Items.Clear();
                cboUbicacion.DataSource = mUbicaciones;
                cboUbicacion.DisplayMember = "Descripcion";
                cboUbicacion.ValueMember = "Pardet_Secuencia";

                cboCustodio.Items.Clear();
                cboCustodio.DataSource = mEmpleados;
                cboCustodio.DisplayMember = "NombreCompleto";
                cboCustodio.ValueMember = "Emplea_Custodio";

                this.btnSeleccionar.Enabled = true;
            }
            catch (Exception)
            {
                this.btnSeleccionar.Enabled = false;
            }
        }

        private void cboUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUbicacion.SelectedIndex < 0)
            {
                this.lblUbicacionCompleta.Text = "";
            }
            else
            {
                this.lblUbicacionCompleta.Text = ((Parametro)cboUbicacion.SelectedValue).Descripcion;
            }
        }
    }
}