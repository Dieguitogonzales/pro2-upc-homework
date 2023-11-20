namespace clase8
{
    public class ClsClientesVentas : ClsClientes
    {
        private string _RFC;

        private string _Direccion;
        private string _Colonia;
        private string _Municipio;
        private bool _EsCredito;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
    }
}