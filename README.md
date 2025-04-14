# COMP1151 Game Prototype

## Learning Outcomes

## Deliverables:

* A link to a playable prototype of the game, uploaded to itch.io.
* The Unity project for the game
* A design document
* A techinical implementation documemnt

## Grade Components

Your grade will be calculated as the average of two components: Design and Implementation. Specific requirements are provided for each component, as outlined in the following sections.

## Design Task

Your game design should meet the following requirements with regard to player experience and mechanics.

### Player Experience

The player experience should focus on the categories of **Challenge** and **Drama**. 
* **Challenge**: The game should present an interesting challenge that can be mastered with practice.
* **Drama**: The intensity of the game should vary over time to create an engaging dramatic arc.

You should refine these broad goals to establish a specific design vision for your game. 

### Mechanics

The game should meet the following mechanical constraints.

* It is a 2D game made using any of the sprites provided in the framework project. No other art should be used in the game.
* The player controls an avatar that can be moved using either the keyboard or a gamepad controller.
* There are 'good things' in the world. When the avatar touches a good thing, they gain points.
* There are 'bad things' in the world. When the avatar touches a bad thing, they lose health.
* There are obstacles in the world, which the avatar cannot move through.
* The game is over when the avatar has lost all of their health.
* Health and points are displayed as UI elements.

You should refine these mechanics to create a suitable set of mechanics for your game, which achieve your player experience goals. 

## Implementation Task

Your game must be built in **Unity 6.0.40f1**. This is the version we will use for marking. Any errors caused by using the incorrect version will cost you marks.

Your game must be developed using the Visual Scripting system in Unity. We will not mark any other code in your project. 

Your game should demonstrate use of the following features. Marks will be assigned for correct implementation of each feature, as indicated below.

### Movement using Transform (10%)

At least one object in the scene should be moved using the Transform component (with or without a Kinematic Rigidbody). This object should not be affected by physics.

### Movement using Rigidbody (5%)

At least one object in the scene should be moved using a dynamic Rigidbody component, and should be affected by collisions with obstacles in the scene.

### Keyboard Controls using an Input Asset (5%)

A keyboard control mapping for the player avatar should be implemented using an Input Asset. 

### Gamepad Controls using an Input Asset (5%)

A gamepad control mapping for the player avatar should be implemented using an Input Asset. 

### Trigger Colliders (5%)

At least one object in the scene should implement a trigger collider.

### Physics colliders (5%)

At least two objects in the scene should implement physics colliders. The collisions generated should affect the motion of at least one of the objects.

### Collision events (5%)

One or more game object should respond to a an appropriate collision event, from either a trigger collider or a physics collider.

### State machine (5%)

At least one object in the scene should be controlled using a state machine script with at least 3 meaningfully different states.

### Prefabs (5%)

A custom prefab should be used to generate multiple identical copies of one game object.

### Prefab - Dynamic Instantiation (10%)

At least one object should be dynamically instantiated from a prefab in a script.

### Object deactivation or destruction (5%)

At least one object should be deactivated or destroyed as a result of in game events.

### UI layout (10%)

UI elements should be laid out on the screen using the builtin Unity UI system. The UI layout should handle screen resizing appropriately.

### UI updating (5%)

The UI should be dynamically updated to respond to events in the game.

### Camera - Basic (5%)

The camera should follow the player avatar around the scene.

### Camera - Cinemachine (5%)

The Cinemachine system should be used to design a more complex camera movement for tracking the player avatar.

### Audio - Looping (5%)

Looping background music should play throughout the game.

### Audio - Events (5%)

Audio clips should be played to respond to in game events.

## Submission

## Marking Rubric

