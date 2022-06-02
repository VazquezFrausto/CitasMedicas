using System;
using System.Windows.Forms;
using ManejadoresCitasMedicas;
using EntidadesCitasMedicas;


namespace PresentacionCitasMedicas
{
    public partial class FrmCitaAdd : Form
    {
        bool actualizar;
        int id;
        ManejadorCita mc;

        public FrmCitaAdd(bool actualizar, int id)
        {
            InitializeComponent();
            this.actualizar = actualizar;
            this.id = id;
            mc = new ManejadorCita();
        }

        void Clean()
        {
            cmbMedico.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void FrmCitaAdd_Load(object sender, EventArgs e)
        {
            mc.ExtraerMedico(cmbMedico);
            mc.ExtraerPaciente(cmbPaciente);
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
                mc.Actualizar(new Citas(id, int.Parse(cmbMedico.SelectedValue.ToString()),
                    int.Parse(cmbPaciente.SelectedValue.ToString()), dtpFecha.Text));
                Clean();
                Close();
            }
            else
            {
                mc.Guardar(new Citas(id, int.Parse(cmbMedico.SelectedValue.ToString()),
                    int.Parse(cmbPaciente.SelectedValue.ToString()), dtpFecha.Text));
                Clean();
            }
        }
    }
}
