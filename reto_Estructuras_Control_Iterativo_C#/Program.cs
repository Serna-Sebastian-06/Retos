// Sección 1 — For y Foreach: Registro y análisis de calificaciones

int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");
for (int notas = 0; notas < calificaciones.Length; notas++)
{
    Console.WriteLine($"Estudiante: {notas + 1} | Nota: {calificaciones[notas]}");
}

Console.WriteLine("=== ORDEN DESCENDENTE ===");
for (int notas = calificaciones.Length - 1; notas >= 0; notas--)
{
    Console.WriteLine($"Estudiante: {notas + 1} | Nota: {calificaciones[notas]}");
}

Console.WriteLine("=== PROMEDIO DEL GRUPO ===");
int suma = 0;
foreach (int calificacion in calificaciones)
{
    suma += calificacion;
}

double promedio = (double)suma / calificaciones.Length;
Console.WriteLine($"Suma total: {suma}");
Console.WriteLine($"Promedio de calificaciones: {promedio}");

Console.WriteLine("=== POSICIONES PARES ===");
for (int posicionPar = 0; posicionPar < calificaciones.Length; posicionPar += 2)
{
    Console.WriteLine($"Posición par: {calificaciones[posicionPar]}");
}


//Sección 2 — While y Do-While: Validación y juego interactivo
byte intentos = 0;
string clave = "sena2026";

Console.WriteLine("=== CONTROL DE ACCESO ===");
while (intentos < 3)
{
    Console.WriteLine($"Ingrese su clave: ");
    string claveIngresada = Console.ReadLine();
    intentos++;

    if (claveIngresada != clave)
    {
        Console.WriteLine($"Clave incorrecta. Intentos restantes: {3 - intentos}");
        if (intentos == 3)
        {
            Console.WriteLine("Accedo denegado.");
            break;
        }
    }

    else if (clave == claveIngresada)
    {
        Console.WriteLine("Acceso concedido");
        break;
    }
}

int opciones = 0;

do
{
    Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
    Console.WriteLine("1. Ver promedio del grupo");
    Console.WriteLine("2. Ver calificación más alta");
    Console.WriteLine("3. Salir");
    Console.Write("Selecciona una opción: ");

    opciones = Convert.ToInt32(Console.ReadLine());

    switch (opciones)
    {
        case 1:
            Console.WriteLine($"Promedio del grupo: {promedio}");
            break;
        case 2:
            int notaMasAlta = calificaciones[0];
            for (int i = 0; i < calificaciones.Length; i++)
                if (calificaciones[i] > notaMasAlta)
                {
                    notaMasAlta = calificaciones[i];
                }
            Console.WriteLine($"Calificación más alta: {notaMasAlta}");
            break;
        case 3:
            Console.WriteLine("Hasta luego.");
            break;
        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            break;
    }
} while (opciones != 3);


//Sección 3 — Break y Continue: Filtrado y búsqueda eficiente

Console.WriteLine("\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");

for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 60)
    {
        Console.WriteLine($"Encontrada en posición {i + 1}: {calificaciones[i]}");
        break;
    }
}


Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");

int aprobados = 0;

foreach (int calificacion in calificaciones)
{
    if (calificacion < 60)
    {
        continue;
    }

    Console.WriteLine($"Aprobado: {calificacion}");
    aprobados++;
}

Console.WriteLine($"Total aprobados: {aprobados}");


Console.WriteLine("\n=== FILTRO COMBINADO ===");

for (int i = 0; i < calificaciones.Length; i++)
{
    if (calificaciones[i] < 70)
    {
        continue;
    }

    if (calificaciones[i] >= 95)
    {
        Console.WriteLine($"Búsqueda detenida al encontrar: {calificaciones[i]}");
        break;
    }

    Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
}
