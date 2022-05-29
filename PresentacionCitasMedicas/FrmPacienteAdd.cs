using System;
using System.Windows.Forms;
using ManejadoresCitasMedicas;
using EntidadesCitasMedicas;

namespace PresentacionCitasMedicas
{
    public partial class FrmPacienteAdd : Form
    {
        ManejadorPaciente mp;
        bool actualizar;
        int id;

        public FrmPacienteAdd(bool actualizar, int id)
        {            
            InitializeComponent();
            mp = new ManejadorPaciente();
            this.actualizar = actualizar;
            this.id = id;
        }

        void Clean()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtTelefono.Clear();
            txtPeso.Clear();
            txtEdad.Clear();
            txtEstatura.Clear();
            txtNombre.Focus();
        }

        void Fill()
        {
            txtNombre.Text = FrmPacientes.paciente.Nombre;
            txtApellidoPaterno.Text = FrmPacientes.paciente.Apellidopaterno;
            txtApellidoMaterno.Text = FrmPacientes.paciente.Apellidomaterno;
            txtEdad.Text = FrmPacientes.paciente.Edad.ToString();
            txtPeso.Text = FrmPacientes.paciente.Peso.ToString();
            txtEstatura.Text = FrmPacientes.paciente.Estatura.ToString();
            txtTelefono.Text = FrmPacientes.paciente.Telefono.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                mp.Actualizar(new Pacientes(id, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,
                    int.Parse(txtEdad.Text), int.Parse(txtPeso.Text), int.Parse(txtEstatura.Text), 
                    txtTelefono.Text));
                Clean();
                Close();
            }
            else
            {
                mp.Guardar(new Pacientes(id, txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,
                    int.Parse(txtEdad.Text), int.Parse(txtPeso.Text), int.Parse(txtEstatura.Text),
                    txtTelefono.Text));
                Clean();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
            Clean();
        }

        private void FrmPacienteAdd_Load(object sender, EventArgs e)
        {
            if (actualizar)
            {
                Fill();
            }
        }
    }
}
