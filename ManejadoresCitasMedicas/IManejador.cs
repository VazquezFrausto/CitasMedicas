using System.Windows.Forms;

namespace ManejadoresCitasMedicas
{
    public interface IManejador
    {
        void Guardar(dynamic entidad);
        void Actualizar(dynamic entidad);
        void Borrar(dynamic entidad);
        void Mostrar(DataGridView tabla, string filtro);
        void Exportar(DataGridView tabla);
    }
}
