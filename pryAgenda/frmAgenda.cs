using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgenda
{
    public partial class frmAgenda : Form
    {
        private Conexion db = new Conexion();
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmInicio formulario = new frmInicio();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                CargarGrilla();
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAgenda.SelectedRows.Count > 0)
            {
                int idActividad = Convert.ToInt32(dgvAgenda.SelectedRows[0].Cells["IdActividad"].Value);
                string asunto = dgvAgenda.SelectedRows[0].Cells["Asunto"].Value.ToString();

                try
                {
                    db.EliminarActividad(idActividad);
                    MessageBox.Show("Actividad eliminada.", "Éxito");
                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de Eliminación");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila completa para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarGrilla()
        {
            try
            {
                dgvAgenda.DataSource = db.ObtenerActividades();

                if (dgvAgenda.Columns.Contains("IdActividad"))
                {
                    dgvAgenda.Columns["IdActividad"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Conexión o Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
