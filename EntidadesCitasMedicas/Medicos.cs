namespace EntidadesCitasMedicas
{
    public class Medicos
    {
        public Medicos(int id, string nombre, string apellidopaterno, string apellidomaterno, string telefono, string correo, string especialidad)
        {
            Id = id;
            Nombre = nombre;
            Apellidopaterno = apellidopaterno;
            Apellidomaterno = apellidomaterno;
            Telefono = telefono;
            Correo = correo;
            Especialidad = especialidad;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidopaterno { get; set; }
        public string Apellidomaterno { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
    }
}
