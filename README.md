# COMP1151 Game Prototype

## Contents

- [Learning Outcomes](#learning-outcomes)
- [Deliverables:](#deliverables)
- [Design Task](#design-task)
  - [Player Experience](#player-experience)
  - [Game Mechanics](#game-mechanics)
  - [Art and Audio](#art-and-audio)
- [Implementation Task](#implementation-task)
  - [Sprites](#sprites)
  - [Tilemaps](#tilemaps)
  - [Movement using Transform](#movement-using-transform)
  - [Movement using Rigidbody](#movement-using-rigidbody)
  - [Keyboard Controls using an Input Asset](#keyboard-controls-using-an-input-asset)
  - [Gamepad Controls using an Input Asset](#gamepad-controls-using-an-input-asset)
  - [Trigger Colliders](#trigger-colliders)
  - [Physics colliders (5%)](#physics-colliders-5)
  - [Collision events (5%)](#collision-events-5)
  - [Prefabs](#prefabs)
  - [Prefab - Dynamic Instantiation](#prefab---dynamic-instantiation)
  - [Object deactivation or destruction](#object-deactivation-or-destruction)
  - [UI layout](#ui-layout)
  - [UI updating](#ui-updating)
  - [Camera - Basic](#camera---basic)
  - [Camera - Cinemachine](#camera---cinemachine)
  - [Audio - Looping](#audio---looping)
  - [Audio - Events](#audio---events)
  - [WebGL Build](#webgl-build)
- [Playtesting](#playtesting)
- [Report](#report)
- [Submission and Marking](#submission-and-marking)
  - [Marking Rubric](#marking-rubric)

# Learning Outcomes

* **ULO2**: Communicate game design and development decisions in appropriate formats.
* **ULO4**: Apply game design principles and processes in the production of a simple game.
* **ULO5**: Prototype a simple game within a 3D game engine.

# Deliverables:

* A link to a playable prototype of the game, uploaded to itch.io.
* The Unity project for the game
* A design document and techinical implementation report.

Your final grade will be based 50% on your design document and 50% on the implemetation of your Unity project.

# Design Task 

Your game design should meet the following requirements with regard to player experience and mechanics. You will need to refine these requirements for your particular design vision, but you should not significantly depart from these constraints.

While we encourage creativity, for marking purposes we require you to meet this requirements. If you want to make significant design changes or extended features, we recommend you do this in a private repository rather than your submitted game.

## Player Experience

The player experience should focus on the categories of **Challenge** and **Drama**. 
* **Challenge**: The game should present an interesting challenge that can be mastered with practice and skill.
* **Drama**: The intensity of the game should vary over time to create an engaging dramatic arc.

Secondary experience goals include **Fantasy** and **Sensation**.
* **Fantasy**: Your game should depict a consistent world and gameplay should make sense within that world. 
* **Sensation**: Art and audio choices should be made to support the above goals.

You should refine these broad goals to establish a specific design vision for your game. 

## Game Mechanics

The game should meet the following mechanical constraints.

* It is a 2D game designed to be playable in a web browser.
* The player controls an avatar that can be moved using either the keyboard or a gamepad controller (or both).
* The avatar moves in a world that is bigger than a single screen.
* There are obstacles in the world, which the avatar cannot move through.
* There are 'good things' in the world that can be collected, giving the player points.
* There are 'bad things' in the world. When the avatar touches a bad thing, they lose health.
* The game is over when the avatar has lost all of their health.
* Health and points are displayed as UI elements.
* Either the good things or the bad things (or both) should move.

You should refine these mechanics to create a suitable set of mechanics for your game, which achieve your player experience goals. 

## Art and Audio

You game should be made using art assets from the following sites:
* [Kenney.NL](https://kenney.nl/assets): You may use any 2D sprites, tilemaps, UI elements or audio assets from this site.
* **FIXME**: A source of royalty-free game audio loops.

You should not use any other art or audio in your game.

All art assets used should be cited at the end of your Report.

# Implementation Task

Your game must be built in **Unity 6.0.40f1**. This is the version we will use for marking. Any errors caused by using the incorrect version will cost you marks.

You game should be built using the template Unity project provided in this repository.

Your game must be developed using the Visual Scripting system in Unity. We will not mark any other code in your project. You may use any of the custom nodes included in the template Unity project.

Your game should demonstrate use of the following features. Marks will be assigned for correct implementation of each feature. The marks per feature are listed in the Report.

## Sprites

Objects in your game should be represented using sprites imported from one of the sites listed in [Art and Audio](#art-and-audio) above. 

## Tilemaps

The game world should be implemented using a tilemap created in Tiled, using tilemaps imported from one of the sites listed in [Art and Audio](#art-and-audio) above. The tilemap should include multiple layers, distinguishing background and interactable tiles (e.g walls). 

## Movement using Transform

At least one object in the scene should be moved using the Transform component (with or without a Kinematic Rigidbody). This object should not be affected by physics.

## Movement using Rigidbody

At least one object in the scene should be moved using a dynamic Rigidbody component, and should be affected by collisions with obstacles in the scene.

## Keyboard Controls using an Input Asset

A keyboard control mapping for the player avatar should be implemented using an Input Asset. 

## Gamepad Controls using an Input Asset

A gamepad control mapping for the player avatar should be implemented using an Input Asset. 

## Trigger Colliders

At least one object in the scene should implement a trigger collider to trigger a game mechanic. A suitable 2D collider shape should be used.

## Physics colliders (5%)

At least two objects in the scene should implement physics colliders. Suitable 2D colider shapes should be used. Suitable physics materials should be used to set friction and bounciness. The collisions generated should affect the motion of at least one of the objects.

## Collision events (5%)

One or more game object should respond to an appropriate collision event, from either a trigger collider or a physics collider.

## Prefabs

A custom prefab should be used to generate multiple identical copies of one game object.

## Prefab - Dynamic Instantiation

At least one object should be dynamically instantiated from a prefab in a script.

## Object deactivation or destruction

At least one object should be deactivated or destroyed as a result of in game events.

## UI layout

UI elements should be laid out on the screen using the builtin Unity UI system. The UI layout should handle screen resizing appropriately.

## UI updating

The UI should be dynamically updated to respond to events in the game.

## Camera - Basic

The camera should follow the player avatar around the scene.

## Camera - Cinemachine

The Cinemachine system should be used to design a more complex camera movement for tracking the player avatar.

## Audio - Looping

Looping background music or environmental audio should play throughout the game.

## Audio - Events

Audio clips should be played to respond to in game events.

## WebGL Build 

A WebGL build of your game should be made and uploaded to [itch.io](https://itch.io/), to be played in the browser. A link to the build should be included in your Report. This page may be make public or private, as you prefer. If the page is private, you should include the password to allow your TA to access it.

The itch.io page should include:
* Instructions on how to play the game.
* Credits for who made the game (i.e. you).
* A list of third-party art and audio assets used to create the game.

# Playtesting

When you have completed development of your game, you should invite at least two playtesters (friends, classmates, family, etc) to play your game and give you feedback. You should observe how they play and notice any patterns of play that arise. You should also ask your playtesters about their experience, to see whether you have achieved your design goals. You will be asked to reflect on this in your report (below). 

You should use this as an opportunity to genuinely evaluate your work and find areas for improvement. Good critical reflection is better than just saying "It's great!".

# Report

You should complete the template **Report.md** included in this repository. This report includes two sections:

1. **Design Document**: In this section you will answer questions about the design of your game. This will include a discussion of how you refined the player experience goals, and how the mechanical design choices you made supported these goals. You will also evaluate your design based on your playtesting.
2. **Implementation Document**: In this section you will list all of the required technical features you implemented and give details of where they can be located in your project.

# Submission and Marking

All deliverables will be submitted using this GitHub repository. Make sure to commit and push your work before the submission deadline. Any commits made after this deadline will be treated as late and standard late penalties will be applied (see the COMP1151 Unit Guide for details).

* Only work in the **main** branch of your repository will be marked. 
* Avoid renaming the Unity project or the Report.md file.

## Marking Rubric

Your final mark will be based 50% on the correctness of your implementation and 50% on your ability to describe your design. 

Implementation marks will be based on the correctness of each of the features listed above. The rubric used to mark each feature will be:

| Grade |  Criteria |
| ----- | --------- |
| HD (100) | Feature is free from any apparent errors, and is implemented in a clear and straight-forward way, making suitable use on Unity features. |
| D (80) | Minor errors which do not significantly affect performance. Implementation uses suitable Unity features but may be unclear or unneccessarily complicated. |
| CR (70) | Minor errors that affect performance. Implementation uses suitable Unity features but may problems are solved in convoluted ways. |
| P (60) | Feature is functional but has major flaws. Implementation includes unsuitable or irrelevant features. |
| F (0-40) | Feature is unrecognisable to what is asked for in the specifications or features a game breaking bug. |

Design will be based on you answers in the Design Document section of your report. The rubric used to assess your answers will be:

| Grade |  Criteria |
| ----- | --------- |
| HD (100) | Design goals and mechanics are creatively refined with deliberate intent to create a specific experience. Answers show an insightful understanding of the connection between mechanics and experience. Playtesting evaluates both player experience and behaviour, providing insights into their connection. Critical reflection of the game recognises both successes and specific areas for improvment. |
| D (80) | Design goals are refined with to create a specific experience. Game mechanics are designed to meet these goals, although some elements may need work. Answers show a clear understanding of the connection between mechanics and experience. Playtesting evaluates both player experience and behaviour, with some awareness of their connection. Critical reflection of the game recognises both successes and general areas for improvment. |
| CR (70) | Design goals are refined with to create a generic experience. Game mechanics are designed to meet these goals, although some elements may be poorly thought out. Answers show a general understanding of the connection between mechanics and experience, with some vagueness. Playtesting evaluates both player experience and behaviour, but lacks awareness of their connection. Critical reflection of the game recognises both successes and failures, but suggestions for improvement are weak.  |
| P (60) | Design goals are reiterated but not substantially refined. Game mechanics are described but their justificaiton in terms of player experience is weak. Playtesting evaluates player experience or behavour, but provides little useful evaluation. Critical reflection of the game recognises both successes and failures, but doesn't provide meaningful areas of improvement. |
| F (0-40) | Significant design goals are neglected. Game mechanics deviate significantly from requirements. Little to no awareness of the connection between mechanics and experience is exhibited. There is no evidence of meaningful playtesting. Critical reflection is shallow or one-sided and fails to recognise significant design problems.  |
