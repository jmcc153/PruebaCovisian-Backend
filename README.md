# Proyecto PruebaCovisian

Este proyecto es una aplicación de .NET Core para la gestión de alquileres de autos, haciendo uso de Entity Framework.

## Estructura del Proyecto

El proyecto tiene la siguiente estructura de archivos y directorios:

- `AlquilerContext.cs`: Este archivo contiene el contexto de la base de datos para la prueba.
- `appsettings.json` y `appsettings.Development.json`: Estos archivos contienen la configuración de la aplicación.
- `Controllers/`: Este directorio contiene los controladores de la aplicación, incluyendo `AlquilerController.cs`.
- `Models/`: Este directorio contiene los modelos de la aplicación, incluyendo `Alquiler.cs`, `Carro.cs`, `Cliente.cs` y `Pagos.cs`.
- `Program.cs`: Este archivo contiene el punto de entrada de la aplicación.
- `PruebaCovisian.csproj` y `PruebaCovisian.sln`: Estos archivos contienen la configuración del proyecto y la solución, respectivamente.
- `Repositories/` y `Services/`: Estos directorios contienen las clases de repositorios y servicios de la aplicación.

El proyecto cuenta con un archivo `docker-compose.yml` con el cual puedes levantar el servicio para la base de datos si así lo deseas

## Configuración del Proyecto

El proyecto está configurado para usar .NET 8.0 y Entity Framework Core 8.0.4 para la persistencia de datos. La configuración de la base de datos se encuentra en `appsettings.json`.

## Cómo ejecutar el proyecto

Para ejecutar el proyecto, puedes usar el comando `dotnet run` en la terminal.
