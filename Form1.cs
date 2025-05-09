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
    public partial class Form1 : Form
    {
        private List<Usuario> listaUsuarios;
        private RepositorioUsuario  repoUsuario = new RepositorioUsuario();
        private List<Tareas> listaTareas;
        private RepositorioTareas repoTrarea = new RepositorioTareas();
        private RepositorioTareaxUsuario repoTareaUsuario = new RepositorioTareaxUsuario();
        private List<TareasPorUsuario> listaTareasPorUsuario;



        public Form1()
        {
            InitializeComponent();
            listaUsuarios = repoUsuario.obtenerTodosLosUsuarios();
            listaTareas = repoTrarea.obtenerTodosLasTareas();
            listaTareasPorUsuario = repoTareaUsuario.obtenerTareasPorUsuario();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarTareas();
            CargarPanelTareas();
            
           
            
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string tarea = cmbTareaUsuario.Text;
            string usuario = cmbUsuario.Text; 
           
            var usuarioSeleccionado = cmbUsuario.SelectedItem as Usuario;
            var tareaSeleccionada = cmbTareaUsuario.SelectedItem as Tareas;

           
            MessageBox.Show($"Tarea: {tarea}" + "  " + $"asignada a: {usuario}");
            repoTareaUsuario.Asignar(usuarioSeleccionado, tareaSeleccionada);
        }

        private void CargarUsuarios()
        {
           
        cmbUsuario.DataSource = listaUsuarios;
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "IdUsuario";

            cmbFiltroUsuario.DataSource = listaUsuarios;
            cmbFiltroUsuario.DisplayMember = "NombreCompleto";
            cmbFiltroUsuario.ValueMember = "IdUsuario";
        }

        private void CargarTareas()
        {
            cmbTareaUsuario.DataSource = listaTareas;
            cmbTareaUsuario.DisplayMember = "NombreTarea";  
            cmbTareaUsuario.ValueMember = "IdTarea";        

            cmbFiltroTarea.DataSource = listaTareas;
            cmbFiltroTarea.DisplayMember = "NombreTarea";
            cmbFiltroTarea.ValueMember = "IdTarea";

        }

        public void CargarPanelTareas()
        {
            dgvPanelTareas.DataSource = null;
            dgvPanelTareas.DataSource = listaTareasPorUsuario;
            
        }

      
    }
}
