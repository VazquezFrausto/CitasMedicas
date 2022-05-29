using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoDatosCitasMedicas;
using EntidadesCitasMedicas;
using Crud;

namespace ManejadoresCitasMedicas
{
    public class ManejadorPaciente : IManejador
    {
        AccesoPacientes ap = new AccesoPacientes();
        Grafico g = new Grafico();


        public void Actualizar(dynamic entidad)
        {
            ap.Actualizar(entidad);
            g.Mensaje("Se ha actualizado correctamente", "Aviso", MessageBoxIcon.Information);
        }

        public void Borrar(dynamic entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Desea eliminar el paciente {0} de la base de datos?",
                entidad.Nombre), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ap.Borrar(entidad);
            }
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic entidad)
        {
            ap.Guardar(entidad);
            g.Mensaje("Se ha guardado correctamente", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["paciente"];
            tabla.Columns.Insert(8, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(9, g.Boton("Eliminar", Color.Crimson));
            tabla.Columns[0].Visible = false;
            tabla.Columns[0].HeaderText = "ID";
            tabla.Columns[1].HeaderText = "Nombre";
            tabla.Columns[2].HeaderText = "Apellido paterno";
            tabla.Columns[3].HeaderText = "Apellido materno";
            tabla.Columns[4].HeaderText = "Edad";
            tabla.Columns[5].HeaderText = "Peso";
            tabla.Columns[6].HeaderText = "Estatura";
            tabla.Columns[7].HeaderText = "Telefono";
        }
    }
}
