# EcsRunnerGit

# Description
The project is a game of HowRunner. In this file we provide information about the project, its structure and decisions made.

# Project history
At the beginning of the development we used another repository with the initial project and planned to use Git Flow to organize the work on the project. However, based on our experience working on previous projects, we encountered problems with losing the project as a result of not using Git Flow correctly.

Based on this experience, we decided to change our approach to project development. Instead of using Git Flow entirely, we decided to divide responsibilities among team members to work more efficiently. Abdullah focuses on developing and improving the core gameplay (cor gameplay) and transitioning to the new architecture. At the same time, I am responsible for the user interface development (UI/UX) and the visual design of the game (Art Design).

This decision was made in order to increase the efficiency of each team member. It allows us to focus on our areas of expertise and achieve intermediate results faster. It also allows us to track changes more easily and combine our work into the final result.

# Project structure
The project consists of the following components:

#  Core gameplay (Abdulla's responsibility):
The gameplay consists in the fact that the platform on which the player moves has several faces (this version has 4 faces, but can be changed in configuration up to 12, however there are no corresponding prefabs). The player can rotate the platform and change its location on the faces. Obstacles are generated on the platform. If player moves to platform which already has an obstacle, he will legally fall down, if player hits an obstacle, he will trample on place.


![image](https://github.com/Iskvnder/EcsRunnerGit/assets/100485088/d60702fe-762d-43c7-9945-d0c35eb349d3)

# UI/UX и Art Design:

The design for our game is intuitive, simple and uncluttered.
The main design elements are done in bright colours with the use of pictures
or gradients.


![image](https://github.com/Iskvnder/EcsRunnerGit/assets/100485088/1326dca7-3eb2-4a23-9701-77ce8c7ed3c0)


Cartoonish design was chosen because it covers the basic needs of the visual
style of the game:
1. Appealing to a wide audience: Cartoonish design is great for casual games
that appeal to a wide audience. This style can be appealing to children and
adults, and can help create a fun and friendly feel to the game.
2. Simplicity: Cartoonish design is easy to create and requires little effort to
create details and realistic elements, which can be difficult to create and
optimize in games with realistic designs. This can save time and resources
for game development
3. Optimization: Cartoonish design makes it easy to optimize game graphics
to work on mobile devices. This can help ensure the game runs smoothly,
reduce resource usage of the device and improve overall performance.
4. Ease of perception: Cartoonish design can help simplify the game experience
for players, thanks to its simple, yet vivid and noticeable graphics. This can
help make the game more accessible and enjoyable for players.
5. Easy to modify: Cartoonish design is easily modifiable and scalable. If
developers want to change the design of characters, objects or backgrounds,
they can easily do so without disturbing the style of the game.

![image](https://github.com/Iskvnder/EcsRunnerGit/assets/100485088/b51296ec-2110-4d2c-b283-691b2d0dc1f0)


# Instructions for installing and running the project
1. Install Unity 2021.3.19f1
2. Download the project as a ZIP file 
3. open it in the Unity editor

! To try the game on your mobile device
1. Open Build Settings in the editor
2. Change your platform from Windows to IOS or Android
3. Download the Unity Remote app to your mobile device
4. Connect your mobile device with Unity Remote switched on to your computer via USB cable
5. Select Project Setting -> Device -> your mobile device
6. Press start button in Unity

! When trying to open the game on iOS devices you may also need to download Apple iTunes
