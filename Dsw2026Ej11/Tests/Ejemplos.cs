using System;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Tests;


internal class Ejemplos()
{
    public static void EjemploList()
    {
        Console.WriteLine(" ---- EJEMPLO LIST ----");

        CasoList casoList = new CasoList();

        //Agregar 3 alumnos a la lista
        Alumno a1 = new Alumno(1, 51366, "Samir", 7);
        Alumno a2 = new Alumno(2, 51367, "Juan", 8);
        Alumno a3 = new Alumno(3, 51368, "María", 9);
        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);
        //Listar por consola los alumnos
        Console.WriteLine("\nLISTADO DE ALUMNOS:");
        foreach (Alumno alumno in casoList.RetornarAlumnos())
        {
            Console.WriteLine(alumno);
        }
        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\nBUSQUEDA DE ALUMNO POR NOMBRE: 'Juan'");
        Alumno alumnoEncontrado = casoList.ObtenerAlumnoPorNombre("Juan");
        Console.WriteLine(alumnoEncontrado != null ? alumnoEncontrado.ToString() : "No existe");

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBUSQUEDA DE ALUMNO POR NOMBRE: 'Pedro'");
        Alumno alumnoNoEncontrado = casoList.ObtenerAlumnoPorNombre("Pedro");
        Console.WriteLine(alumnoNoEncontrado != null ? alumnoNoEncontrado.ToString() : "No existe");

        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\nELIMINAR ALUMNO: " + a1.Nombre);
        casoList.EliminarAlumno(a1);
        Console.WriteLine("LISTADO DE ALUMNOS SIN: " + a1.Nombre);
        foreach (Alumno alumno in casoList.RetornarAlumnos())
        {
            Console.WriteLine(alumno);
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\nELIMINAR EL PRIMER ALUMNO DE LA LISTA");
        casoList.EliminarUnAlumnoDeLaLista(0);
        Console.WriteLine("\nLISTADO DE ALUMNOS DESPUÉS DE ELIMINAR EL PRIMER ALUMNO DE LA LISTA:");
        foreach (Alumno alumno in casoList.RetornarAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }


    public static void EjemploDictionary()
    {
        Console.WriteLine(" ---- EJEMPLO DICTIONARY ----");
        CasoDictionary casoDictionary = new CasoDictionary();


        //Agregar 3 alumnos al diccionario
        Alumno a1 = new Alumno(1, 51366, "Samir", 7);
        Alumno a2 = new Alumno(2, 51367, "Juan", 8);
        Alumno a3 = new Alumno(3, 51368, "María", 9);
        casoDictionary.AgregarAlumno(a1);
        casoDictionary.AgregarAlumno(a2);
        casoDictionary.AgregarAlumno(a3);

        //Listar por consola los alumnos
        Console.WriteLine("\nLISTADO DE ALUMNOS:");
        foreach (var alumno in casoDictionary.RetornarAlumnos())
        {
            Console.WriteLine($"Clave: {alumno.Key} - Alumno: {alumno.Value}");
        }

        //Buscar un alumno por clave y mostrar por consola
        
        Console.WriteLine("\nBUSQUEDA DE ALUMNO EXISTENTE POR LEGAJO: 51366");
        Alumno encontrado = casoDictionary.ObtenerUnAlumno(51366);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        //Buscar un alumno por clave que no exista y mostrar por consola
        Console.WriteLine("\nBUSQUEDA DE ALUMNO INEXISTENTE POR LEGAJO: 99999");
        Alumno noEncontrado = casoDictionary.ObtenerUnAlumno(99999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\nELIMINAR ALUMNO POR LEGAJO: 51366");
        casoDictionary.EliminarAlumno(51366);
        Console.WriteLine("\nLISTADO DE ALUMNOS DESPUÉS DE ELIMINAR EL ALUMNO CON CLAVE 51366:");
        foreach (var alumno in casoDictionary.RetornarAlumnos())
        {
            Console.WriteLine($"Clave: {alumno.Key} - Alumno: {alumno.Value}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("\n--- EJEMPLO LINQ ---");
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("\n1. Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero().Titulo);

        Console.WriteLine("\n2. Ultimo libro: ");
        Console.WriteLine(casoLinq.GetUltimo().Titulo.ToString());

        Console.WriteLine("\n3. Suma de precios: ");
        Console.WriteLine(casoLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n4. Promedio de los precios: ");
        Console.WriteLine(casoLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n5. Libros con Id > 15:");
        foreach (var libro in casoLinq.GetListById()) { Console.WriteLine(libro.Titulo); }

        Console.WriteLine("\n6. Libros con título y precio:");
        foreach (var texto in casoLinq.GetLista()) { Console.WriteLine(texto); }

        Console.WriteLine("\n7. Libro con el mayor precio:");
        Console.WriteLine($"{casoLinq.GetMayorPrecio().Titulo} - {casoLinq.GetMayorPrecio().Precio:C}");

        Console.WriteLine("\n8. Libro con el menor precio:");
        Console.WriteLine($"{casoLinq.GetMenorPrecio().Titulo} - {casoLinq.GetMenorPrecio().Precio:C}");

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio()) { Console.WriteLine(libro.Titulo); }

        Console.WriteLine("\n10. Libros ordenados (Z-A):");
        foreach (var libro in casoLinq.GetLibrosOrdenados()) { Console.WriteLine(libro.Titulo); }
    }
}



