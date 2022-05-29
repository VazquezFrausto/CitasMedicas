using System;
using System.Drawing;
using System.Windows.Forms;
using Crud;
using EntidadesCitasMedicas;
using AccesoDatosCitasMedicas;


namespace ManejadoresCitasMedicas
{
    public class ManejadorMedico : IManejador
    {
        AccesoMedicos am = new AccesoMedicos();
        Grafico g = new Grafico();

        public void Actualizar(dynamic entidad)
        {
            am.Actualizar(entidad);
            g.Mensaje("Se ha actualizado correctamente", "Aviso", MessageBoxIcon.Information);
        }

        public void Borrar(dynamic entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Desea eliminar el médico {0} de la base de datos?",
                entidad.Nombre), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                am.Borrar(entidad);
            }
        }

        public void Exportar(DataGridView tabla)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic entidad)
        {
            am.Guardar(entidad);
            g.Mensaje("Se ha guardado correctamente", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = am.Mostrar(filtro).Tables["medico"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Eliminar", Color.Crimson));
            tabla.Columns[0].Visible = false;
            tabla.Columns[0].HeaderText = "ID";
            tabla.Columns[1].HeaderText = "Nombre";
            tabla.Columns[2].HeaderText = "Apellido paterno";
            tabla.Columns[3].HeaderText = "Apellido materno";
            tabla.Columns[4].HeaderText = "Telefono";
            tabla.Columns[5].HeaderText = "Correo";
            tabla.Columns[6].HeaderText = "Especialidad";
        }
    }
}
