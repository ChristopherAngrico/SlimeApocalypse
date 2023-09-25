# Slime Apocalypse

<img src="https://sat02pap001files.storage.live.com/y4mYswHujbysNXOrHyaGF3E1n0GbDDuCine-71CJfkkR1i5BjbWAfcyoElK3GqYsMUVy9b7mE8a2-ZALQa0kLUraRBbX-GMVZDhPwCv-auDrnPwUNtadPPA8yc7CcYnm1YKpmAK2Vbi3MNSCKZxbFSGuQKb37ObRaVyaOcdUsC6uKfF9ENG_D_QpWv2U2iABhxbi_uN6omUjeub9YfjFQOvw8gB2SdU5UZ7dMPkvlj_eUE?encodeFailures=1&width=1599&height=895" height="70%" width="70%">

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
| Left Click        | Spray water, and attack |
| E        | Switch player |
| ESC        | To open main menu |

### Script
This game operates on a series of scripts.

| Script       | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `PlayerMovement` | To control player movement such as "WASD". |
| `PlayerAnimation`  | Control player animation. |
| `SlimeAnimation`  | Control slime animation. |
| `FixRotateHealthBar`  | Fix health bar rotation for example: player face the left side or right side the rotation still remaining same.  |
| `HealthSystemComponent`  | Adjust health such as player, slime, and tree of life.  |
| `PlayerHealth`  | Handle player health.  |
| `SprayWater`  | Handling spray water of firefighter and follow mouse direction. |
| `WarriorAttack`  | Handling attack warrior and follow mouse direction. |
| `SpawnerManager`  | Handling spawn slime. |
| `PlayerInput`  | New input system. |
| `ExtinguishFire`  | to put out fire. |
| `SlimeBreathFire`  | Control fire breath attack. |
| `SlimeStomper`  | Stomping player or life of tree with fire effect. |
| `SlimeFireTrail`  | Control the fire trail left by slime. |
| `TreeOfLife`  | Control the health that has been attacked by slimes. |
| `SceneChanger`  | Handling changing scene. |
| `Enemy`  | Create an inheritance class with handling movement and attack to inherite to other class such as SlimeBreathFire, SlimeStomper, SlimeFireTrail. |
| `FollowTarget`  | Follow player position such as player move to right main camera, spawner, and background follow the player position. |
| `DestroyFire`  | Destroy fire when the fire is out. |
| `MovingSpawner`  | To make sure spawn position is random. |
| `WaveSystem`  | Manage wave system. |
| `ScrollingText`  | Make character appear one by one. |
| `PlayerSwitching`  | SwitchingPlayer. |

## Short Gameplay
From here:
https://www.youtube.com/watch?v=s2WeXjx1SCE&ab_channel=ChristopherAngrico
