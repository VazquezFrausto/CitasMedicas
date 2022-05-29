using System.Data;
using ConectarBd;
using EntidadesCitasMedicas;

namespace AccesoDatosCitasMedicas
{
    public class AccesoMedicos : IEntidades
    {
        Base b = new Base("localhost", "root", "", "citasmedicas");

        public void Actualizar(dynamic entidad)
        {
            b.Comando(string.Format("call update_medico('{0}','{1}','{2}','{3}','{4}','{5}',{6})",
                entidad.Nombre, entidad.Apellidopaterno, entidad.Apellidomaterno, entidad.Telefono,
                entidad.Correo, entidad.Especialidad, entidad.Id));
        }

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("call delete_medico({0})", entidad.Id));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("call insert_medico('{0}','{1}','{2}','{3}','{4}','{5}')",
                entidad.Nombre, entidad.Apellidopaterno, entidad.Apellidomaterno, entidad.Telefono,
                entidad.Correo, entidad.Especialidad));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call show_medico('{0}')", filtro), "medico");
        }
    }
}
