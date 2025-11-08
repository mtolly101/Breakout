# Mini-Project 2: 3D Game
## Playable Unity Project: 
# Game concept and genre
## Option 1: FPS Game Extension
Breakout: You play as a test subject in a cyber lab overrun by rogue drones. Move and aim in first person, shoot enemies, collect energy cells, manage health and ammo, and survive waves until extraction.
## What the player does:
- Move with WASD, aim with mouse, shoot and reload
- Collect energy cells to increase score and recharge ammo
- Fight drones and avoid fire and laser hazards
- Track health, ammo and timer
- To win you have to survive all waves or reach a target score before time runs out
- To lose your health has to reach 0 or timer hits 0
- Show game over screen then restart button
## List of implemented base requirements
1. Player Control & Input
- First-person camera with smooth mouse look
- WASD movement with optional sprint and jump
- Input is responsive and predictable
2. Game Objects & Spawning
- 3 prefabs: The enemy is a drone, The obstacle is a turret, The collectible is an energy cell
- Random time spawning
3. Game State Management
- isGameOver boolean controls is game play is active
- Tracks score, timer and health
- Clear win and lose actions and restart button
4. Visual & Audio Feedback
- 2 particle effects for enemy explosion and collectibles
- 3 sound effects for shooting, explosions and collectibles
- Visual feedback on health, ammo and score updates
5. User Interface
- Title and start button
- Score, timer, ammo and health
- Game over and restart button
6. Code Quality
- Well organized scripts in PlayerController, GunController, EnemyAI, TurretController, SpawnManager, GameManager, UIManager, PowerUp
- Clear variable names
## List of 3+ extension features with brief explanation
1. Gameplay Mechanics
- Difficulty scaling system (speed increases, more enemies, limited resources)
- Each wave increase drone speed, spawn rate and boosts turret
- Power-up system with temporary effects
- Overcharge speed boost and damage for about 5 seconds and timer showing timer
- Multiple player abilities or attack types
- Primary with the rifle
- Secondary with the charged burst
- Enemy AI with different behaviors (chase player, patrol patterns, ranged attacks)
- Drones patrol and detect player then chase and then return to patrol if player breaks line of sight
- Turrets track the player and fire in bursts and then stop firing when player breaks line of sight
2. Technical Features
- Camera follow system or dynamic camera movement
- Recoil on fire
- Coroutines for timed events or delays
- Power up time and turret burst windows
- Object pooling for performance optimization
- For bullets and explosions to reduce stutter on heavy impact
3. Content & Polish
- Persistent high score system (using PlayerPrefs)
- Pause menu with resume functionality
- Environmental hazards or dynamic obstacles
- Warning light before activating
- Tutorial or instructions screen
## Challenges encountered and solutions
- Aim feel and camera needed to be adjusted because mouse felt weird so I added sensitivity slide and light smoothing
- Wave pacing was too easy so added spawn curves with max drones and short rest windows
- Switched the burst patterns with visible pre aim and placed cover so players can break line of sight
- Explosion and impact sounds became stacked so added cooledowns and pooled audion sources
## Assets used (with credits if from external sources)
- Start environment: https://github.com/LucasCordova/fpshooter
- Particles: explosion and collectibles in Unity’s particle system
