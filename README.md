# CS-4361.001-Team-Project

## Overview

The main objective of the Marble game is for players to navigate a three-dimensional maze using a marble, overcoming obstacles, avoiding pitfalls, and reaching the exit as quickly as possible. The challenge lies in mastering the physics-based controls, strategic decision-making, and precision to complete each maze within a given time limit. Players aim to achieve the best possible score by completing levels swiftly and efficiently, utilizing a balance of speed and accuracy in their marble navigation skills. The increasing complexity of maze designs and obstacles adds depth to the gameplay, ensuring a progressively challenging and engaging experience for players.

1. **Download and Extract:**
   - Download the ZIP folder containing the project files.
   - Extract the folder to your desired location on your computer.

2. **Open with Unity Hub:**
   - Open Unity Hub and add the extracted folder to your projects list.
   - Select the project in Unity Hub to open it.

3. **Scene Setup:**
   - Navigate to the "Scenes" folder in the project's assets.
   - Open the SampleScene window.
   - Click on the MazeGenerator object.
   - In the Inspector box on the left side, find the Rigidbody component of the MazeGenerator.
   - Set the "Interpolate" option to "None" if it is not set by default. Only change that option to "Interpolate" if needed.

4. **Scoring Calculation logic:**
   - By default, we have set 1000000 points as max score. The max points are divided by time taken to exit the maze.
   - The logic behind the scoring system is that the faster you solve the maze the more points you are awarded.

5. **How to start the Game:**
   - Open the Menu Scene whenever you want to start the game.
   - Then start the game by clicking the Play button.
   - Adjust the window size of scene as you needed.
   - Also adjust the main camera dimensions based on the maze you want to generate by using X and Y values.
