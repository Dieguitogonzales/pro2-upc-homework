namespace clase8
{
    public class ClsClientes
    {
        private int _IdCliente;
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        private string _Nombres;
        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        private string _Apellido;
        public string Apellidos
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
    }
}