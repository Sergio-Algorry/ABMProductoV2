using ABMProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMProductoV2
{
    public partial class frmInicio : Form
    {
        private Producto produc = new Producto();
        public frmInicio()
        {
            InitializeComponent();

            lblSalida.Text = "";
        }

        #region Evento
        private void btCrear_Click(object sender, EventArgs e)
        {
            produc.Crear(txtCodigo.Text, txtNombre.Text, txtPrecio.Text);

            lblSalida.Text = ArmarSalida();
            LimpiaTxt();
        }
        #endregion

        #region Metodos
        private string ArmarSalida()
        {
            string salida = lblSalida.Text 
                            + "\r\n"
                            + produc.NombreCompleto();

            return salida;
        }

        private void LimpiaTxt()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();  
        }
        #endregion
    }
}
