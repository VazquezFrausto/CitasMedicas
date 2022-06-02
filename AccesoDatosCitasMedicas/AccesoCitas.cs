using System.Data;
using ConectarBd;
using EntidadesCitasMedicas;

namespace AccesoDatosCitasMedicas
{
    public class AccesoCitas : IEntidades
    {
        Base b = new Base("localhost", "root", "", "citasmedicas");

        public void Actualizar(dynamic entidad)
        {
            b.Comando(string.Format("call update_cita({0},{1},'{2}',{3})", 
                entidad.Idmedico, entidad.Idpaciente, entidad.Fecha, entidad.Id));
        }

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("call delete_cita({0})", entidad.Id));
        }

        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("call insert_cita({0},{1},'{2}')",
                entidad.Idmedico, entidad.Idpaciente, entidad.Fecha));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call show_cita('{0}')", filtro), "cita");
        }
    }
}
