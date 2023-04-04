# 3D-Game-Planet-404-
Survial RPG

### Developers
* Marcio Arakaki: Main coder, built game mechanics and gameplay
* Micky Chan: World and level builder, sound

## Gameplay Mechanics
### Battle System
* Turned based battle system where players will choose their actions such as attack, block, items, escape. Players stats such as speed will determine their turn as well as their chances to escape.
* Turns will be determined by speed. If the player has double or more speed than their opponent, then the player will go twice. If they have more speed but not quite double then they would have a chance to go twice. 
* Before a battle starts the player will have a chance to set up traps near the ship. If a battle happens at the ship, then the battle will start with the player plus the traps that were set up. Traps can be useful in attacking, absorb damage, give buffs, etc.
* When the player is exploring and not near the ship, the player can attack and stagger their opponent before a battle. If the player confronts the staggered enemy then the battle will start with player advantage. This could mean, going first, double turn or even disarming enemies before a battle.

### Hunger/Thirst meter
* Going hungry or thirsty would lower a player’s stats such as attack or defense. Eating certain foods also give the player different buffs or debuffs depending on the consumable.
* Finding food and water sources will be crucial. Some consumables can be bad for the player and give a temporary debuff like less attack. While other foods can be good and give the player better stats, maybe abilities, or even prolonged the hunger and thirst meter.
* Possible implementations could include either a bar similar to health or be shown as a percentage. Some effects would be as simple as decreasing/increasing health or certain stats

### Upgrading equipment and ships
* Finding materials from other falling ships will help you upgrade your equipment and ship.
* Upgrading your equipment will increase your stats. The player can investigate ship wreckage and find blueprints and materials to upgrade the ship. Upgrading the ship can give it weapons for when enemies come or give it shields so that the player is safer when fighting near the ship.
* A list of available upgrades can be implemented and as the story is progressing more can be unlocked.

### Skill Tree
* The Combat skill tree will give the player various moves to do in combat, as well as the ability to attack enemies before a battle. It will possibly be divided into 4 subtrees which are melee, ranged, magic, or gadgets 
* The Mechanic skill tree will give the player abilities related to the ship. Skills in this tree will grant bonuses to ship defenses and traps.
* The Explorer skill tree will give the player abilities outside of combat like having food last longer, being able to gather more materials or finding it easier to spot enemies.
* Possible way to implement skill tree is a list containing all the skills organized by the type of skill where all of the skills are initially locked until the player gets the skill
