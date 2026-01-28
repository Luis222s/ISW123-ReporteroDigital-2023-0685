# Reportero Digital - ISW123-2023-0685

Aplicación de consola en C# desarrollada para un periódico digital dominicano.
El sistema ensambla artículos de noticias combinando múltiples fuentes de datos
de forma paralela y resistente a fallos de red.

## Tecnologías utilizadas
- C#
- .NET
- Programación asíncrona (async / await)
- Paralelismo con Task.WhenAll
- Manejo de eventos
- Manejo de excepciones personalizadas

## Cómo ejecutar el proyecto
1. Clonar el repositorio
2. Abrir la solución en Visual Studio
3. Ejecutar el proyecto de consola

## Funcionalidad principal
- Obtención simultánea de texto, imágenes y análisis
- Manejo de errores de red sin detener la aplicación
- Uso de eventos para notificar el estado de las fuentes
