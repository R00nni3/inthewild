# In The Wild

Un plataformas 2D de exploración inspirado en los clásicos como el juego de Tarzán o el del Rey León, donde el jugador recorre una selva misteriosa esquivando peligros y recolectando tesoros.

Desarrollado en **Unity 6 (2D Platformer Microgame)** como proyecto de la actividad evaluativa "Pixel Adventure".

---

## 🎮 Cómo jugar

| Acción | Tecla |
|---|---|
| Moverse a la izquierda / derecha | Flechas ← → |
| Saltar | Barra espaciadora |

El objetivo es recorrer el nivel de punta a punta, esquivando enemigos y zonas de agua, recolectando la mayor cantidad de tesoros posible, hasta llegar a la zona final.

---

## 🌿 Mecánicas del juego

- **Movimiento y salto**: control fluido del personaje en tercera persona (2D lateral), heredado y ajustado sobre la plantilla base de Unity.
- **Enemigos**:
  - Si el jugador **pisa** a un enemigo desde arriba, el enemigo muere.
  - Si el jugador lo **toca de costado**, pierde una vida.
- **Zonas de agua**: tocar el agua hace perder una vida.
- **Sistema de vidas**: el jugador cuenta con 3 vidas (representadas con corazones en pantalla). Al perderlas todas, aparece la pantalla de "Game Over" con opción de reintentar o salir.
- **Coleccionables**: tesoros repartidos por el nivel que se suman a un contador visible en pantalla.
- **Zona de victoria**: al llegar al final del recorrido, se muestra la pantalla de "¡Nivel completado!".
- **Pantalla de inicio**: explica brevemente los controles antes de comenzar a jugar.

---

## 🛠️ Scripts principales

- `GameManager.cs` — controla el flujo general del juego: vidas, pantallas de inicio/muerte/victoria, reinicio y salida.
- `PlayerEnemyCollision.cs` — determina si el contacto con un enemigo es un pisotón (mata al enemigo) o un golpe lateral (resta una vida).
- `EnemyController.cs` — movimiento de patrulla de los enemigos sobre su plataforma.
- `DamageOnTouch.cs` — resta una vida al jugador al entrar en contacto con las zonas de agua.
- `Collectible.cs` — suma un tesoro al contador y elimina el objeto recolectado.

---

## 🎨 Créditos y assets utilizados

- **Base del proyecto**: Unity Technologies — *2D Platformer Microgame* (plantilla oficial de Unity).
- **Personaje principal**: ilustración original dibujada a mano por mi, Rosario González.
- **Tileset de selva y decoraciones**: 
Fondo de Jungla:
https://trashboat93.itch.io/jungle-background-parallax

Corazón de vida:
https://es.vecteezy.com/png/54978926-juego-corazon-pixelado

cofre de victoria:
https://www.pngwing.com/es/free-png-iuxwu/download
- **Música de fondo**: https://pixabay.com/music/search/jungle/

---

## 👩‍💻 Desarrollado por

Rosario González Perucich

Proyecto realizado para Taller de Videojuegos — IPChile.
Docente Sabina Romero

##Video demostración.
https://www.youtube.com/watch?v=S_wYN6Zhtn0

---

## 📦 Cómo abrir el proyecto

1. Clonar o descomprimir el repositorio.
2. Abrir la carpeta del proyecto desde **Unity Hub** (versión recomendada: Unity 6.3 LTS o superior).
3. Abrir la escena `SampleScene` dentro de `Assets/Scenes`.
4. Presionar **Play** para probar el juego dentro del Editor.