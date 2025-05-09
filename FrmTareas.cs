using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio3_gestion_tareas
{
    public partial class FrmTareas : Form
    {
       RepositorioTareas repositorioTareas = new RepositorioTareas();
        public FrmTareas()
        {
            InitializeComponent();
        }

      

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             try
                {




                Tareas nuevaTarea = new Tareas()
                {
                    NombreTarea = txtTarea.Text,
                    CategoriaTarea = txtCategoria.Text,
                    DescripcionTarea = txtDescripcion.Text,
                    PrioridadTarea = cmbPrioridadTarea.Text,
                    VencimientoTarea = DateTime.Parse(dataTimeVencimiento.Text)

                };

             


              repositorioTareas.GuardarTarea(nuevaTarea);
                    MessageBox.Show("Tarea guardadada correctamente.");
                    


                }

                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);

                }
            }
        }
    }

