using Consultorio.Clases;
using Consultorio.Forms;
using Formulario.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio

{
    public partial class frmLogin : Form
    {
        Usuarios miUsuario = new Usuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar usuario...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar clave...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
                return;
            }

            if (this.txtUsuario.Text == string.Empty && this.txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (miUsuario.validarUsuario(txtUsuario.Text, txtPassword.Text) > 0)
            {
                MessageBox.Show("Se ha logueado correctamente");
                frmInicio form = new frmInicio(txtUsuario.Text);
                form.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //comentario
    }

}
