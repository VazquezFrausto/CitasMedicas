namespace EntidadesCitasMedicas
{
    public class Citas
    {
        public Citas(int id, int idmedico, int idpaciente, string fecha)
        {
            Id = id;
            Idmedico = idmedico;
            Idpaciente = idpaciente;
            Fecha = fecha;
        }

        public int Id { get; set; }
        public int Idmedico { get; set; }
        public int Idpaciente { get; set; }
        public string Fecha { get; set; }
    }
}
