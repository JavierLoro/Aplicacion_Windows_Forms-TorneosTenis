Este proyecto es una aplicación de escritorio desarrollada en **Visual Basic .NET** (Windows Forms) para la gestión de torneos de tenis.

## Descripción
- **Dominio**: contiene las clases que representan la lógica de negocio (jugadoras, torneos, países, partidos y ediciones).
- **Persistencia**: acceso a datos mediante DAOs y la clase `AgenteBD`, que se conecta a una base de datos **Microsoft Access**.
- **Presentación**: formularios WinForms para administrar jugadoras, países y torneos, así como para consultar clasificaciones.

La aplicación permite a los usuarios añadir, modificar y eliminar registros, además de simular ediciones de torneos generando enfrentamientos y sumando puntos a las jugadoras.

## Requisitos
- **.NET Framework 4.7.2**
- Base de datos Access (`.accdb`) con la estructura correspondiente (no incluida en el repositorio).

## Ejecución
1. Abrir el archivo `Practica3Tenis.sln` con **Visual Studio 2019** o posterior.
2. Compilar y ejecutar el proyecto.
3. En la ventana principal, pulsar **Conectar** y seleccionar el archivo de base de datos `.accdb`.
4. Una vez cargados los datos se habilitará el acceso a Jugadoras, Países, Torneos y Clasificación.
