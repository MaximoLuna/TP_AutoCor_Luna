using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_AutoCor_Luna
{
    public partial class frmAutocor : Form
    {
        List<ClsRepuestos> listaRepuestos = new List<ClsRepuestos>();
        void LimpiarControles()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbMarca.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        public frmAutocor()
        {
            InitializeComponent();
        }

        private void frmAutocor_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsRepuestos objRepuesto = new ClsRepuestos();
            objRepuesto.Codigo = int.Parse(txtCodigo.Text);
            objRepuesto.Nombre = txtNombre.Text;
            objRepuesto.Marca = cmbMarca.Text;
            objRepuesto.Precio = int.Parse(txtPrecio.Text);
            if (optNacional.Checked)
            {
                objRepuesto.Origen = "Nacional";
            }
            else
            {
                objRepuesto.Origen = "Importado";
            }
            listaRepuestos.Add(objRepuesto);
            MessageBox.Show(objRepuesto.Consultar(), "Repuesto");
            LimpiarControles();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstRepuestos.Items.Clear();
            foreach (ClsRepuestos repuesto in listaRepuestos)
            {
                lstRepuestos.Items.Add(repuesto.Codigo + " " + repuesto.Nombre + " " + repuesto.Marca + " " + repuesto.Precio + " " + repuesto.Origen);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
