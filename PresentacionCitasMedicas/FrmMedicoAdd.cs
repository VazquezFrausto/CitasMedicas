using System;
using System.Windows.Forms;
using ManejadoresCitasMedicas;
using EntidadesCitasMedicas;

namespace PresentacionCitasMedicas
{
    public partial class FrmMedicoAdd : Form
    {
        ManejadorMedico mm;
        bool actualizar;
        int id;

        public FrmMedicoAdd(bool actualizar, int id)
        {
            InitializeComponent();
            mm = new ManejadorMedico();
            this.id = id;
            this.actualizar = actualizar;
        }

        void Clean()
        {
            txtNombre.Clear();
            txtApellidoMaterno.Clear();
            txtApellidoPaterno.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();

            txtNombre.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                mm.Actualizar(new Medicos(id, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,
                txtTelefono.Text, txtCorreo.Text, cmbEspecialidad.SelectedItem.ToString()));
                Clean();
            }
            else
            {
                mm.Guardar(new Medicos(id, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,
                txtTelefono.Text, txtCorreo.Text, cmbEspecialidad.SelectedItem.ToString()));
                Clean();
            }    
        }
    }
}
