# Flappy Bird Clone

A 2D endless-runner game inspired by **Flappy Bird**, developed with Unity and C# as a project for the **Advanced Programming** course at Shahid Beheshti University.

## Overview

This project recreates the core mechanics of Flappy Bird while exploring fundamental concepts of 2D game development in Unity, including physics, collision detection, procedural obstacle spawning, animation, user input, and game-state management.

The player controls a bird and attempts to navigate through continuously generated pipes while accumulating points for each successfully passed obstacle.

## Features

- 2D endless-runner gameplay
- Physics-based bird movement with gravity
- Keyboard, mouse, and touch input support
- Procedurally generated pipe obstacles
- Randomized pipe heights
- Collision detection and game-over system
- Real-time score tracking
- Animated bird sprites
- Scrolling background effect
- Replay functionality
- Automatic cleanup of off-screen obstacles

## Gameplay

The bird continuously falls due to gravity. The player can make the bird flap upward using:

- `Space` on the keyboard
- Left mouse click
- Touch input on supported devices

Pipes are continuously generated at randomized heights and move toward the player.

Passing through a pair of pipes increases the score by one. Colliding with an obstacle ends the game and allows the player to restart.

## Project Structure

The main gameplay logic is divided into several C# components:

```text
Assets/
├── Script/
│   ├── Player.cs
│   ├── GameManager.cs
│   ├── Spawner.cs
│   ├── Pipes.cs
│   └── Parallax.cs
├── Prefabs/
├── Scenes/
├── Fonts/
└── Assets/
```

### Main Scripts

**Player.cs**  
Handles player input, gravity, movement, bird rotation, sprite animation, collision detection, and scoring triggers.

**GameManager.cs**  
Controls the main game states, scoring, game-over behavior, and restarting the game.

**Spawner.cs**  
Continuously generates pipe obstacles at randomized vertical positions.

**Pipes.cs**  
Moves pipe obstacles across the screen and removes them after leaving the visible area.

**Parallax.cs**  
Creates the scrolling background effect during gameplay.

## Technologies

- Unity
- C#
- Unity 2D Physics
- Unity UI
- Sprite Animation

## Getting Started

### Requirements

- Unity `2022.3.18f1` or a compatible version

### Running the Project

1. Clone the repository.
2. Open Unity Hub.
3. Select **Add project from disk**.
4. Select the cloned project directory.
5. Open the game scene.
6. Press **Play** in the Unity Editor.

## Course Information

- **Course:** Advanced Programming
- **University:** Shahid Beheshti University
- **Major:** Computer Engineering
- **Project Type:** Individual Coursework
