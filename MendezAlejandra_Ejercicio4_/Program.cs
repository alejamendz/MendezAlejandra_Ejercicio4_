// See https://aka.ms/new-console-template for more information
Console.WriteLine("MENÚ CLASIFICAION DE INCIDENTE DE SEGURIDAD INFORMÁTICA");

Console.WriteLine("Tipo de incidente:");
Console.WriteLine("1. Malware");
Console.WriteLine("2. Phishing");
Console.WriteLine("3. Acceso no autorizado");
Console.WriteLine("4. Fuga de información");

int incidente = int.Parse(Console.ReadLine());


Console.WriteLine("Activo afectado:");
Console.WriteLine("1. PC");
Console.WriteLine("2. Servidor");
Console.WriteLine("3. Base de datos");
Console.WriteLine("4. Red");

int activo = int.Parse(Console.ReadLine());


Console.WriteLine("Datos comprometidos:");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Internos");
Console.WriteLine("3. Personales");
Console.WriteLine("4. Financieros");

int datos = int.Parse(Console.ReadLine());

Console.WriteLine("Persistencia detectada (S/N):");
string persistencia = Console.ReadLine();

Console.WriteLine("Número de usuarios afectados:");
int usuarios = int.Parse(Console.ReadLine());

string severidad = "Baja";
string respuesta = "Monitorear";


if (incidente < 1 || incidente > 4)
{
    Console.WriteLine("Tipo de incidente invalido");
}
else if (activo < 1 || activo > 4)
{
    Console.WriteLine("Activo invalido");
}
else if (datos < 1 || datos > 4)
{
    Console.WriteLine("Datos comprometidos inválidos");
}
else if (usuarios < 0)
{
    Console.WriteLine("Número de usuarios inválido");
}
else
{
    switch (incidente)
    {
        case 1:
            if (activo == 2 && persistencia == "S")
            {
                severidad = "Critica";
                respuesta = "Aislar servidor y limpiar malware";
            }

            else if (usuarios <= 5 && datos == 1)
            {
                severidad = "Baja";
                respuesta = "Monitorear y limpiar sistema afectado";
            }
            else
            {
                severidad = "Media";
                respuesta = "Investigar y limpiar sistema afectado";
            }
            break;

        case 2:
            if (datos == 3 || datos == 4)
            {
                severidad = "Alta";
                respuesta = "Notificar usuarios y cambiar credenciales";

            }
            else
            {
                severidad = "Media";
                respuesta = "Alerta y educación al usuario";
            }
            break;

        case 3:
            if (datos == 4 || datos == 3)
            {
                severidad = "Alta";
                respuesta = "Revisar accesos y bloquear intrusos";
            }
            else if (usuarios <= 3)
            {
                severidad = "Baja";
                respuesta = "Monitorear actividad sospechosa";
            }
            else
            {
                severidad = "Media";
                respuesta = "Revisar accesos y auditar";
            }
            break;


        case 4:
            if (datos == 4)
            {
                severidad = "Crítica";
                respuesta = "Notificar incidentes y contener fuga";
            }
            else if (datos == 3) // personales
            {
                severidad = "Alta";
                respuesta = "Investigar y notificar afectados";
            }
            else if (datos == 2) // internos
            {
                severidad = "Media";
                respuesta = "Auditar información filtrada";
            }
            else
            {
                severidad = "Baja";
                respuesta = "Monitorear";
            }
        break;

    }
}
