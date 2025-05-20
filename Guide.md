# COMP1151 Game Prototype Guide
This is a guide to how to approach the Game Prototype assessment type. Nothing in this guide is mandatory, it’s just my advice on how to attempt the assignment if you are unsure where to start, or what tools to use for a particular feature. 

- [COMP1151 Game Prototype Guide](#comp1151-game-prototype-guide)
  - [Learning Goals](#learning-goals)
  - [Player Experience](#player-experience)
  - [Game Mechanics](#game-mechanics)
    - [Avatar Movement](#avatar-movement)
    - [Camera](#camera)
    - [Danger \& Goals](#danger--goals)
    - [User Interface](#user-interface)
    - [Audio](#audio)
    - [Moving Environment Objects](#moving-environment-objects)
    - [Dynamically Generating Objects](#dynamically-generating-objects)

## Learning Goals
The aims of this assignment are:
* To assess your design thinking, including your ability to:
   1) imagine a player experience you want to create
   2) design specific game mechanics to achieve this experience
   3) evaluate and critique your work
* To assess your ability to use Unity to implement your vision, including a demonstration of specific features we have taught in lectures and pracs.

Keep these goals in mind when working on the assignment. Your goal is to clearly demonstrate these skills. Avoid spending time and effort on activities or game features which do not address these issues (e.g. writing a massive backstory for your game).

We have given you a design framework to work within, to limit the scope of your game and give you more structured questions to answer regarding your design. These mechanics have also been chosen to align with the Unity features we are hoping for you to demonstrate (as we’ll discuss below).

## Player Experience

Game design is an iterative process. Very rarely will you come to a project with a fully-fledged design idea before you start implementing it. Usually, you will go back and forth between design and implementation and discover the game design as you go. So, if you don’t have a strong game idea to start with, don’t worry. Start making something and see where it leads. Remember to come back to your design goals over time and see how they align with what you have made. Building a solid design vision and referring back to it often will help your game design feel purposeful and cohesive.

We’ve given you some broad requirements with the expectation that you refine them to create a specific game experience. Some questions you might want to ask yourself are:

* **Challenge**: What kind of skill is required to play my game well? E.g. is it about fast reaction time? Or careful planning? Or the ability to aim precisely? Or a sense of rhythm? Or something else? 
* **Drama**: What factors affect the intensity of the game (e.g. difficulty, speed, visual intensity, sound)? How do they change over time? What is the resulting dramatic arc?
* **Fantasy**: Who is the player within the game? What is the activity they are involved in? How do the other objects in the game make sense in this context?
* **Sensation**: How do your art and audio choices support the above? E.g. how does your art support your fantasy? Do you have sprites that clearly represent the player avatar and other objects in the world? How does your use of audio and music support the drama of your game?

The aim here is to find your own specific vision for the player experience, rather than just using the generic categories of ‘Challenge’, ‘Drama’, ‘Fantasy’ and ‘Sensation’. Ultimately you want to forge these ideas into a high concept that captures the uniqueness of your game.

For example, for the game I’ve demonstrated in lectures, I might design something like:

**Fantasy**: In a fantasy world. the player is a young villager who has ventured into the ruins of a great castle in search of mushrooms to sell in the market. The castle is haunted but ghosts who are blindly drawn to her life-force, to consume it. 

**Challenge**: The main skill is the ability to weave through the corridors of the dungeon to pick mushrooms while keeping the ghosts at bay. This involves physical dexterity in controlling the avatar, but also tactical planning to choose and time the routes they take to avoid ghosts and timed obstacles.

**Drama**: The intensity of the game is governed by two factors: the complexity of navigation and the number of ghosts. The levels should be designed to include areas of high and low intensity based on these factors. Specific moments of tension and relief will occur when the player is forced to wait for a door to open while ghosts are approaching.

**Sensation**: The pixel art is chosen to represent the fantasy setting, and also to convey a low level of seriousness (rather than a more ‘realistic’ horror game). Sound effects should match this setting and low level of realism, while also giving a sense of danger from the ghosts. Music should be cheery and ‘medieval’.

These would be my own design notes. As I worked on the game, I would revisit these ideas to check whether my mechanics match with my goals. When there is a mismatch, I would need to decide whether I should fix my mechanics or adapt my goals. 

## Game Mechanics

The game mechanics we've required vary in difficulty to design and implement. It’s a good idea to develop your game mechanics incrementally, starting with the most central ‘core’ elements of the game and building outwards. 

The list below is roughly in the order that I would consider implementing. We have included references to particular lectures and prac exercises relevant to each feature

### Avatar Movement
For the kind of game we’ve specified here, the core gameplay is player movement. So, start by asking yourself how the player avatar should move. Consider:
* What is the avatar? E.g. a person, an animal, a vehicle? How does that object move? A boat will move differently to a bird or a bowling ball. 
* What is the player’s view of the avatar? E.g. is it top-down or side-on. 
* What actions does the player use to navigate? E.g:
   - Up / down / left / right 
   - Forward / backward / turn left / turn right
   - Left / right / jump
* How do these actions map to a controller (keyboard or game controller). E.g:
   - WASD or arrow keys for 2D axes
   - Joysticks or DPad
   - Specific buttons to activate actions (like ‘jump’)
* How does movement interact with obstacles? E.g. friction, bounciness.

The movement system is the main ‘toy’ of this kind of game, so you want to make it first and tweak it to feel good. Moving well is going to be the main skill of your game, so try to find different kinds of level layouts that vary the skill required. E.g. navigating through open space may be easier than narrow, twisty corridors. 

From an implementation point of view, you will need to:
1)	Create an avatar sprite.
2)	Add a collider and rigidbody to your sprite.
3)	Make the rigidbody dynamic, so collision handling will be performed by the physics engine. 
4)	Disable the physics features you don’t want (including gravity and friction).
5)	Set up an Input Asset with the control mapping for your movement.
6)	Write a script that takes input values and applies appropriate movement to the rigidbody.
7)	Create a tile map with some obstacles (with static physics colliders).

Since the player needs to interact with obstacles, you probably want to use dynamic rigidbodies (rather than kinematic) so that the physics engine handles collisions for you. This means you will need to control your avatar using the Rigidbody (rather than directly with Transform). You will need to decide whether you want to use force or impulse or set the velocity directly to best achieve the movement scheme you want.

References:
* Sprites:
   - Prac Week 2: “The Scene View” section
* Colliders:
   - Dev Lecture Week 4
   - Prac Week 6
   - Prac Week 11
* Input Assets:
   - Dev Lecture Week 5
   - Prac Week 5: “The 'New' Unity InputSystem” section
* Rigidbody Physics:
   - Dev Lecture Week 10
   - Prac Week 11
* Tilemaps:
   - Prac Week 9

### Camera
Movement and camera go hand-in-hand, as the player needs to be able to see where they are going and react to obstacles in their path. Bad camera control can make the player frustrated or even nauseous.

For the assignment, we  want the game world to be bigger than a single screen, so the camera will need to move as the player moves around. If you want to attempt this, it is worth considering it early, as it will affect many of your other design decisions. 

Consider:
* How much of the world can the player see at a time?
* What triggers the camera to move?
* If the camera is moving, how far ahead of or behind the player should it be?

To implement this:
* Set the camera size to determine how much of the world is visible in one screen.
* Add a Cinemachine camera to your scene and set it to follow the player.
* Add suitable Cinemachine components (e.g. a Follower, a Position Composer, or a Cofiner) to control camera movement.

References:
* Camera:
   - Dev Lecture Week 11
   - Prac Week 12
* Cinemachine:
   - Dev Lecture Week 11
   - Prac Week 12

### Danger & Goals
The ‘bad things’ in your game are there to create a sense of danger. Hitting too many bad things will ultimately cause the game to end.
The ‘good things’ in your game are there to provide goals, directing players towards particular parts of your level. They reward the player for overcoming the challenges you present.

To implement them both, start by creating a single ‘good/bad thing’
* Give it a sprite.
* Give it a trigger collider.
* Add a script to the player to track the player score/health as an object variable.
* Add an event that increases or decreases this value when the player touches the good/bad thing.
* Add a script to the thing that determines what happens to it when it is touched (e.g. it may be destroyed or deactivated)

Create prefabs from these objects so you can make multiple copies of the good things and bad things in the world. 
* Lay out some bad things in your scene and see how they affect the movement. You can use these to increase the challenge of your game and to create tension.
* Lay out some good things in your scene to give the player goals to achieve. You can use these to lure the player into more challenging parts of the level or reward them for skilful play.

References:
* Sprites:
   - Week 2: “The Scene View” section
* Trigger Colliders:
   - Dev Lecture Week 5
   - Week 6: “Colliders” and “Which Collider is Right For You?” sections
* Trigger Events:
   - Dev Lecture Week 5
   - Week 6: “Destroy Player” section
* Tracking Variables:
   - Dev Lecture Week 5
   - Week 3: “The Coin Should Disappear” section
   - Week 6: “Player Health System” section
* Destroying Objects:
   - Dev Lecture Week 7
   - Week Week 6: “Destroy Player” section
   - Week 8: “Asteroid Destroyer” section
* Deactivating Objects:
   - Dev Lecture Week 5
   - Week 3: “The Coin Should Disappear” section
* Creating Prefabs:
   - Dev Lecture Week 7
   - Week 3: “Testing the Coin” section
   - Week 8: “Instantiating” section

### User Interface
Given that you are now tracking score and health, you want to display these to the player. The UI should be designed to provide the player with the information they need without being distracting from the gameplay. It should also be designed to be relatively device independent, automatically adjusting for screen size and resolution.

To implement:
* Add a Canvas to your scene
* Add UI elements to display the score and health
* Add decorations (e.g. labels or sprites) to clearly communicate what each of these UI elements means.
* Set the pivots and anchors of each element to attach to the appropriate part of the screen. 
* Configure the Canvas Scaler component to make your UI work at different resolutions.
* Test this works with different screen sizes and resolutions.

To update the UI to reflect the current score/health values you will need a UI Manager
* Add an empty UIManager object to your scene.
* Add an object variable to the UIManager to refer to the player object.
* Add object variables to the UIManager to refer to the UI elements you created.
* Add a script to the UIManager that reads the score and health variables from the player and sets the value of the UI Elements to match.

References:
* UI Design:
   - Dev Lecture Week 8
   - Week 9: “User Interface – Health” section
   - Week 10: All
* Adjusting UI Positioning and Size:
   - Dev Lecture Week 8
   - Week 9: “Anchors and Pivots” section
* UI Manager:
   - Dev Lecture Week 8
   - Week 10: “Creating a UI Manager” section

### Audio

To implement background music:
* Import the audio file you want to use into Unity
* Create a MusicManager object in the scene
* Add an audio source component to this object
* Configure the audio source to play your audio file (and loop it).

To implement sound effects:
* Import the audio file you want to use into Unity.
* Create an empty SoundEffect object.
* Add an audio source component to this object
* Configure the audio source to play your audio file.
* Add a script to the object to destroy itself when the sound finishes playing.
* Create a prefab from this object.
* When the sound effect should be played, instantiate a copy of this prefab in the script that handles the relevant event.

References:
* Audio:
   - Dev Lecture Week 13
   - Prac Week 3
   - Prac Week 12
* Instantiate Prefabs:
   - Dev Lecture Week 7
   - Prac Week 8

### Moving Environment Objects
While it seems simple, this could be one of the more complicated mechanics to implement using the tools you’ve learnt so far. So, consider whether there are other features you could prioritise for easier marks.

Adding movement to your obstacles, good things or bad things can influence the challenge they represent. Hitting or avoiding a moving target is intrinsically move difficult than a stationary one. 

Consider which of your objects you want to move, and how they should move. For this assignment, I recommend you keep this as simple as you can, e.g. moving in a straight line between two points, or moving towards a specific target. Designing complex movement AI gets tricky very fast. For this reason, you probably want to avoid movement that interacts with obstacles, at least until you are confident you know what you are doing.

To implement:
* Add a kinematic rigidbody to the object you want to move.
* Add a script that moves the object using Transform towards its goal.
* Add a test to detect when it reaches its goal (e.g. by calculating the distance to the target, or by using a collider).
* Add code to determine the outcome of reaching the goal.

More complex movement can be achieved using a state machine, but these are not a requirement of the assignment.

References:
* Kinematic Rigidbodies:
   - Dev Lecture Week 5
   - Prac Week 6
* Movement with Transform:
   - Dev Lecture Week 4
   - Prac Week 5
   - Prac Week 6
   - Prac Week 7Machine” sections
* Vector Math:
   - Dev Lecture Weeks 3,4
   - Prac Week 5: “Making the Ship Move Forward”, “Rotating the ship”, “Moving our Ship with Inputs” sections
   - Prac Week 6: “Make the Asteroids Move” section
   - Prac Week 7: “Chase State” and “Expanding our State Machine” sections
   - Prac Week 8: “Expanding the Asteroid Functionality” and “Implement shooting” section

### Dynamically Generating Objects
This can also be complicated to implement using the tools you’ve learnt. So, again, consider whether there are other features you could prioritise for easier marks.

Consider:
* How often do you want objects to spawn?
* Where do you want objects to spawn?

To implement:
* Create a spawner (factory) object in your scene. This may or may not have a visual representation in the game world. 
* Write a script that updates a timer variable, counting down to zero on each Update event (using deltaTime).
* Add an object variable containing a reference to the prefab you want to spawn (one of the good or bad things above).
* When the timer is zero:
   - Calculate the position at which you want to spawn the object.
   - Instantiate the prefab at that location.
   - Reset the timer 

You may want to use the Random node to randomise either the time between spawns or the location of the spawn.

References:
* Timers:
   - Prac Week 8: “Making a timer” section
* Instantiate Prefabs:
   - Dev Lecture Week 7
   - Prac Week 8: “Instantiating” section
* Randomness:
   - Dev Lecture Week 7
   - Prac Week 6: “(Challenge) Randomise Asteroid Movement” section

