# JUEGO_LAB (V3)

Juego de investigación en 2D con vista cenital (top-down), hecho en **Unity**. El jugador es un detective que llega a una isla después de una fuga de la prisión. Uno de los fugitivos se esconde en el pueblo y alguien lo está encubriendo. Durante tres días, el detective interroga a los habitantes de las cuatro casas, anota las pistas y al final acusa al culpable.

> Proyecto académico desarrollado en la UPC (2025).

---

## Historia

> *En una noche cubierta de niebla, una fuga masiva sacude la prisión. Los guardias actúan con rapidez y logran capturar a casi todos los reclusos… excepto a uno.*
>
> *Ese único prisionero logra escapar por el bosque y desaparecer sin dejar rastro. Las autoridades están seguras de algo: el fugitivo no abandonó la isla. Las miradas apuntan hacia el pequeño pueblo costero. Alguien lo está escondiendo.*
>
> *Eres un detective enviado para resolver el misterio. Tienes tres días para interrogar a los cuatro habitantes. Uno de ellos miente.*
>
> *El tiempo corre. La isla guarda secretos.*

### Misión del detective

Al llegar a la isla, el detective lo tiene claro: el fugitivo se refugió en una de las cuatro casas del pueblo y no lo hizo solo. Alguien lo está encubriendo, y es probable que intente escapar otra vez en cualquier momento.

Su tarea es interrogar casa por casa, volver después de cada ronda a la mesa del centro del pueblo para revisar sus apuntes y ordenar la información, y descubrir **quién protege al fugitivo** antes de que se acabe el tiempo.

## Cómo se juega

1. **Explora el mapa** del pueblo con el detective.
2. **Entra a una casa** (hay 4) para interrogar a su habitante. Cada día hay preguntas nuevas.
3. **Cada pregunta gasta energía.** Tienes **5 puntos de energía por día**, así que elige bien a quién y qué preguntar.
4. Las respuestas importantes se guardan como **pistas en las tarjetas de sospechosos**, que puedes revisar en cualquier momento.
5. En la **mesa del centro** puedes:
   - **Pasar al día siguiente.** Esta opción aparece cuando te quedas sin energía, antes del día 3. Al pasar el día votas a cada sospechoso como *inocente* o *sospechoso*.
   - **Elegir al culpable** para terminar la investigación.
6. El juego dura **3 días**. Si aciertas con el culpable, ganas; si te equivocas, pierdes.

## Controles

| Acción | Tecla |
|---|---|
| Moverse | `W` `A` `S` `D` / flechas |
| Entrar a una casa | `E` (cerca de la puerta) |
| Abrir la mesa de investigación | `C` (cerca de la mesa del centro) |
| Diálogos, tarjetas y menús | Ratón |

## Requisitos

- **Unity 2022.3.58f1** (LTS). Se recomienda usar exactamente esta versión desde Unity Hub.
- Paquetes (se instalan solos al abrir el proyecto, según `Packages/manifest.json`):
  - [Yarn Spinner for Unity](https://github.com/YarnSpinnerTool/YarnSpinner-Unity) para el sistema de diálogos
  - TextMeshPro
  - Timeline
  - 2D Sprite / Tilemap

## Cómo abrir el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/olenkisha14/Juego_Silent_Island.git
   ```
2. En **Unity Hub**, elige **Add → Add project from disk** y selecciona la carpeta clonada.
3. Abre el proyecto con **Unity 2022.3.58f1**. La primera vez tarda un poco porque se regenera la carpeta `Library/` y se descargan los paquetes.
4. Abre la escena `Assets/Scenes/Cutscent.unity` (la primera del *Build Settings*) y pulsa **Play**.

## Escenas

Orden en **File → Build Settings**:

| # | Escena | Descripción |
|---|---|---|
| 0 | `Cutscent` | Cinemática de apertura |
| 1 | `(1)MenuInicial` | Menú principal (Jugar / Créditos) |
| 2 | `introducción` | Introducción de la historia (diálogo del detective) |
| 3 | `(2)Mapa` | Mapa del pueblo: exploración, casas y mesa central |
| 4 | `(3)Casa` | Interior de una casa: interrogatorio al NPC |
| 5 | `(4)ElegirCulpable` | Pantalla de acusación final |
| 6 | `(5)GanarJuego` | Final: victoria |
| 7 | `(6)PerderJuego` | Final: derrota |
| 8 | `Creditos` | Créditos |
| 9 | `PasarDias` | Resumen del día y votación de sospechosos |
| 10 | `Instrucciones` | Instrucciones de juego |

## Estructura del proyecto

```
Assets/
├── Scenes/                 # Escenas del juego
├── Scripts/                # Lógica del juego (C#)
├── YarnSpinner_clase/
│   ├── Dialogues/          # Diálogos en Yarn (.yarn): introducción y días A–D
│   └── Scripts/            # Controladores de personajes de diálogo
├── PostDialogueData/       # ScriptableObjects con las pistas de cada NPC
├── Animaciones/            # Animaciones del jugador
├── TileMap/                # Tiles y prefabs del mapa
├── IMAGENESMENU/           # Arte de menús, fondos y personajes
├── Sonidos/, PersonalizadoAudio/   # Música y efectos de sonido
├── TiposLetras/            # Fuentes
└── Timeline/               # Cinemáticas
```

### Scripts principales

| Script | Función |
|---|---|
| `MenuInicial.cs` | Inicia la partida (energía = 5, día = 1) y guarda el estado global |
| `Movimiento_TOP_DOWN.cs` | Movimiento del jugador, animaciones y sonido de pasos |
| `DangerZone.cs` | Zonas de interacción: entrar a las casas (`E`) y usar la mesa central (`C`) |
| `SetDialogue.cs` | Carga el nodo de Yarn según el día y la casa visitada |
| `Settings.cs` | Tarjetas de sospechosos y comando de Yarn `unlock_card` para registrar pistas |
| `PostDialogoData.cs` | ScriptableObject con los textos de las pistas de cada NPC |
| `EnergyFill.cs` | Barra de energía en la interfaz |
| `MesaConf.cs` | Menú de la mesa central (pasar día / elegir culpable) |
| `NextDay.cs` | Votación diaria (inocente/sospechoso) y paso al día siguiente |
| `ElegirCulpable.cs` | Acusación final y desenlace |
| `SetPlayerPosition.cs` | Coloca al jugador frente a la casa de la que acaba de salir |
| `GetHouse.cs` | Muestra el NPC que corresponde a la casa visitada |

### Diálogos

Los diálogos están en `Assets/YarnSpinner_clase/Dialogues/`. Los nodos se llaman `Dia{N}{Casa}_Pregunta{M}`; por ejemplo, `Dia2C_Pregunta1` es la primera pregunta del día 2 en la casa C. Dentro de los diálogos se usan estos comandos:

- `<<reducirEnergia>>`: gasta un punto de energía.
- `<<unlock_card "NCPx" i>>`: añade la pista `i` a la tarjeta del NPC `x`.
- `<<salirCasa>>`: vuelve al mapa.

## Recursos de terceros

- **TopDown 2D RPG BE3**: tiles y sprites del mapa.
- **3DNPC_Characters**: personajes NPC.
- **Yarn Spinner**: sistema de diálogos ([licencia MIT](https://github.com/YarnSpinnerTool/YarnSpinner-Unity/blob/main/LICENSE.md)).

Todos los derechos de estos recursos pertenecen a sus autores.

## Autores

Proyecto desarrollado por estudiantes de la **UPC**, curso de desarrollo de videojuegos en Unity (2025).
