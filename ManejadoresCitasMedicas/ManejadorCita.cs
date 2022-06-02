using System;
using System.Windows.Forms;
using AccesoDatosCitasMedicas;
using EntidadesCitasMedicas;
using Crud;
using System.Drawing;

namespace ManejadoresCitasMedicas
{
    public class ManejadorCita : IManejador
    {
        AccesoCitas ac = new AccesoCitas();
        AccesoMedicos am = new AccesoMedicos();
        AccesoPacientes ap = new AccesoPacientes();
        Grafico g = new Grafico();

        public void Actualizar(dynamic entidad)
        {
            ac.Actualizar(entidad);
            g.Mensaje("Se ha actualizado correctamente", "Aviso", MessageBoxIcon.Information);
        }

        public void Borrar(dynamic entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Desea eliminar la cita de la base de datos?"), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ac.Borrar(entidad);
            }
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic entidad)
        {
            ac.Guardar(entidad);
            g.Mensaje("Se ha guardado correctamente", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ac.Mostrar(filtro).Tables["cita"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(7, g.Boton("Eliminar", Color.Crimson));
            tabla.Columns[0].Visible = false;
            tabla.Columns[0].HeaderText = "ID";
            tabla.Columns[1].HeaderText = "Fecha";
            tabla.Columns[2].HeaderText = "ID Medico";
            tabla.Columns[3].HeaderText = "Medico";
            tabla.Columns[4].HeaderText = "ID Paciente";
            tabla.Columns[5].HeaderText = "Paciente";
        }

        public void ExtraerMedico(ComboBox cmbMedicos)
        {
            cmbMedicos.DataSource = am.Mostrar("").Tables["medico"];
            cmbMedicos.DisplayMember = "nombre";
            cmbMedicos.ValueMember = "id";
        }

        public void ExtraerPaciente(ComboBox cmbPacientes)
        {
            cmbPacientes.DataSource = ap.Mostrar("").Tables["paciente"];
            cmbPacientes.DisplayMember = "nombre";
            cmbPacientes.ValueMember = "id";
        }
    }
}
