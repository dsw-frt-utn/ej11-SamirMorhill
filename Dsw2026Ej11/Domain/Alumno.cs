namespace Dsw2026Ej11.Domain;

public class Alumno
{
    public int Id { get; }
    public int Legajo { get; }
    public string Nombre { get; }
    public double Promedio { get; }

    public Alumno(int id, int legajo, string nombre, double promedio)
    {
        Id = id;
        Legajo = legajo;
        Nombre = nombre;
        Promedio = promedio;
    }

    public override string ToString()
    {
        return $"{Id} - {Nombre} - Promedio: {Promedio}";
    }
}
