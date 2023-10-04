# Slime Apocalypse

<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/a8d5c052-5afb-4b0b-92c6-cac46f42ac98" height="70%" width="70%">


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
<p>SlimeBreath<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/9f3066cd-270e-4508-965e-4d044216bb82" height="30%" width="30%">
  
<p>Slime Trail<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/a17ab3b5-6f80-4a08-b9d1-d7145b7f7192" 30%" width="30%">

<p>Slime Stomp<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/79c6705e-be16-4239-8844-397afab3a51b" 30%" width="30%">

<p>Prologue<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/7f6a02dc-25f1-4658-8762-b58dab4e2819"30%" width="30%">

<p>TransitionPrologue<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/7ed27b14-b354-4122-88fc-9d006cd38008" width="30%">

<p>Attack<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/ff4503ca-ef2c-4b58-afed-b18d297383d0" 30%" width="30%">

<p>Flip<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/46f620ca-e114-4167-917e-b159d02eda2b" 30%" width="30%">

<p>Switch character<p/>
<img src="https://github.com/ChristopherAngrico/SlimeApocalypse/assets/87889745/eaf4812b-60e8-4105-81d3-a31cf06ee037" 30%" width="30%">

  
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
