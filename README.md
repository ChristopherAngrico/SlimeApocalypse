# Slime Apocalypse

<img src="" height="70%" width="70%">

## Description
In the middle of the forest, stood a large tree which gives life to the entirety of the forest.
The residents of the forest named it as the Tree of Life.
The tree of had a barrier that allowed only one human to enter at a time, to protect itself from any dangers that may come.

When suddenly, slimes started to approach the Tree of Life wanting to burn it down. 
The slimes were unique, in which they would explode upon being slain creating a huge pool of fire that would spread throughout the surrounding area.
The slimes were also somehow immune to the effects of the barrier.

While the other inhabitants of the forest were no match for the slimes explosions, two human who lived nearby the tree of life,
A warrior who is very proficient in using weapons, and a firefighter who is very accustomed to dealing with forest fires.
It was up to the two of them to protect the the tree of life from the dangers of the exploding slimes.
one human to enter at a time, they need to perform a person swapping ritual for both of them to be able to do their job.


## Game Mechanic
The player must defend the Tree of Life from attacks by slimes. The player has access to two characters: a warrior and a firefighter. Each character has a specific role; the warrior is responsible for attacking the slimes, while the firefighter's role is to extinguish fires produce by slime.

## Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement |
| Left Click        | Spray water, and attack      |

### Script
This game operates on a series of scripts.

| Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `PlayerMovement` | To control player movement such as "WASD". |
| `Animated`  | Control all the animation such as Player, Clone, and Enemy. |
| `CloneHealth`  | Control clone health. |
| `FixRotateHealthBar`  | Fix health bar rotation for example: player face the left side or right side the rotation still remaining same.  |
| `DetectPlayer`  | Detect player is within enemy range.  |
| `EnemyCondition`  | Condition of an enemy such as getting hit by player or die.  |
| `HitPlayer`  | If player enter range attack will get hit. |
| `SpawnEnemy`  | Spawn manager to control spawn system. |
| `HealthSystem`  | Simplify class of health system. |
| `InputSystem`  | New input system. |
| `Knife damage`  | to damage enemy when it hit. |
| `PlayerHurt`  | Condition of the player such as getting hit by enemy or die. |
| `PlayerInput`  | Control all input. |
| `ThrowKnife`  | Throw knife by mouse direction. |
| `BackgroundLoop`  | Move the background if player move to all direction. |
| `ChangeScene`  | Control changing scene. |
| `DestroyKnife`  | Knife will get destroy when fly out of screen. |
| `FollowTarget`  | Follow player position such as player move to right main camera, spawner, and background follow the player position. |
| `ThrowKnife`  | Throw knife by mouse direction. |
| `GameManager`  | Manage point and wave system. |
| `MovingSpawner`  | To make sure spawn position is random. |
| `BuyButton`  | Action after mouse clicked for buy button. |
| `GUIButton`  | Action after mouse clicked for menu. |
| `VolumeControl`  | Control game volume. |
| `Point`  | Show point in UI text. |

## Short Gameplay
From here:
https://www.youtube.com/watch?v=xbCiaC3eRx0&ab_channel=ChristopherAngrico
