namespace clase7
{
public class ClsEmpleados
{
    public ClsEmpleados()
    {
      Nombre = ""; 
      SueldoDiario = 0.0m;
       Edad = 0;
    }
    private string _Nombre;

    public string Nombre
    {
       get {return _Nombre;}
       set { _Nombre = value; }
    }
  public decimal SueldoDiario { get; set; }
}




}