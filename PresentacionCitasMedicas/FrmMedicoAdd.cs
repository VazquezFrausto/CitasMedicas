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

        void Fill()
        {
            txtNombre.Text = FrmMedicos.medico.Nombre;
            txtApellidoPaterno.Text = FrmMedicos.medico.Apellidopaterno;
            txtApellidoMaterno.Text = FrmMedicos.medico.Apellidomaterno;
            txtTelefono.Text = FrmMedicos.medico.Telefono;
            txtCorreo.Text = FrmMedicos.medico.Correo;
            cmbEspecialidad.SelectedValue = FrmMedicos.medico.Especialidad;
        }

        void Clean()
        {
            txtNombre.Clear();
            txtApellidoMaterno.Clear();
            txtApellidoPaterno.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            Clean();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                mm.Actualizar(new Medicos(id, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,
                txtTelefono.Text, txtCorreo.Text, cmbEspecialidad.SelectedItem.ToString()));
                Clean();
                Close();
            }
            else
            {
                mm.Guardar(new Medicos(id, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,
                txtTelefono.Text, txtCorreo.Text, cmbEspecialidad.SelectedItem.ToString()));
                Clean();
            }    
        }

        private void FrmMedicoAdd_Load(object sender, EventArgs e)
        {
            if (actualizar)
            {
                Fill();
            }
        }
    }
}
