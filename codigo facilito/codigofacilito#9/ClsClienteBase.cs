namespace Presentacion7
{
    public class clsClientesBase : clsAbsClientes
    {
        public clsClientesBase(int id, string nombre, string clave, string rfc, int tipoRegimen, string nombreContacto)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
            RFC = rfc;
            TipoRegimen = tipoRegimen;
            NombreContacto = nombreContacto;
        }

        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public override string Clave { get; set; }
        public override string RFC { get; set; }
        public override int TipoRegimen { get; set; }
        public override string NombreContacto { get; set; }
    }
}