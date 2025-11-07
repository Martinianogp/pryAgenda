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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
           
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             DateTime fechaVencimiento = dtpFecha.Value.Date.AddHours(12);

            try
            {
                Conexion db = new Conexion();
                db.AgregarActividad(
                    txtActividad.Text.Trim(),
                    fechaVencimiento,
                    txtObservacion.Text.Trim()
                );

                MessageBox.Show("Actividad registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la actividad: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
