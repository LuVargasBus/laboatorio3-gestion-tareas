using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio3_gestion_tareas
{
    public partial class FrmCargaUsuarios : Form
    {
        private RepositorioUsuario repositorioUsuario = new RepositorioUsuario();
        public FrmCargaUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    NombreUsuario = txtNombre.Text,
                    ApellidoUsuario = txtApellido.Text,
                    RolUsuario = cmbRol.Text,

                };
                repositorioUsuario.GuardarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario guardado exitosamente"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
