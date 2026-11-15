# Warehouse Wobble

Warehouse Wobble is a 3D physics-based stacking game where players drag items from a moving conveyor belt and stack them onto a storage shelf without damaging them, maintaining a stable tower that will not topple over.

This repository contains the **Sprint 1 Core Gameplay Prototype**, developed over a 2-week (10 working day) Agile/Scrum sprint.

---

## Implemented Features (Sprint 1)

* **Warehouse Environment**: A 3D warehouse scene with a fixed camera positioned to frame both the conveyor belt and the storage shelf.
* **Conveyor Belt System**: An animated conveyor belt that automatically spawns new items at the start of the line and moves them along the track.
* **Distinct Item Types**: Multiple physics-enabled item categories—including **heavy**, **bouncy**, and **fragile**—with visual indicators reflecting their weight and physical behavior.
* **Physics Drag-and-Drop**: Responsive item manipulation that keeps dragged objects inside the warehouse walls and prevents them from clipping through other items.
* **Shelf Stacking**: Solid collision handling on the shelf and warehouse floor so items can be stacked across the entire shelf without falling through.
* **Positional Collision Audio**: Spatial sound effects triggered at the exact point of impact when a dragged item collides with another item.

---

## Controls

| Action | Input |
| :--- | :--- |
| Grab and drag an item | Hold Left Mouse Button |
| Drop an item | Release Left Mouse Button |

---

## Core Architecture

The Sprint 1 prototype is organized into modular components:

* **Scene Initialization**: Launches into a playable warehouse view with an empty conveyor belt and empty storage shelf.
* **Conveyor Spawner and Movement**: Controls continuous belt animation and spawns configured physics items at the belt's entry point.
* **Physics Item Controller**: A reusable script attached to physics objects enabling players to pick up, move, and place items onto the shelf or warehouse floor.
* **Collision Audio Script**: Detects item-to-item collisions during dragging and plays balanced audio feedback at the collision coordinates.

---

## Roadmap (Proposed Sprint 2 and Future Features)

Planned expansions for subsequent sprints include:

* **Shipment Win Condition and Economy**: Sending off stacked shipments after passing a stability countdown timer to earn cash.
* **User Interface**: HUD elements displaying the player's current cash balance and active stability countdown.
* **Weight and Crush Mechanics**: Fragile items breaking when stacked improperly or crushed beneath too many heavy items.
* **Environmental Hazards**: Warehouse ventilation fan crosswinds, floor rumbles and vibrations that destabilize stacks, and conveyor belts that speed up over time.
* **Audio-Visual Polish**: Particle effects, camera shake, and dedicated sound effects for item placement, breakage, and completed shipments.
* **Warehouse Progression**: Expanded warehouse props and purchasable warehouse upgrades unlocked using earned cash.

---

## Development Workflow

* **Methodology**: Agile / Scrum with tasks estimated using T-shirt sizing (`XS` to `XL`).
* **Version Control**: Features are tested in play mode and committed to the `dev` branch with descriptive commit messages once moved to `Review / Polish` on Trello.

---

## Author

* **Johannes Grcevic**
