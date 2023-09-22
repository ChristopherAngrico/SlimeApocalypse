# Slime Apocalypse

<img src="" height="70%" width="70%">

## Description


## Game Mechanic
Purchasing items with points is pretty simple. To accumulate points, simply let your player take damage from enemies; your health will decrease, but those losses will be converted into points.  

## Game controls

The following controls are bound in-game, for gameplay and testing.

| Key Binding       | Function          |
| ----------------- | ----------------- |
| W,A,S,D           | Standard movement |
| Left Click        | Throw  knife      |

### Script

This game operates on a series of scripts..

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
