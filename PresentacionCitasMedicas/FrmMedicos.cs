using System;
using System.Windows.Forms;
using ManejadoresCitasMedicas;
using EntidadesCitasMedicas;

namespace PresentacionCitasMedicas
{
    public partial class FrmMedicos : Form
    {
        ManejadorMedico mm;
        public static Medicos medico = new Medicos(0, "", "", "", "", "", "");

        public FrmMedicos()
        {
            InitializeComponent();
            mm = new ManejadorMedico();
        }

        void Refrescar()
        {
            mm.Mostrar(dtvMedicos, txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }   

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmMedicoAdd medicoAdd = new FrmMedicoAdd(false, 0);
            medicoAdd.ShowDialog();
            Refrescar();
        }

        private void dtvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 7:
                    {
                        FrmMedicoAdd medicoAdd = new FrmMedicoAdd(true, medico.Id);
                        medicoAdd.ShowDialog();
                        txtBuscar.Clear();
                        Refrescar();
                    } break;
                case 8:
                    {
                        mm.Borrar(medico);
                        txtBuscar.Clear();
                        Refrescar();
                    } break;
            } 
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void dtvMedicos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            medico.Id = int.Parse(dtvMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
            medico.Nombre = dtvMedicos.Rows[e.RowIndex].Cells[1].Value.ToString();
            medico.Apellidopaterno = dtvMedicos.Rows[e.RowIndex].Cells[2].Value.ToString();
            medico.Apellidomaterno = dtvMedicos.Rows[e.RowIndex].Cells[3].Value.ToString();
            medico.Telefono = dtvMedicos.Rows[e.RowIndex].Cells[4].Value.ToString();
            medico.Correo = dtvMedicos.Rows[e.RowIndex].Cells[5].Value.ToString();
            medico.Especialidad = dtvMedicos.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            mm.Exportar(dtvMedicos);
        }
    }
}
