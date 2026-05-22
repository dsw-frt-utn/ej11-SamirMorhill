using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> alumnos = new List<Alumno>();


    public void AgregarAlumno(Alumno alumno)
    {
       alumnos!.Add(alumno);
    }

    public List<Alumno> RetornarAlumnos()
    {
        return alumnos!;
    }

    public Alumno? ObtenerAlumnoPorNombre(string nombre)
    {
        return alumnos!.Find(alumno => alumno.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumno)
    {
        
        alumnos!.Remove(alumno);
    }
    public List<Alumno> EliminarUnAlumnoDeLaLista(int posicion)
    {
        if (posicion < 0 || posicion >= alumnos!.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(posicion), "La posición está fuera de rango.");
        }

        alumnos!.RemoveAt(posicion);
        return alumnos;
    }   



}
