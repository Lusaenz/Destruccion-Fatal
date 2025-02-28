# # Unity Game - Destruccion Fatal

## Descripción del Proyecto

Este es un juego desarrollado en Unity. En este juego, aparecen balones en pantalla que caen hacia un sensor ubicado en la parte inferior. El jugador debe interactuar con los objetos utilizando el mouse para eliminarlos antes de que lleguen al sensor.

El juego cuenta con diferentes tipos de elementos:

- **balones Buenos**: Aumentan el puntaje del jugador.
- **beykers**: Reduce el puntaje del jugador si toca el sensor.

El juego incluye un sistema de UI con un menú principal que permite seleccionar distintos niveles de dificultad y activar/desactivar la música.

## Características Principales

- Uso del patrón **Singleton** en el GameManager para gestionar la lógica del juego de manera eficiente.
- Implementación de detección y eliminación de objetos con el **mouse**.
- Sistema de **puntuación dinámica** según los objetos eliminados o tocados por el sensor.
- **Menú interactivo** con opciones de dificultad y control de música.
- **Interfaz de usuario (UI)** que muestra la puntuación y permite la navegación entre pantallas.

## Tecnologías Utilizadas

- **Motor de juego**: Unity
- **Lenguaje de programación**: C#
- **Sistema de gestión de escena y eventos** utilizando el patrón Singleton

## Instalación y Ejecución

1. Clona este repositorio en tu máquina local:
   ```sh
   git clone git@github.com:Lusaenz/Destruccion-Fatal.git
   ```
2. Abre el proyecto en **Unity (versión recomendada: 2021.3 o superior)**.
3. Ejecuta la escena principal desde el editor de Unity.

## Controles del Juego

- **Clic izquierdo** del mouse para eliminar objetos.
- Navegación en el menú para seleccionar la dificultad y controlar la música.

## Contribuciones

Si deseas contribuir, puedes enviar un **pull request** con mejoras o sugerencias.

## Autor

**Luisa Saenz**

## Licencia

Este proyecto está bajo la licencia MIT. Puedes utilizarlo y modificarlo libremente.

