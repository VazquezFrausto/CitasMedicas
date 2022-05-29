using System.Data;

namespace AccesoDatosCitasMedicas
{
    public interface IEntidades
    {
        void Guardar(dynamic entidad);
        void Borrar(dynamic entidad);
        void Actualizar(dynamic entidad);
        DataSet Mostrar(string filtro);
    }
}
