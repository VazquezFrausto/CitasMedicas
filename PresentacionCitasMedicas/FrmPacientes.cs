using System;
using System.Windows.Forms;
using ManejadoresCitasMedicas;
using EntidadesCitasMedicas;

namespace PresentacionCitasMedicas
{
    public partial class FrmPacientes : Form
    {
        ManejadorPaciente mp;
        public static Pacientes paciente = new Pacientes(0, "", "", "", 0, 0, 0, ""); 
        public FrmPacientes()
        {
            InitializeComponent();
            mp = new ManejadorPaciente();
        }

        void Refrescar()
        {
            mp.Mostrar(dtvPacientes, txtBuscar.Text);
        }

        private void dtvMedicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            paciente.Id = int.Parse(dtvPacientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            paciente.Nombre = dtvPacientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            paciente.Apellidopaterno = dtvPacientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            paciente.Apellidomaterno = dtvPacientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            paciente.Edad = int.Parse(dtvPacientes.Rows[e.RowIndex].Cells[4].Value.ToString());
            paciente.Peso = int.Parse(dtvPacientes.Rows[e.RowIndex].Cells[5].Value.ToString());
            paciente.Estatura = int.Parse(dtvPacientes.Rows[e.RowIndex].Cells[6].Value.ToString());
            paciente.Telefono = dtvPacientes.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPacienteAdd pacienteAdd = new FrmPacienteAdd(false, 0);
            pacienteAdd.ShowDialog();
            Refrescar();
        }

        private void dtvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 8:
                    {
                        FrmPacienteAdd pacienteAdd = new FrmPacienteAdd(true, paciente.Id);
                        pacienteAdd.ShowDialog();
                        txtBuscar.Clear();
                        Refrescar();
                    } break;
                case 9:
                    {
                        mp.Borrar(paciente);
                        txtBuscar.Clear();
                        Refrescar();
                    } break;
            }
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
