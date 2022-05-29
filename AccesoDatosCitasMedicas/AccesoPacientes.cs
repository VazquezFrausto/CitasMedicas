using System.Data;
using ConectarBd;
using EntidadesCitasMedicas;

namespace AccesoDatosCitasMedicas
{
    public class AccesoPacientes : IEntidades
    {
        Base b = new Base("localhost", "root", "", "citasmedicas");

        public void Actualizar(dynamic entidad)
        {
            b.Comando(string.Format("call update_paciente('{0}','{1}','{2}',{3},{4},{5},'{6}',{7})",
                entidad.Nombre, entidad.Apellidopaterno, entidad.Apellidomaterno, entidad.Edad,
                entidad.Peso, entidad.Estatura, entidad.Telefono, entidad.Id));
        }

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("call delete_paciente({0})", entidad.Id));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("call insert_paciente('{0}','{1}','{2}',{3},{4},{5},'{6}')",
               entidad.Nombre, entidad.Apellidopaterno, entidad.Apellidomaterno, entidad.Edad,
               entidad.Peso, entidad.Estatura, entidad.Telefono));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call show_paciente('{0}')", filtro), "paciente");
        }
    }
}
