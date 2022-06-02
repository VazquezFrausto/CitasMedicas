using System;
using System.Windows.Forms;
using ManejadoresCitasMedicas;
using EntidadesCitasMedicas;

namespace PresentacionCitasMedicas
{
    public partial class FrmCitas : Form
    {
        ManejadorCita mc;
        public static Citas cita = new Citas(0, 0, 0, "");

        public FrmCitas()
        {
            InitializeComponent();
            mc = new ManejadorCita();
        }

        void Refrescar()
        {
            mc.Mostrar(dgvCitas, txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCitaAdd citaAdd = new FrmCitaAdd(false, 0);
            citaAdd.ShowDialog();
            Refrescar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void dgvCitas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cita.Id = int.Parse(dgvCitas.Rows[e.RowIndex].Cells[0].Value.ToString());
            cita.Fecha = dgvCitas.Rows[e.RowIndex].Cells[1].Value.ToString();
            cita.Idmedico = int.Parse(dgvCitas.Rows[e.RowIndex].Cells[2].Value.ToString());
            cita.Idpaciente = int.Parse(dgvCitas.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 6:
                    {
                        FrmCitaAdd citaAdd = new FrmCitaAdd(true, cita.Id);
                        citaAdd.ShowDialog();
                        txtBuscar.Clear();
                        Refrescar();
                    } break;
                case 7:
                    {
                        mc.Borrar(cita);
                        txtBuscar.Clear();
                        Refrescar();
                    } break;
            }
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
