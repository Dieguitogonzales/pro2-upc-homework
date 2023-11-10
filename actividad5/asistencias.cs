using System.Data;

public class Asistencias{
public string carrera;
public string materia;
public string docente;

public DateTime periodo;

//el constructor
public Asistencias(){
    carrera = "sin carrera";
    materia = "sin asignar";
    docente = "sin asignar";
}
public void asignarCarrera(string valor){
carrera = valor;

}
public void asignarMateria(string libro){
    materia = libro;
}
public void asignarDocente(string D){
docente = D;
}


}