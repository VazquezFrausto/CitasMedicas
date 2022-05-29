namespace EntidadesCitasMedicas
{
    public class Pacientes
    {
        public Pacientes(int id, string nombre, string apellidopaterno, string apellidomaterno, int edad, int peso, int estatura, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellidopaterno = apellidopaterno;
            Apellidomaterno = apellidomaterno;
            Edad = edad;
            Peso = peso;
            Estatura = estatura;
            Telefono = telefono;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidopaterno { get; set; }
        public string Apellidomaterno { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public int Estatura { get; set; }
        public string Telefono { get; set; }

    }
}
