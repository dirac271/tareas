# TaskDB

Aplicación de escritorio para la gestión de tareas, hecha en C# con Windows Forms y SQL Server LocalDB.

## Tecnologías

- .NET Framework 4.8
- Windows Forms
- SQL Server LocalDB
- Git y GitHub (una rama `feature/...` por módulo y Pull Request hacia `main`)

## Requisitos

- Windows 10 u 11.
- Visual Studio 2022 con la carga de trabajo «Desarrollo de escritorio de .NET».
- SQL Server Express LocalDB 2019 o posterior (se instala con Visual Studio 2022).

## Cómo ejecutar

1. Clonar el repositorio: `git clone <URL_REPOSITORIO>`
2. Abrir `TaskDB.sln` en Visual Studio.
3. Presionar **F5** para compilar y ejecutar.

La base de datos `TaskDB/TaskDB.mdf` se copia junto al ejecutable al compilar, y la aplicación
la abre con `|DataDirectory|`, así que no hay que configurar ninguna ruta.
Si hiciera falta volver a crearla, el script de la tabla está en `Database/CrearTaskDB.sql`.

## Módulos

| Módulo | Rama | Archivos principales |
| --- | --- | --- |
| Base de datos y Git | `feature/base-datos` | `TaskDB.mdf`, `DatabaseConnection.cs`, `App.config` |
| Formulario de registro | `feature/form-registro` | `FrmAgregarTarea.cs` |
| Formulario de listado | `feature/form-listado` | `FrmListadoTareas.cs` |
| Integración y filtros | `feature/integracion-filtros` | `FrmListadoTareas.cs`, `FrmPrincipal.cs` |

## Flujo de trabajo

1. Crear una rama por requerimiento: `git checkout -b feature/nombre-modulo`
2. Confirmar los cambios: `git commit -m "feat: descripción del cambio"`
3. Publicar la rama: `git push origin feature/nombre-modulo`
4. Abrir un Pull Request hacia `main`.
